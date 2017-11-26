using System;
using System.Security.Cryptography.X509Certificates;
using Kubernetes.DotNet.Client;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// The <see cref="IClientConfiguration"/> implementation that uses SSL authentication.
    /// </summary>
    public class SslClientConfiguration : IClientConfiguration
    {
        #region SSL_AUTH
        /// <summary>
        /// The cluster uri.
        /// </summary>
        public Uri ClusterUri { get; set; }

        /// <summary>
        /// The client certificate.
        /// </summary>
        public X509Certificate2 Certificate { get; set; }
        #endregion
        
        /// <summary>
        /// Initializes the <see cref="SslClientConfiguration"/>.
        /// </summary>
        public SslClientConfiguration()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="IKubernetesClient"/>.
        /// </summary>
        /// <param name="authType">The authentication type.</param>
        /// <returns>Instance of <see cref="IKubernetesClient"/>.</returns>
        public IKubernetesClient CreateClient(AuthType authType = AuthType.SSLAuth)
        {
            if (AuthType.SSLAuth != authType)
                throw new Exception(string.Format("Invalid auth type {0} for {1}.", authType, nameof(SslClientConfiguration)));

            if (null == this.ClusterUri)
                throw new ApplicationException(string.Format("Missing required argument {0}", nameof(this.ClusterUri)));

            if (null == this.Certificate)
                throw new ApplicationException(string.Format("Missing required argument {0}", nameof(this.Certificate)));

            ApiClient client = new ApiClient(this.ClusterUri.AbsoluteUri);
            client.RestClient.ClientCertificates = new X509CertificateCollection() { this.Certificate };
            return new KubernetesClient(new Configuration(client));
        }
    }
}
