using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodDisruptionBudgetStatus represents information about the status of a PodDisruptionBudget. Status may trail the actual state of a system.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisPolicyV1beta1PodDisruptionBudgetStatus {
    /// <summary>
    /// current number of healthy pods
    /// </summary>
    /// <value>current number of healthy pods</value>
    [DataMember(Name="currentHealthy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentHealthy")]
    public int? CurrentHealthy { get; set; }

    /// <summary>
    /// minimum desired number of healthy pods
    /// </summary>
    /// <value>minimum desired number of healthy pods</value>
    [DataMember(Name="desiredHealthy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desiredHealthy")]
    public int? DesiredHealthy { get; set; }

    /// <summary>
    /// DisruptedPods contains information about pods whose eviction was processed by the API server eviction subresource handler but has not yet been observed by the PodDisruptionBudget controller. A pod will be in this map from the time when the API server processed the eviction request to the time when the pod is seen by PDB controller as having been marked for deletion (or after a timeout). The key in the map is the name of the pod and the value is the time when the API server processed the eviction request. If the deletion didn't occur and a pod is still there it will be removed from the list automatically by PodDisruptionBudget controller after some time. If everything goes smooth this map should be empty for the most of the time. Large number of entries in the map may indicate problems with pod deletions.
    /// </summary>
    /// <value>DisruptedPods contains information about pods whose eviction was processed by the API server eviction subresource handler but has not yet been observed by the PodDisruptionBudget controller. A pod will be in this map from the time when the API server processed the eviction request to the time when the pod is seen by PDB controller as having been marked for deletion (or after a timeout). The key in the map is the name of the pod and the value is the time when the API server processed the eviction request. If the deletion didn't occur and a pod is still there it will be removed from the list automatically by PodDisruptionBudget controller after some time. If everything goes smooth this map should be empty for the most of the time. Large number of entries in the map may indicate problems with pod deletions.</value>
    [DataMember(Name="disruptedPods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disruptedPods")]
    public Dictionary<string, IoK8sApimachineryPkgApisMetaV1Time> DisruptedPods { get; set; }

    /// <summary>
    /// Number of pod disruptions that are currently allowed.
    /// </summary>
    /// <value>Number of pod disruptions that are currently allowed.</value>
    [DataMember(Name="disruptionsAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disruptionsAllowed")]
    public int? DisruptionsAllowed { get; set; }

    /// <summary>
    /// total number of pods counted by this disruption budget
    /// </summary>
    /// <value>total number of pods counted by this disruption budget</value>
    [DataMember(Name="expectedPods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expectedPods")]
    public int? ExpectedPods { get; set; }

    /// <summary>
    /// Most recent generation observed when updating this PDB status. PodDisruptionsAllowed and other status informatio is valid only if observedGeneration equals to PDB's object generation.
    /// </summary>
    /// <value>Most recent generation observed when updating this PDB status. PodDisruptionsAllowed and other status informatio is valid only if observedGeneration equals to PDB's object generation.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "observedGeneration")]
    public long? ObservedGeneration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisPolicyV1beta1PodDisruptionBudgetStatus {\n");
      sb.Append("  CurrentHealthy: ").Append(CurrentHealthy).Append("\n");
      sb.Append("  DesiredHealthy: ").Append(DesiredHealthy).Append("\n");
      sb.Append("  DisruptedPods: ").Append(DisruptedPods).Append("\n");
      sb.Append("  DisruptionsAllowed: ").Append(DisruptionsAllowed).Append("\n");
      sb.Append("  ExpectedPods: ").Append(ExpectedPods).Append("\n");
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
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
