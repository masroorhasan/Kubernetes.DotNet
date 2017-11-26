/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Kubernetes.DotNet.Client.SwaggerDateConverter;

namespace Kubernetes.DotNet.Model
{
    /// <summary>
    /// PodSpec is a description of a pod.
    /// </summary>
    [DataContract]
    public partial class V1PodSpec :  IEquatable<V1PodSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PodSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1PodSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PodSpec" /> class.
        /// </summary>
        /// <param name="ActiveDeadlineSeconds">Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer..</param>
        /// <param name="Affinity">If specified, the pod&#39;s scheduling constraints.</param>
        /// <param name="AutomountServiceAccountToken">AutomountServiceAccountToken indicates whether a service account token should be automatically mounted..</param>
        /// <param name="Containers">List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated. (required).</param>
        /// <param name="DnsPolicy">Set DNS policy for containers within the pod. One of &#39;ClusterFirstWithHostNet&#39;, &#39;ClusterFirst&#39; or &#39;Default&#39;. Defaults to \&quot;ClusterFirst\&quot;. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to &#39;ClusterFirstWithHostNet&#39;..</param>
        /// <param name="HostAliases">HostAliases is an optional list of hosts and IPs that will be injected into the pod&#39;s hosts file if specified. This is only valid for non-hostNetwork pods..</param>
        /// <param name="HostIPC">Use the host&#39;s ipc namespace. Optional: Default to false..</param>
        /// <param name="HostNetwork">Host networking requested for this pod. Use the host&#39;s network namespace. If this option is set, the ports that will be used must be specified. Default to false..</param>
        /// <param name="HostPID">Use the host&#39;s pid namespace. Optional: Default to false..</param>
        /// <param name="Hostname">Specifies the hostname of the Pod If not specified, the pod&#39;s hostname will be set to a system-defined value..</param>
        /// <param name="ImagePullSecrets">ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod.</param>
        /// <param name="InitContainers">List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, or Liveness probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/.</param>
        /// <param name="NodeName">NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements..</param>
        /// <param name="NodeSelector">NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node&#39;s labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/.</param>
        /// <param name="RestartPolicy">Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy.</param>
        /// <param name="SchedulerName">If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler..</param>
        /// <param name="SecurityContext">SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field..</param>
        /// <param name="ServiceAccount">DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead..</param>
        /// <param name="ServiceAccountName">ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/.</param>
        /// <param name="Subdomain">If specified, the fully qualified Pod hostname will be \&quot;&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;\&quot;. If not specified, the pod will not have a domainname at all..</param>
        /// <param name="TerminationGracePeriodSeconds">Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds..</param>
        /// <param name="Tolerations">If specified, the pod&#39;s tolerations..</param>
        /// <param name="Volumes">List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes.</param>
        public V1PodSpec(long? ActiveDeadlineSeconds = default(long?), V1Affinity Affinity = default(V1Affinity), bool? AutomountServiceAccountToken = default(bool?), List<V1Container> Containers = default(List<V1Container>), string DnsPolicy = default(string), List<V1HostAlias> HostAliases = default(List<V1HostAlias>), bool? HostIPC = default(bool?), bool? HostNetwork = default(bool?), bool? HostPID = default(bool?), string Hostname = default(string), List<V1LocalObjectReference> ImagePullSecrets = default(List<V1LocalObjectReference>), List<V1Container> InitContainers = default(List<V1Container>), string NodeName = default(string), Dictionary<string, string> NodeSelector = default(Dictionary<string, string>), string RestartPolicy = default(string), string SchedulerName = default(string), V1PodSecurityContext SecurityContext = default(V1PodSecurityContext), string ServiceAccount = default(string), string ServiceAccountName = default(string), string Subdomain = default(string), long? TerminationGracePeriodSeconds = default(long?), List<V1Toleration> Tolerations = default(List<V1Toleration>), List<V1Volume> Volumes = default(List<V1Volume>))
        {
            // to ensure "Containers" is required (not null)
            if (Containers == null)
            {
                throw new InvalidDataException("Containers is a required property for V1PodSpec and cannot be null");
            }
            else
            {
                this.Containers = Containers;
            }
            this.ActiveDeadlineSeconds = ActiveDeadlineSeconds;
            this.Affinity = Affinity;
            this.AutomountServiceAccountToken = AutomountServiceAccountToken;
            this.DnsPolicy = DnsPolicy;
            this.HostAliases = HostAliases;
            this.HostIPC = HostIPC;
            this.HostNetwork = HostNetwork;
            this.HostPID = HostPID;
            this.Hostname = Hostname;
            this.ImagePullSecrets = ImagePullSecrets;
            this.InitContainers = InitContainers;
            this.NodeName = NodeName;
            this.NodeSelector = NodeSelector;
            this.RestartPolicy = RestartPolicy;
            this.SchedulerName = SchedulerName;
            this.SecurityContext = SecurityContext;
            this.ServiceAccount = ServiceAccount;
            this.ServiceAccountName = ServiceAccountName;
            this.Subdomain = Subdomain;
            this.TerminationGracePeriodSeconds = TerminationGracePeriodSeconds;
            this.Tolerations = Tolerations;
            this.Volumes = Volumes;
        }
        
