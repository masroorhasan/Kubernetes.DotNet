using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodCondition contains details for the current condition of this pod.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PodCondition {
    /// <summary>
    /// Last time we probed the condition.
    /// </summary>
    /// <value>Last time we probed the condition.</value>
    [DataMember(Name="lastProbeTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastProbeTime")]
    public IoK8sApimachineryPkgApisMetaV1Time LastProbeTime { get; set; }

    /// <summary>
    /// Last time the condition transitioned from one status to another.
    /// </summary>
    /// <value>Last time the condition transitioned from one status to another.</value>
    [DataMember(Name="lastTransitionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransitionTime")]
    // public IoK8sApimachineryPkgApisMetaV1Time LastTransitionTime { get; set; }
    public DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// Human-readable message indicating details about last transition.
    /// </summary>
    /// <value>Human-readable message indicating details about last transition.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Unique, one-word, CamelCase reason for the condition's last transition.
    /// </summary>
    /// <value>Unique, one-word, CamelCase reason for the condition's last transition.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Status is the status of the condition. Can be True, False, Unknown. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
    /// </summary>
    /// <value>Status is the status of the condition. Can be True, False, Unknown. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Type is the type of the condition. Currently only Ready. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
    /// </summary>
    /// <value>Type is the type of the condition. Currently only Ready. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PodCondition {\n");
      sb.Append("  LastProbeTime: ").Append(LastProbeTime).Append("\n");
      sb.Append("  LastTransitionTime: ").Append(LastTransitionTime).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
