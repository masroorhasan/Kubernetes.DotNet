using System;
using Kubernetes.DotNet.Api;

namespace Kubernetes.DotNet
{
    /// <summary>
    /// Represents the top level client which wraps all Kubernetes API endpoints.
    /// </summary>
    public interface IKubernetesClient
    {
        /// <summary>
        /// The <see cref="KubernetesClientConfiguration"/>.
        /// </summary>
        KubernetesClientConfiguration ClientConfiguration { get; }

        /// <summary>
        /// The admissions control API endpoint.
        /// </summary>
        IAdmissionregistrationApi AdmissionregistrationApi { get; }

        /// <summary>
        /// The registration API endpoint.
        /// </summary>
        IApiregistration_v1beta1Api ApiRegistrationApi { get; }

        /// <summary>
        /// The Apps API endpoint.
        /// </summary>
        IApps_v1beta1Api AppsApi { get; }

        /// <summary>
        /// The authentication API endpoint.
        /// </summary>
        IAuthentication_v1Api AuthenticationApi { get; }

        /// <summary>
        /// The authorization API endpoint.
        /// </summary>
        IAuthorization_v1Api AuthorizationApi { get; }

        /// <summary>
        /// The autoscaling API endpoint.
        /// </summary>
        IAutoscaling_v1Api AutoscalingApi { get; }

        /// <summary>
        /// The batch API endpoint.
        /// </summary>
        IBatch_v1Api BatchApi { get; }

        /// <summary>
        /// The certificates API endpoint.
        /// </summary>
        ICertificates_v1beta1Api CertificatesApi { get; }

        /// <summary>
        /// The core API endpoint.
        /// </summary>
        ICore_v1Api CoreApi { get; }

        /// <summary>
        /// The extensions API endpoint.
        /// </summary>
        IExtensions_v1beta1Api ExtensionsApi { get; }

        /// <summary>
        /// The logs API endpoint.
        /// </summary>
        ILogsApi LogsApi { get; }

        /// <summary>
        /// The networking API endpoint.
        /// </summary>
        INetworking_v1Api NetworkingApi { get; }

        /// <summary>
        /// The policy API endpoint.
        /// </summary>
        IPolicy_v1beta1Api PolicyApi { get; }

        /// <summary>
        /// The role based control authorization API endpoint.
        /// </summary>
        IRbacAuthorization_v1beta1Api RbacAuthorizationApi { get; }
        
        /// <summary>
        /// The settings API endpoint.
        /// </summary>
        ISettingsApi SettingsApi { get; }

        /// <summary>
        /// The storage API endpoint.
        /// </summary>
        IStorage_v1Api StorageApi { get; }

        /// <summary>
        /// The version API endpoint.
        /// </summary>
        IVersionApi VersionApi { get; }

        // TODO: Build streaming api for logs and metrics
    }
}