        /// <summary>
        /// Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.
        /// </summary>
        /// <value>Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.</value>
        [DataMember(Name="activeDeadlineSeconds", EmitDefaultValue=false)]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// If specified, the pod&#39;s scheduling constraints
        /// </summary>
        /// <value>If specified, the pod&#39;s scheduling constraints</value>
        [DataMember(Name="affinity", EmitDefaultValue=false)]
        public V1Affinity Affinity { get; set; }

        /// <summary>
        /// AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.
        /// </summary>
        /// <value>AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.</value>
        [DataMember(Name="automountServiceAccountToken", EmitDefaultValue=false)]
        public bool? AutomountServiceAccountToken { get; set; }

        /// <summary>
        /// List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.
        /// </summary>
        /// <value>List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.</value>
        [DataMember(Name="containers", EmitDefaultValue=false)]
        public List<V1Container> Containers { get; set; }

        /// <summary>
        /// Set DNS policy for containers within the pod. One of &#39;ClusterFirstWithHostNet&#39;, &#39;ClusterFirst&#39; or &#39;Default&#39;. Defaults to \&quot;ClusterFirst\&quot;. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to &#39;ClusterFirstWithHostNet&#39;.
        /// </summary>
        /// <value>Set DNS policy for containers within the pod. One of &#39;ClusterFirstWithHostNet&#39;, &#39;ClusterFirst&#39; or &#39;Default&#39;. Defaults to \&quot;ClusterFirst\&quot;. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to &#39;ClusterFirstWithHostNet&#39;.</value>
        [DataMember(Name="dnsPolicy", EmitDefaultValue=false)]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// HostAliases is an optional list of hosts and IPs that will be injected into the pod&#39;s hosts file if specified. This is only valid for non-hostNetwork pods.
        /// </summary>
        /// <value>HostAliases is an optional list of hosts and IPs that will be injected into the pod&#39;s hosts file if specified. This is only valid for non-hostNetwork pods.</value>
        [DataMember(Name="hostAliases", EmitDefaultValue=false)]
        public List<V1HostAlias> HostAliases { get; set; }

        /// <summary>
        /// Use the host&#39;s ipc namespace. Optional: Default to false.
        /// </summary>
        /// <value>Use the host&#39;s ipc namespace. Optional: Default to false.</value>
        [DataMember(Name="hostIPC", EmitDefaultValue=false)]
        public bool? HostIPC { get; set; }

        /// <summary>
        /// Host networking requested for this pod. Use the host&#39;s network namespace. If this option is set, the ports that will be used must be specified. Default to false.
        /// </summary>
        /// <value>Host networking requested for this pod. Use the host&#39;s network namespace. If this option is set, the ports that will be used must be specified. Default to false.</value>
        [DataMember(Name="hostNetwork", EmitDefaultValue=false)]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// Use the host&#39;s pid namespace. Optional: Default to false.
        /// </summary>
        /// <value>Use the host&#39;s pid namespace. Optional: Default to false.</value>
        [DataMember(Name="hostPID", EmitDefaultValue=false)]
        public bool? HostPID { get; set; }

