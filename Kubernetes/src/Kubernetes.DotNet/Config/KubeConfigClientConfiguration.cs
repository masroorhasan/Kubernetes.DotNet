using System;
using System.Security.Cryptography.X509Certificates;
using Kubernetes.DotNet.Client;
using RestSharp;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// The <see cref="IClientConfiguration"/> implementation which is built from client's kube config.
    /// </summary>
    public class KubeConfigClientConfiguration : IClientConfiguration
    {
        /// <summary>
        /// Path specified to kube config manifest file.
        /// </summary>
        private string kubeConfigFilePath;
        
        /// <summary>
        /// Initializes the <see cref="KubeConfigClientConfiguration"/>.
        /// </summary>
        public KubeConfigClientConfiguration(string kubeConfigFilePath = null)
        {
            this.kubeConfigFilePath = kubeConfigFilePath;
        }

        /// <summary>
        /// Creates a new instance of <see cref="IKubernetesClient"/>.
        /// </summary>
        /// <param name="authType">The authentication type.</param>
        /// <returns>Instance of <see cref="IKubernetesClient"/>.</returns>
        public IKubernetesClient CreateClient(AuthType authType)
        {
            // Parse kube config from path
            KubeConfig kubeConfigFile = KubeConfigUtils.ParseKubeConfig(this.kubeConfigFilePath);

            // Get current context from kube config
            Cluster cluster = default(Cluster);
            User user = default(User);
            if (!KubeConfigUtils.TryGetCurrentContext(kubeConfigFile, out cluster, out user))
                throw new ApplicationException("Invalid config in %USERPROFILE%\\.kube\\config.");

            // Build client
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
                    client.RestClient.ClientCertificates = new X509CertificateCollection() { KubeConfigUtils.GenerateClientCert(user) };
                    break;

                default:
                    break;
            }
            return new KubernetesClient(new Configuration(client));
        }
    }
}
