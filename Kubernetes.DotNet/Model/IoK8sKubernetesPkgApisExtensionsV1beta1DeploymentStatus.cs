using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// DeploymentStatus is the most recently observed status of the Deployment.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentStatus {
    /// <summary>
    /// Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.
    /// </summary>
    /// <value>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</value>
    [DataMember(Name="availableReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableReplicas")]
    public int? AvailableReplicas { get; set; }

    /// <summary>
    /// Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.
    /// </summary>
    /// <value>Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</value>
    [DataMember(Name="collisionCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collisionCount")]
    public long? CollisionCount { get; set; }

    /// <summary>
    /// Represents the latest available observations of a deployment's current state.
    /// </summary>
    /// <value>Represents the latest available observations of a deployment's current state.</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentCondition> Conditions { get; set; }

    /// <summary>
    /// The generation observed by the deployment controller.
    /// </summary>
    /// <value>The generation observed by the deployment controller.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Total number of ready pods targeted by this deployment.
    /// </summary>
    /// <value>Total number of ready pods targeted by this deployment.</value>
    [DataMember(Name="readyReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readyReplicas")]
    public int? ReadyReplicas { get; set; }

    /// <summary>
    /// Total number of non-terminated pods targeted by this deployment (their labels match the selector).
    /// </summary>
    /// <value>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replicas")]
    public int? Replicas { get; set; }

    /// <summary>
    /// Total number of unavailable pods targeted by this deployment.
    /// </summary>
    /// <value>Total number of unavailable pods targeted by this deployment.</value>
    [DataMember(Name="unavailableReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unavailableReplicas")]
    public int? UnavailableReplicas { get; set; }

    /// <summary>
    /// Total number of non-terminated pods targeted by this deployment that have the desired template spec.
    /// </summary>
    /// <value>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</value>
    [DataMember(Name="updatedReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedReplicas")]
    public int? UpdatedReplicas { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentStatus {\n");
      sb.Append("  AvailableReplicas: ").Append(AvailableReplicas).Append("\n");
      sb.Append("  CollisionCount: ").Append(CollisionCount).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
      sb.Append("  ReadyReplicas: ").Append(ReadyReplicas).Append("\n");
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      sb.Append("  UnavailableReplicas: ").Append(UnavailableReplicas).Append("\n");
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
