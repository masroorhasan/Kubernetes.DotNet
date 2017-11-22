using System.Linq;
using Kubernetes.DotNet.Config;

namespace Kubernetes.DotNet
{
    /// <summary>
    /// Sets up the Kubernetes client configuration to override defaults of <see cref="KubeConfig"/>.
    /// </summary>
    public class KubernetesClientConfiguration
    {
        /// <summary>
        /// The master Url.
        /// </summary>
        public string MasterUrl { get; set; }

        /// <summary>
        /// The Api version.
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// The current context.
        /// </summary>
        public string CurrentContext { get; set; }

        /// <summary>
        /// The username.
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// The client certificate key.
        /// </summary>
        public string ClientCertificatePath { get; set; }

        /// <summary>
        /// The client certificate password.
        /// </summary>
        public string ClientCertificatePassword { get; set; }

        /// <summary>
        /// The Kubernetes <see cref="Cluster"/>.
        /// </summary>
        public Cluster Cluster { get; set; }

        /// <summary>
        /// The Kubernetes <see cref="User"/>.
        /// </summary>
        public User User { get; set; }
        
        /// <summary>
        /// The <see cref="KubeConfig"/> object.
        /// </summary>
        private KubeConfig kubeConfig;

        /// <summary>
        /// The <see cref="KubernetesClientConfiguration"/> ctr.
        /// Sets up configuration from /.kube/config.
        /// </summary>
        public KubernetesClientConfiguration()
        {
            this.kubeConfig = ConfigUtils.ParseKubeConfig();
        }

        /// <summary>
        /// Creates an instance of <see cref="IKubernetesClient"/>.
        /// </summary>
        /// <returns>A k8s client instance.</returns>
        public IKubernetesClient CreateClientInstance()
        {
            if (string.IsNullOrWhiteSpace(this.MasterUrl))
                this.MasterUrl = this.kubeConfig.Clusters?.FirstOrDefault().ClusterData["server"];

            if (string.IsNullOrWhiteSpace(this.ApiVersion))
                this.ApiVersion = this.kubeConfig.ApiVersion;

            if (string.IsNullOrWhiteSpace(this.CurrentContext))
                this.CurrentContext = this.kubeConfig.CurrentContext;

            if (string.IsNullOrWhiteSpace(this.UserName))
                this.UserName = this.kubeConfig.Users?.FirstOrDefault().Name;

            if (null != this.kubeConfig.Clusters)
                this.Cluster = this.kubeConfig.Clusters?.FirstOrDefault();

            if (null != this.kubeConfig.Users)
                this.User = this.kubeConfig.Users?.FirstOrDefault();

            return new KubernetesClient(this);
        }
    }
}