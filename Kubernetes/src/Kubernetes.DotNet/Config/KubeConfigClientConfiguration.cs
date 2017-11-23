using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Kubernetes.DotNet.Client;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using RestSharp;
using YamlDotNet.Serialization;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// The <see cref="IClientConfiguration"/> implementation which is built from client's kube config.
    /// </summary>
    public class KubeConfigClientConfiguration : IClientConfiguration
    {
        /// <summary>
        /// The current context.
        /// </summary>
        public string CurrentContext { get; set; }

        /// <summary>
        /// The KubeConfig path.
        /// </summary>
        private static string KUBE_CLIENT_CONFIG_PATH = ".kube\\config";
        
        /// <summary>
        /// Initializes the <see cref="KubeConfigClientConfiguration"/>.
        /// </summary>
        public KubeConfigClientConfiguration()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="IKubernetesClient"/>.
        /// </summary>
        /// <param name="authType">The authentication type.</param>
        /// <returns>Instance of <see cref="IKubernetesClient"/>.</returns>
        public IKubernetesClient CreateClient(AuthType authType)
        {
            // Parse from kube config file
            KubeConfig kubeConfigFile = this.ParseKubeConfig();
            if (!this.TryGetCurrentContext(kubeConfigFile, out Cluster cluster, out User user))
                throw new ApplicationException("Invalid config in %USERPROFILE%\\.kube\\config.");

            // Build API client
            ApiClient client = new ApiClient(cluster.ClusterData.Server);
            switch (authType)
            {
                case AuthType.BasicAuth:
                    client.RestClient.Authenticator = new HttpBasicAuthenticator(user.UserData.UserName, user.UserData.Password);
                    break;
                
                case AuthType.TokenAuth:
                    client.RestClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(user.UserData.Token);
                    break;
                
                case AuthType.SSLAuth:
                    X509Certificate2 certificate = this.GenerateClientCert(user);
                    client.RestClient.ClientCertificates = new X509CertificateCollection() { certificate };
                    break;

                default:
                    break;
            }
            return new KubernetesClient(new Configuration(client));
        }

        /// <summary>
        /// Parses kubernetes config from specified path to <see cref="KubeConfig"/> object.
        /// </summary>
        /// <returns>The <see cref="KubeConfig"/>.</returns>
        private KubeConfig ParseKubeConfig()
        {
            FileInfo kubeConfigFileInfo = new FileInfo(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile, Environment.SpecialFolderOption.None), KubeConfigClientConfiguration.KUBE_CLIENT_CONFIG_PATH));

            if (!kubeConfigFileInfo.Exists)
                throw new Exception($"Kubernetes config file does not exist in path: ${kubeConfigFileInfo.FullName}.");

            KubeConfig config = default(KubeConfig);
            using (StreamReader reader = File.OpenText(kubeConfigFileInfo.FullName))
            {
                config = new Deserializer().Deserialize<KubeConfig>(reader);
            }
            return config;
        }

        /// <summary>
        /// Gets configuration components based off current context.
        /// </summary>
        /// <param name="config">The <see cref="KubeConfig"/>.</param>
        /// <param name="cluster">The <see cref="Cluster"/>.</param>
        /// <param name="user">The <see cref="User"/>.</param>
        /// <returns>True on success, false otherwise.</returns>
        private bool TryGetCurrentContext(KubeConfig config, out Cluster cluster, out User user)
        {
            cluster = default(Cluster);
            user = default(User);

            if (null == config)
                return false;

            string currentContext = string.IsNullOrWhiteSpace(this.CurrentContext) ? config.CurrentContext : this.CurrentContext;
            if (string.IsNullOrWhiteSpace(currentContext))
                return false;
            
            Context context = config.Contexts.FirstOrDefault(p => p.Name == currentContext);
            cluster = config.Clusters.FirstOrDefault(p => p.Name == context.ContextData.Cluster);
            user = config.Users.FirstOrDefault(p => p.Name == context.ContextData.User);
            return true;
        }

        /// <summary>
        /// Generates the PFX client certificate.
        /// </summary>
        /// <param name="user">The config <see cref="User"/>.</param>
        /// <returns>The client certificate.</returns>
        private X509Certificate2 GenerateClientCert(User user)
        {
            if (null == user)
                throw new Exception($"Missing required parameter {nameof(user)}.");

            if (!this.TryGetDataFromBase64String(user.UserData.ClientCertificateData, out byte[] clientCertData))
                throw new Exception($"Invalid base54 {nameof(user.UserData.ClientCertificateData)} string.");

            if (!this.TryGetDataFromBase64String(user.UserData.ClientKeyData, out byte[] clientKeyData))
                throw new Exception($"Invalid base64 {nameof(user.UserData.ClientKeyData)} string.");

            // Generate RSA key
            object obj = default(object);
            using (StreamReader reader = new StreamReader(new MemoryStream(clientKeyData)))
            {
                obj = new PemReader(reader).ReadObject();
                var key = obj as AsymmetricCipherKeyPair;
                if (null != key)
                {
                    var cipherKey = key;
                    obj = cipherKey.Private;
                }
            }
            RsaPrivateCrtKeyParameters rsaPrivateKeyParams = (RsaPrivateCrtKeyParameters)obj;

            // Save cert entry in pkcs12 store 
            Org.BouncyCastle.X509.X509Certificate clientCert = new X509CertificateParser().ReadCertificate(new MemoryStream(clientCertData));
            Pkcs12Store store = new Pkcs12StoreBuilder().Build();
            store.SetKeyEntry("K8SKEY", new AsymmetricKeyEntry(rsaPrivateKeyParams), new[] { new X509CertificateEntry(clientCert) });

            // Generate pfx 
            using (MemoryStream pkcsStream = new MemoryStream())
            {
                store.Save(pkcsStream, new char[0], new SecureRandom());
                return new X509Certificate2(pkcsStream.ToArray());
            }
        }

        /// <summary>
        /// Get the data from base64 string.
        /// </summary>
        /// <param name="base64String">Base64 string.</param>
        /// <param name="base64Data">The data.</param>
        /// <returns>True on success, false otherwise.</returns>
        private bool TryGetDataFromBase64String(string base64String, out byte[] base64Data)
        {
            base64Data = default(byte[]);
            if (string.IsNullOrWhiteSpace(base64String))
                return false;

            base64Data = Convert.FromBase64String(base64String);
            return null != base64Data && 0 != base64Data.Length;
        }
    }
}
