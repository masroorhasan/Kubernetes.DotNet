using System;
using Kubernetes.DotNet.Api;

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

        internal KubernetesClient(KubernetesClientConfiguration configuration)
        {
            if (null == configuration)
                throw new ApplicationException($"Missing required argument {nameof(configuration)}");
            this.Configuration = configuration;

            // Initialize endpoints
            this.ApiRegistrationApi = new Apiregistration_v1beta1Api(configuration.MasterUrl);
            this.AppsApi = new Apps_v1beta1Api(configuration.MasterUrl);
            this.AuthenticationApi = new Authentication_v1Api(configuration.MasterUrl);
            this.AuthorizationApi = new Authorization_v1Api(configuration.MasterUrl);
            this.AutoscalingApi = new Autoscaling_v1Api(configuration.MasterUrl);
            this.BatchApi = new Batch_v1Api(configuration.MasterUrl);
            this.CertificatesApi = new Certificates_v1beta1Api(configuration.MasterUrl);
            this.CoreApi = new Core_v1Api(configuration.MasterUrl);
            this.ExtensionsApi = new Extensions_v1beta1Api(configuration.MasterUrl);
            this.LogsApi = new LogsApi(configuration.MasterUrl);
            this.NetworkingApi = new Networking_v1Api(configuration.MasterUrl);
            this.PolicyApi = new Policy_v1beta1Api(configuration.MasterUrl);
            this.RoleBasedControlAuthorizationApi = new RbacAuthorization_v1beta1Api(configuration.MasterUrl);
            this.StorageApi = new Storage_v1Api(configuration.MasterUrl);
            this.VersionApi = new VersionApi(configuration.MasterUrl);
        }
    }
}