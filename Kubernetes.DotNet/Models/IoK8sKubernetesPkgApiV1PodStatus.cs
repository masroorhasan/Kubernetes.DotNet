using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodStatus represents information about the status of a pod. Status may trail the actual state of a system.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PodStatus {
    /// <summary>
    /// Current service state of pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
    /// </summary>
    /// <value>Current service state of pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<IoK8sKubernetesPkgApiV1PodCondition> Conditions { get; set; }

    /// <summary>
    /// The list has one entry per container in the manifest. Each entry is currently the output of `docker inspect`. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status
    /// </summary>
    /// <value>The list has one entry per container in the manifest. Each entry is currently the output of `docker inspect`. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</value>
    [DataMember(Name="containerStatuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerStatuses")]
    public List<IoK8sKubernetesPkgApiV1ContainerStatus> ContainerStatuses { get; set; }

    /// <summary>
    /// IP address of the host to which the pod is assigned. Empty if not yet scheduled.
    /// </summary>
    /// <value>IP address of the host to which the pod is assigned. Empty if not yet scheduled.</value>
    [DataMember(Name="hostIP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostIP")]
    public string HostIP { get; set; }

    /// <summary>
    /// The list has one entry per init container in the manifest. The most recent successful init container will have ready = true, the most recently started container will have startTime set. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status
    /// </summary>
    /// <value>The list has one entry per init container in the manifest. The most recent successful init container will have ready = true, the most recently started container will have startTime set. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</value>
    [DataMember(Name="initContainerStatuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initContainerStatuses")]
    public List<IoK8sKubernetesPkgApiV1ContainerStatus> InitContainerStatuses { get; set; }

    /// <summary>
    /// A human readable message indicating details about why the pod is in this condition.
    /// </summary>
    /// <value>A human readable message indicating details about why the pod is in this condition.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Current condition of the pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase
    /// </summary>
    /// <value>Current condition of the pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phase")]
    public string Phase { get; set; }

    /// <summary>
    /// IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated.
    /// </summary>
    /// <value>IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated.</value>
    [DataMember(Name="podIP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podIP")]
    public string PodIP { get; set; }

    /// <summary>
    /// The Quality of Service (QOS) classification assigned to the pod based on resource requirements See PodQOSClass type for available QOS classes More info: https://github.com/kubernetes/kubernetes/blob/master/docs/design/resource-qos.md
    /// </summary>
    /// <value>The Quality of Service (QOS) classification assigned to the pod based on resource requirements See PodQOSClass type for available QOS classes More info: https://github.com/kubernetes/kubernetes/blob/master/docs/design/resource-qos.md</value>
    [DataMember(Name="qosClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qosClass")]
    public string QosClass { get; set; }

    /// <summary>
    /// A brief CamelCase message indicating details about why the pod is in this state. e.g. 'OutOfDisk'
    /// </summary>
    /// <value>A brief CamelCase message indicating details about why the pod is in this state. e.g. 'OutOfDisk'</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// RFC 3339 date and time at which the object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod.
    /// </summary>
    /// <value>RFC 3339 date and time at which the object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod.</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    // public IoK8sApimachineryPkgApisMetaV1Time StartTime { get; set; }
    public DateTime StartTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PodStatus {\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  ContainerStatuses: ").Append(ContainerStatuses).Append("\n");
      sb.Append("  HostIP: ").Append(HostIP).Append("\n");
      sb.Append("  InitContainerStatuses: ").Append(InitContainerStatuses).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Phase: ").Append(Phase).Append("\n");
      sb.Append("  PodIP: ").Append(PodIP).Append("\n");
      sb.Append("  QosClass: ").Append(QosClass).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
