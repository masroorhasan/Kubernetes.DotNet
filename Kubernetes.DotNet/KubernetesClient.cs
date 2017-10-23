using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;
using System.Net.Security;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;

namespace Kubernetes.DotNet
{
    /// <summary>
    /// The implemetation of <see cref="IKubernetesClient"/> to interact with provided K8s Remote APIs.
    /// </summary>
    public class KubernetesClient : IKubernetesClient
    {
        public KubernetesClientConfiguration Configuration { get; }

        public IApiregistration_v1beta1Api ApiRegistrationApi { get; }
        
        public IApps_v1beta1Api AppsApi { get; }
        
        public IAuthentication_v1Api AuthenticationApi { get; }
        
        public IAuthorization_v1Api AuthorizationApi { get; }
        
        public IAutoscaling_v1Api AutoscalingApi { get; }
        
        public IBatch_v1Api BatchApi { get; }
        
        public ICertificates_v1beta1Api CertificatesApi { get; }
        
        public ICore_v1Api CoreApi { get; }
        
        public IExtensions_v1beta1Api ExtensionsApi { get; }
        
        public ILogsApi LogsApi { get; }
        
        public INetworking_v1Api NetworkingApi { get; }
        
        public IPolicy_v1beta1Api PolicyApi { get; }
        
        public IRbacAuthorization_v1beta1Api RoleBasedControlAuthorizationApi { get; }
        
        public IStorage_v1Api StorageApi { get; }
        
        public IVersionApi VersionApi { get; }

        private ApiClient httpClient;

        /// <summary>
        /// The internal <see cref="KubernetesClient"/> ctr.
        /// </summary>
        /// <param name="configuration">The <see cref="KubernetesClientConfiguration"/>.</param>
        internal KubernetesClient(KubernetesClientConfiguration configuration)
        {
            if (null == configuration)
                throw new ApplicationException($"Missing required argument {nameof(configuration)}");
            this.Configuration = configuration;

            // Set up the http client
            ApiClient httpClient = new ApiClient(configuration.MasterUrl);
            // httpClient.HttpClient = this.SetupHttpClient();
            // httpClient.HttpClient.BaseAddress = new Uri(configuration.MasterUrl);

            // Initialize endpoints
            this.ApiRegistrationApi = new Apiregistration_v1beta1Api(httpClient);
            this.AppsApi = new Apps_v1beta1Api(httpClient);
            this.AuthenticationApi = new Authentication_v1Api(httpClient);
            this.AuthorizationApi = new Authorization_v1Api(httpClient);
            this.AutoscalingApi = new Autoscaling_v1Api(httpClient);
            this.BatchApi = new Batch_v1Api(httpClient);
            this.CertificatesApi = new Certificates_v1beta1Api(httpClient);
            this.CoreApi = new Core_v1Api(httpClient);
            this.ExtensionsApi = new Extensions_v1beta1Api(httpClient);
            this.LogsApi = new LogsApi(httpClient);
            this.NetworkingApi = new Networking_v1Api(httpClient);
            this.PolicyApi = new Policy_v1beta1Api(httpClient);
            this.RoleBasedControlAuthorizationApi = new RbacAuthorization_v1beta1Api(httpClient);
            this.StorageApi = new Storage_v1Api(httpClient);
            this.VersionApi = new VersionApi(httpClient);
        }

        /// <summary>
        /// Sets up the DotNet HttpClient.
        /// </summary>
        /// <returns>The HttpClient.</returns>
        private HttpClient SetupHttpClient()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.SslProtocols = System.Security.Authentication.SslProtocols.Tls12;

            // MacOS: System.PlatformNotSupportedException
            // $NOTE: Because in macOS, the default libcurl built against SecureTransport doesn't provide the callback 
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            handler.ClientCertificates.Add(new X509Certificate2(this.Configuration.ClientCertificateKey, this.Configuration.ClientCertificatePassword));
            return new HttpClient(handler);
        }
    }
}