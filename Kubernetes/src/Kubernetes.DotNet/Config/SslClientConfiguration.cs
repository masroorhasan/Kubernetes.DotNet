using System;
using System.Security.Cryptography.X509Certificates;
using Kubernetes.DotNet.Client;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// 
    /// </summary>
    public class SslClientConfiguration : IClientConfiguration
    {
        #region SSL_AUTH
        /// <summary>
        /// The master Url.
        /// </summary>
        public Uri MasterUrl { get; set; }

        /// <summary>
        /// The client certificate.
        /// </summary>
        public X509Certificate2 Certificate { get; set; }

        /// <summary>
        /// Skip TLS verification.
        /// </summary>
        public bool SkipTlsVerify { get; set; }
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
        public IKubernetesClient CreateClient(AuthType authType)
        {
            if (AuthType.SSLAuth != authType)
                throw new Exception($"Invalid auth type for {nameof(SslClientConfiguration)}.");

            if (null == this.MasterUrl)
                throw new ApplicationException($"Missing required argument {nameof(this.MasterUrl)}");

            if (null == this.Certificate)
                throw new ApplicationException($"Missing required argument {nameof(this.Certificate)}");

            ApiClient client = new ApiClient(this.MasterUrl.AbsoluteUri);
            client.RestClient.ClientCertificates = new X509CertificateCollection() { this.Certificate };
            return new KubernetesClient(new Configuration(client));
        }
    }
}
