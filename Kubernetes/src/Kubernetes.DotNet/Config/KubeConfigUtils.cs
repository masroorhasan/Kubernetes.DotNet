using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using YamlDotNet.Serialization;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// 
    /// </summary>
    public class KubeConfigUtils
    {
        /// <summary>
        /// The KubeConfig path.
        /// </summary>
        private static string KUBE_CLIENT_CONFIG_PATH = ".kube\\config";

        /// <summary>
        /// Parses kubernetes config from specified path to <see cref="KubeConfig"/> object.
        /// </summary>
        /// <returns>The <see cref="KubeConfig"/>.</returns>
        public static KubeConfig ParseKubeConfig(string path = null)
        {
            string kubeConfigFilePath = path ?? Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile, Environment.SpecialFolderOption.None), KubeConfigUtils.KUBE_CLIENT_CONFIG_PATH);
            FileInfo kubeConfigFileInfo = new FileInfo(kubeConfigFilePath);

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
        public static bool TryGetCurrentContext(KubeConfig config, out Cluster cluster, out User user)
        {
            cluster = default(Cluster);
            user = default(User);

            if (null == config)
                return false;
            
            Context context = config.Contexts.FirstOrDefault(p => p.Name == config.CurrentContext);
            cluster = config.Clusters.FirstOrDefault(p => p.Name == context.ContextData.Cluster);
            user = config.Users.FirstOrDefault(p => p.Name == context.ContextData.User);
            return true;
        }

        /// <summary>
        /// Generates the PFX client certificate.
        /// </summary>
        /// <param name="user">The config <see cref="User"/>.</param>
        /// <returns>The client certificate.</returns>
        public static X509Certificate2 GenerateClientCert(User user)
        {
            if (null == user)
                throw new Exception($"Missing required parameter {nameof(user)}.");

            if (!KubeConfigUtils.TryGetDataFromBase64String(user.UserData.ClientCertificateData, out byte[] clientCertData))
                throw new Exception($"Invalid base54 {nameof(user.UserData.ClientCertificateData)} string.");

            if (!KubeConfigUtils.TryGetDataFromBase64String(user.UserData.ClientKeyData, out byte[] clientKeyData))
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
        private static bool TryGetDataFromBase64String(string base64String, out byte[] base64Data)
        {
            base64Data = default(byte[]);
            if (string.IsNullOrWhiteSpace(base64String))
                return false;

            base64Data = Convert.FromBase64String(base64String);
            return null != base64Data && 0 != base64Data.Length;
        }
    }
}
