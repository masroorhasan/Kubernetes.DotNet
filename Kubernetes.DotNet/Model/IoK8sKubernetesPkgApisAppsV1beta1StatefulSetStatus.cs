using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// StatefulSetStatus represents the current state of a StatefulSet.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAppsV1beta1StatefulSetStatus {
    /// <summary>
    /// currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision.
    /// </summary>
    /// <value>currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision.</value>
    [DataMember(Name="currentReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentReplicas")]
    public int? CurrentReplicas { get; set; }

    /// <summary>
    /// currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas).
    /// </summary>
    /// <value>currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas).</value>
    [DataMember(Name="currentRevision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentRevision")]
    public string CurrentRevision { get; set; }

    /// <summary>
    /// observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server.
    /// </summary>
    /// <value>observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// readyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition.
    /// </summary>
    /// <value>readyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition.</value>
    [DataMember(Name="readyReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readyReplicas")]
    public int? ReadyReplicas { get; set; }

    /// <summary>
    /// replicas is the number of Pods created by the StatefulSet controller.
    /// </summary>
    /// <value>replicas is the number of Pods created by the StatefulSet controller.</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replicas")]
    public int? Replicas { get; set; }

    /// <summary>
    /// updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas)
    /// </summary>
    /// <value>updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas)</value>
    [DataMember(Name="updateRevision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateRevision")]
    public string UpdateRevision { get; set; }

    /// <summary>
    /// updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision.
    /// </summary>
    /// <value>updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision.</value>
    [DataMember(Name="updatedReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedReplicas")]
    public int? UpdatedReplicas { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAppsV1beta1StatefulSetStatus {\n");
      sb.Append("  CurrentReplicas: ").Append(CurrentReplicas).Append("\n");
      sb.Append("  CurrentRevision: ").Append(CurrentRevision).Append("\n");
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
      sb.Append("  ReadyReplicas: ").Append(ReadyReplicas).Append("\n");
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      sb.Append("  UpdateRevision: ").Append(UpdateRevision).Append("\n");
      sb.Append("  UpdatedReplicas: ").Append(UpdatedReplicas).Append("\n");
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
