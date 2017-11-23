using System;
using System.IO;
using System.Linq;
using Kubernetes.DotNet.Client;
using RestSharp;
using YamlDotNet.Serialization;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// 
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
        /// The home path environment variable in Windows platform.
        /// </summary>
        private static string WINDOWS_HOMEPATH = "USERPROFILE";
        
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
                throw new ApplicationException("Invalid kube config.");

            // Build API client
            ApiClient client = new ApiClient(cluster.Server);
            switch (authType)
            {
                case AuthType.BasicAuth:
                    client.RestClient.Authenticator = new HttpBasicAuthenticator(user.UserName, user.Password);
                    break;
                
                case AuthType.TokenAuth:
                    client.RestClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(user.Token);
                    break;  // TODO, verify out token auth
                
                case AuthType.SSLAuth:
                    break;  // TODO, use bouncy castle to generate pfx

                default:
                    break;
            }
            return new KubernetesClient(new Configuration(client));
        }

        /// <summary>
        /// Parses kubernetes config from specified path to <see cref="KubeConfig"/> object.
        /// </summary>
        /// <returns>The <see cref="KubeConfig"/>.</returns>
        public KubeConfig ParseKubeConfig()
        {
            FileInfo kubeConfigFileInfo = new FileInfo(Path.Combine(KubeConfigClientConfiguration.WINDOWS_HOMEPATH, KubeConfigClientConfiguration.KUBE_CLIENT_CONFIG_PATH));
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
        public bool TryGetCurrentContext(KubeConfig config, out Cluster cluster, out User user)
        {
            cluster = default(Cluster);
            user = default(User);

            if (null == config)
                return false;

            string currentContext = string.IsNullOrWhiteSpace(this.CurrentContext) ? config.CurrentContext : this.CurrentContext;
            if (string.IsNullOrWhiteSpace(currentContext))
                return false;
            
            Context context = config.Contexts.FirstOrDefault(p => p.Name == currentContext);
            cluster = config.Clusters.FirstOrDefault(p => p.Name == context.Cluster);
            user = config.Users.FirstOrDefault(p => p.Name == context.User);
            return true;
        }
    }
}
