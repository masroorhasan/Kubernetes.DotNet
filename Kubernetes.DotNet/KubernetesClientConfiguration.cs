using System;
using System.IO;
using System.Linq;
using Kubernetes.DotNet.Config;
using YamlDotNet.Serialization;

namespace Kubernetes.DotNet
{
    /// <summary>
    /// Sets up the K8s client configuration.
    /// </summary>
    public class KubernetesClientConfiguration
    {
        public string MasterUrl {get; set;}
        public string ApiVersion {get; set;}
        public string CurrentContext {get; set;}
        public string UserName {get; set;}
        public string ClientCertificateKey {get; set;}
        public string ClientCertificatePassword {get; set;}

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
            
            return new KubernetesClient(this);
        }
    }
}