        /// <summary>
        /// Specifies the hostname of the Pod If not specified, the pod&#39;s hostname will be set to a system-defined value.
        /// </summary>
        /// <value>Specifies the hostname of the Pod If not specified, the pod&#39;s hostname will be set to a system-defined value.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        /// <value>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</value>
        [DataMember(Name="imagePullSecrets", EmitDefaultValue=false)]
        public List<V1LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>
        /// List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, or Liveness probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
        /// </summary>
        /// <value>List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, or Liveness probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/</value>
        [DataMember(Name="initContainers", EmitDefaultValue=false)]
        public List<V1Container> InitContainers { get; set; }

        /// <summary>
        /// NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.
        /// </summary>
        /// <value>NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.</value>
        [DataMember(Name="nodeName", EmitDefaultValue=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node&#39;s labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        /// <value>NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node&#39;s labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</value>
        [DataMember(Name="nodeSelector", EmitDefaultValue=false)]
        public Dictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
        /// </summary>
        /// <value>Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy</value>
        [DataMember(Name="restartPolicy", EmitDefaultValue=false)]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.
        /// </summary>
        /// <value>If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.</value>
        [DataMember(Name="schedulerName", EmitDefaultValue=false)]
        public string SchedulerName { get; set; }

        /// <summary>
        /// SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.
        /// </summary>
        /// <value>SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.</value>
        [DataMember(Name="securityContext", EmitDefaultValue=false)]
        public V1PodSecurityContext SecurityContext { get; set; }

        /// <summary>
        /// DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.
        /// </summary>
        /// <value>DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.</value>
        [DataMember(Name="serviceAccount", EmitDefaultValue=false)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
        /// </summary>
        /// <value>ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</value>
        [DataMember(Name="serviceAccountName", EmitDefaultValue=false)]
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// If specified, the fully qualified Pod hostname will be \&quot;&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;\&quot;. If not specified, the pod will not have a domainname at all.
        /// </summary>
        /// <value>If specified, the fully qualified Pod hostname will be \&quot;&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;\&quot;. If not specified, the pod will not have a domainname at all.</value>
        [DataMember(Name="subdomain", EmitDefaultValue=false)]
        public string Subdomain { get; set; }

        /// <summary>
        /// Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.
        /// </summary>
        /// <value>Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.</value>
        [DataMember(Name="terminationGracePeriodSeconds", EmitDefaultValue=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// If specified, the pod&#39;s tolerations.
        /// </summary>
        /// <value>If specified, the pod&#39;s tolerations.</value>
        [DataMember(Name="tolerations", EmitDefaultValue=false)]
        public List<V1Toleration> Tolerations { get; set; }

        /// <summary>
        /// List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes
        /// </summary>
        /// <value>List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes</value>
        [DataMember(Name="volumes", EmitDefaultValue=false)]
        public List<V1Volume> Volumes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PodSpec {\n");
            sb.Append("  ActiveDeadlineSeconds: ").Append(ActiveDeadlineSeconds).Append("\n");
            sb.Append("  Affinity: ").Append(Affinity).Append("\n");
            sb.Append("  AutomountServiceAccountToken: ").Append(AutomountServiceAccountToken).Append("\n");
            sb.Append("  Containers: ").Append(Containers).Append("\n");
            sb.Append("  DnsPolicy: ").Append(DnsPolicy).Append("\n");
            sb.Append("  HostAliases: ").Append(HostAliases).Append("\n");
            sb.Append("  HostIPC: ").Append(HostIPC).Append("\n");
            sb.Append("  HostNetwork: ").Append(HostNetwork).Append("\n");
            sb.Append("  HostPID: ").Append(HostPID).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  ImagePullSecrets: ").Append(ImagePullSecrets).Append("\n");
            sb.Append("  InitContainers: ").Append(InitContainers).Append("\n");
            sb.Append("  NodeName: ").Append(NodeName).Append("\n");
            sb.Append("  NodeSelector: ").Append(NodeSelector).Append("\n");
            sb.Append("  RestartPolicy: ").Append(RestartPolicy).Append("\n");
            sb.Append("  SchedulerName: ").Append(SchedulerName).Append("\n");
            sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
            sb.Append("  ServiceAccount: ").Append(ServiceAccount).Append("\n");
            sb.Append("  ServiceAccountName: ").Append(ServiceAccountName).Append("\n");
            sb.Append("  Subdomain: ").Append(Subdomain).Append("\n");
            sb.Append("  TerminationGracePeriodSeconds: ").Append(TerminationGracePeriodSeconds).Append("\n");
            sb.Append("  Tolerations: ").Append(Tolerations).Append("\n");
            sb.Append("  Volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1PodSpec);
        }

        /// <summary>
        /// Returns true if V1PodSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PodSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PodSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActiveDeadlineSeconds == other.ActiveDeadlineSeconds ||
                    this.ActiveDeadlineSeconds != null &&
                    this.ActiveDeadlineSeconds.Equals(other.ActiveDeadlineSeconds)
                ) && 
                (
                    this.Affinity == other.Affinity ||
                    this.Affinity != null &&
                    this.Affinity.Equals(other.Affinity)
                ) && 
                (
                    this.AutomountServiceAccountToken == other.AutomountServiceAccountToken ||
                    this.AutomountServiceAccountToken != null &&
                    this.AutomountServiceAccountToken.Equals(other.AutomountServiceAccountToken)
                ) && 
                (
                    this.Containers == other.Containers ||
                    this.Containers != null &&
                    this.Containers.SequenceEqual(other.Containers)
                ) && 
                (
                    this.DnsPolicy == other.DnsPolicy ||
                    this.DnsPolicy != null &&
                    this.DnsPolicy.Equals(other.DnsPolicy)
                ) && 
                (
                    this.HostAliases == other.HostAliases ||
                    this.HostAliases != null &&
                    this.HostAliases.SequenceEqual(other.HostAliases)
                ) && 
                (
                    this.HostIPC == other.HostIPC ||
                    this.HostIPC != null &&
                    this.HostIPC.Equals(other.HostIPC)
                ) && 
                (
                    this.HostNetwork == other.HostNetwork ||
                    this.HostNetwork != null &&
                    this.HostNetwork.Equals(other.HostNetwork)
                ) && 
                (
                    this.HostPID == other.HostPID ||
                    this.HostPID != null &&
                    this.HostPID.Equals(other.HostPID)
                ) && 
                (
                    this.Hostname == other.Hostname ||
                    this.Hostname != null &&
                    this.Hostname.Equals(other.Hostname)
                ) && 
                (
                    this.ImagePullSecrets == other.ImagePullSecrets ||
                    this.ImagePullSecrets != null &&
                    this.ImagePullSecrets.SequenceEqual(other.ImagePullSecrets)
                ) && 
                (
                    this.InitContainers == other.InitContainers ||
                    this.InitContainers != null &&
                    this.InitContainers.SequenceEqual(other.InitContainers)
                ) && 
                (
                    this.NodeName == other.NodeName ||
                    this.NodeName != null &&
                    this.NodeName.Equals(other.NodeName)
                ) && 
                (
                    this.NodeSelector == other.NodeSelector ||
                    this.NodeSelector != null &&
                    this.NodeSelector.SequenceEqual(other.NodeSelector)
                ) && 
                (
                    this.RestartPolicy == other.RestartPolicy ||
                    this.RestartPolicy != null &&
                    this.RestartPolicy.Equals(other.RestartPolicy)
                ) && 
                (
                    this.SchedulerName == other.SchedulerName ||
                    this.SchedulerName != null &&
                    this.SchedulerName.Equals(other.SchedulerName)
                ) && 
                (
                    this.SecurityContext == other.SecurityContext ||
                    this.SecurityContext != null &&
                    this.SecurityContext.Equals(other.SecurityContext)
                ) && 
                (
                    this.ServiceAccount == other.ServiceAccount ||
                    this.ServiceAccount != null &&
                    this.ServiceAccount.Equals(other.ServiceAccount)
                ) && 
                (
                    this.ServiceAccountName == other.ServiceAccountName ||
                    this.ServiceAccountName != null &&
                    this.ServiceAccountName.Equals(other.ServiceAccountName)
                ) && 
                (
                    this.Subdomain == other.Subdomain ||
                    this.Subdomain != null &&
                    this.Subdomain.Equals(other.Subdomain)
                ) && 
                (
                    this.TerminationGracePeriodSeconds == other.TerminationGracePeriodSeconds ||
                    this.TerminationGracePeriodSeconds != null &&
                    this.TerminationGracePeriodSeconds.Equals(other.TerminationGracePeriodSeconds)
                ) && 
                (
                    this.Tolerations == other.Tolerations ||
                    this.Tolerations != null &&
                    this.Tolerations.SequenceEqual(other.Tolerations)
                ) && 
                (
                    this.Volumes == other.Volumes ||
                    this.Volumes != null &&
                    this.Volumes.SequenceEqual(other.Volumes)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ActiveDeadlineSeconds != null)
                    hash = hash * 59 + this.ActiveDeadlineSeconds.GetHashCode();
                if (this.Affinity != null)
                    hash = hash * 59 + this.Affinity.GetHashCode();
                if (this.AutomountServiceAccountToken != null)
                    hash = hash * 59 + this.AutomountServiceAccountToken.GetHashCode();
                if (this.Containers != null)
                    hash = hash * 59 + this.Containers.GetHashCode();
                if (this.DnsPolicy != null)
                    hash = hash * 59 + this.DnsPolicy.GetHashCode();
                if (this.HostAliases != null)
                    hash = hash * 59 + this.HostAliases.GetHashCode();
                if (this.HostIPC != null)
                    hash = hash * 59 + this.HostIPC.GetHashCode();
                if (this.HostNetwork != null)
                    hash = hash * 59 + this.HostNetwork.GetHashCode();
                if (this.HostPID != null)
                    hash = hash * 59 + this.HostPID.GetHashCode();
                if (this.Hostname != null)
                    hash = hash * 59 + this.Hostname.GetHashCode();
                if (this.ImagePullSecrets != null)
                    hash = hash * 59 + this.ImagePullSecrets.GetHashCode();
                if (this.InitContainers != null)
                    hash = hash * 59 + this.InitContainers.GetHashCode();
                if (this.NodeName != null)
                    hash = hash * 59 + this.NodeName.GetHashCode();
                if (this.NodeSelector != null)
                    hash = hash * 59 + this.NodeSelector.GetHashCode();
                if (this.RestartPolicy != null)
                    hash = hash * 59 + this.RestartPolicy.GetHashCode();
                if (this.SchedulerName != null)
                    hash = hash * 59 + this.SchedulerName.GetHashCode();
                if (this.SecurityContext != null)
                    hash = hash * 59 + this.SecurityContext.GetHashCode();
                if (this.ServiceAccount != null)
                    hash = hash * 59 + this.ServiceAccount.GetHashCode();
                if (this.ServiceAccountName != null)
                    hash = hash * 59 + this.ServiceAccountName.GetHashCode();
                if (this.Subdomain != null)
                    hash = hash * 59 + this.Subdomain.GetHashCode();
                if (this.TerminationGracePeriodSeconds != null)
                    hash = hash * 59 + this.TerminationGracePeriodSeconds.GetHashCode();
                if (this.Tolerations != null)
                    hash = hash * 59 + this.Tolerations.GetHashCode();
                if (this.Volumes != null)
                    hash = hash * 59 + this.Volumes.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}