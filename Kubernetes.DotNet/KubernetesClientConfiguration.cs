using System;

namespace Kubernetes.DotNet
{
    /// <summary>
    /// Sets up the K8s client configuration.
    /// </summary>
    public class KubernetesClientConfiguration
    {
        public string MasterUrl => this.masterUrl;
        public string ApiVersion => this.apiVersion;
        public string Namespace => this._namespace;

        private string masterUrl;
        private string apiVersion;
        private string _namespace;

        public KubernetesClientConfiguration(string masterUrl)
            : this(masterUrl, "v1", "default")    
        {
        }

        public KubernetesClientConfiguration (string masterUrl, string apiVersion, string _namespace)
        {
            if (null == masterUrl || string.IsNullOrWhiteSpace(masterUrl))
                throw new ApplicationException($"Missing required field {nameof(masterUrl)}.");

            this.masterUrl = masterUrl;
            this.apiVersion = apiVersion;
            this._namespace = _namespace;
        }

        public IKubernetesClient CreateClientInstance()
        {
            return new KubernetesClient(this);
        }
    }
}