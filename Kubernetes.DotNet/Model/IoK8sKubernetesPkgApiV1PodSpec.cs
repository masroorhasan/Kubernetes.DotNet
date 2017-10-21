using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodSpec is a description of a pod.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PodSpec {
    /// <summary>
    /// Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.
    /// </summary>
    /// <value>Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.</value>
    [DataMember(Name="activeDeadlineSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary>
    /// If specified, the pod's scheduling constraints
    /// </summary>
    /// <value>If specified, the pod's scheduling constraints</value>
    [DataMember(Name="affinity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affinity")]
    public IoK8sKubernetesPkgApiV1Affinity Affinity { get; set; }

    /// <summary>
    /// AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.
    /// </summary>
    /// <value>AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.</value>
    [DataMember(Name="automountServiceAccountToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary>
    /// List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.
    /// </summary>
    /// <value>List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.</value>
    [DataMember(Name="containers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containers")]
    public List<IoK8sKubernetesPkgApiV1Container> Containers { get; set; }

    /// <summary>
    /// Set DNS policy for containers within the pod. One of 'ClusterFirstWithHostNet', 'ClusterFirst' or 'Default'. Defaults to \"ClusterFirst\". To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.
    /// </summary>
    /// <value>Set DNS policy for containers within the pod. One of 'ClusterFirstWithHostNet', 'ClusterFirst' or 'Default'. Defaults to \"ClusterFirst\". To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.</value>
    [DataMember(Name="dnsPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dnsPolicy")]
    public string DnsPolicy { get; set; }

    /// <summary>
    /// HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified. This is only valid for non-hostNetwork pods.
    /// </summary>
    /// <value>HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified. This is only valid for non-hostNetwork pods.</value>
    [DataMember(Name="hostAliases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostAliases")]
    public List<IoK8sKubernetesPkgApiV1HostAlias> HostAliases { get; set; }

    /// <summary>
    /// Use the host's ipc namespace. Optional: Default to false.
    /// </summary>
    /// <value>Use the host's ipc namespace. Optional: Default to false.</value>
    [DataMember(Name="hostIPC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostIPC")]
    public bool? HostIPC { get; set; }

    /// <summary>
    /// Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.
    /// </summary>
    /// <value>Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.</value>
    [DataMember(Name="hostNetwork", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary>
    /// Use the host's pid namespace. Optional: Default to false.
    /// </summary>
    /// <value>Use the host's pid namespace. Optional: Default to false.</value>
    [DataMember(Name="hostPID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostPID")]
    public bool? HostPID { get; set; }

    /// <summary>
    /// Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.
    /// </summary>
    /// <value>Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.</value>
    [DataMember(Name="hostname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostname")]
    public string Hostname { get; set; }

    /// <summary>
    /// ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
    /// </summary>
    /// <value>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</value>
    [DataMember(Name="imagePullSecrets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imagePullSecrets")]
    public List<IoK8sKubernetesPkgApiV1LocalObjectReference> ImagePullSecrets { get; set; }

    /// <summary>
    /// List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, or Liveness probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
    /// </summary>
    /// <value>List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, or Liveness probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/</value>
    [DataMember(Name="initContainers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initContainers")]
    public List<IoK8sKubernetesPkgApiV1Container> InitContainers { get; set; }

    /// <summary>
    /// NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.
    /// </summary>
    /// <value>NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.</value>
    [DataMember(Name="nodeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeName")]
    public string NodeName { get; set; }

    /// <summary>
    /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
    /// </summary>
    /// <value>NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</value>
    [DataMember(Name="nodeSelector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeSelector")]
    public Dictionary<string, string> NodeSelector { get; set; }

    /// <summary>
    /// Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
    /// </summary>
    /// <value>Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy</value>
    [DataMember(Name="restartPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restartPolicy")]
    public string RestartPolicy { get; set; }

    /// <summary>
    /// If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.
    /// </summary>
    /// <value>If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.</value>
    [DataMember(Name="schedulerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedulerName")]
    public string SchedulerName { get; set; }

    /// <summary>
    /// SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.
    /// </summary>
    /// <value>SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.</value>
    [DataMember(Name="securityContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityContext")]
    public IoK8sKubernetesPkgApiV1PodSecurityContext SecurityContext { get; set; }

    /// <summary>
    /// DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.
    /// </summary>
    /// <value>DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.</value>
    [DataMember(Name="serviceAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceAccount")]
    public string ServiceAccount { get; set; }

    /// <summary>
    /// ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
    /// </summary>
    /// <value>ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</value>
    [DataMember(Name="serviceAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceAccountName")]
    public string ServiceAccountName { get; set; }

    /// <summary>
    /// If specified, the fully qualified Pod hostname will be \"<hostname>.<subdomain>.<pod namespace>.svc.<cluster domain>\". If not specified, the pod will not have a domainname at all.
    /// </summary>
    /// <value>If specified, the fully qualified Pod hostname will be \"<hostname>.<subdomain>.<pod namespace>.svc.<cluster domain>\". If not specified, the pod will not have a domainname at all.</value>
    [DataMember(Name="subdomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subdomain")]
    public string Subdomain { get; set; }

    /// <summary>
    /// Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.
    /// </summary>
    /// <value>Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.</value>
    [DataMember(Name="terminationGracePeriodSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminationGracePeriodSeconds")]
    public long? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// If specified, the pod's tolerations.
    /// </summary>
    /// <value>If specified, the pod's tolerations.</value>
    [DataMember(Name="tolerations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tolerations")]
    public List<IoK8sKubernetesPkgApiV1Toleration> Tolerations { get; set; }

    /// <summary>
    /// List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes
    /// </summary>
    /// <value>List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes</value>
    [DataMember(Name="volumes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumes")]
    public List<IoK8sKubernetesPkgApiV1Volume> Volumes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PodSpec {\n");
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
