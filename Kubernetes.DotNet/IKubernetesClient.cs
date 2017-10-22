using System;
using Kubernetes.DotNet.Api;

namespace Kubernetes.DotNet
{
    /// <summary>
    /// The client interface to interact with K8s Remote APIs.
    /// </summary>
    public interface IKubernetesClient
    {
        KubernetesClientConfiguration Configuration { get; }

        # region Endpoints        
        // IAdmissionregistration_v1alpha1Api AdmissionregistrationApi { get; }
        IApiregistration_v1beta1Api ApiRegistrationApi { get; }
        IApps_v1beta1Api AppsApi { get; }
        IAuthentication_v1Api AuthenticationApi { get; }
        IAuthorization_v1Api AuthorizationApi { get; }
        IAutoscaling_v1Api AutoscalingApi { get; }
        IBatch_v1Api BatchApi { get; }
        ICertificates_v1beta1Api CertificatesApi { get; }
        ICore_v1Api CoreApi { get; }
        IExtensions_v1beta1Api ExtensionsApi { get; }
        ILogsApi LogsApi { get; }
        INetworking_v1Api NetworkingApi { get; }
        IPolicy_v1beta1Api PolicyApi { get; }
        IRbacAuthorization_v1beta1Api RoleBasedControlAuthorizationApi { get; }
        // ISettings_v1alpha1Api SettingsApi { get; }
        IStorage_v1Api StorageApi { get; }
        IVersionApi VersionApi { get; }
        // TODO: Build streaming api for logs and metrics
        #endregion Endpoints
    }
}