using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PersistentVolumeClaimStatus is the current status of a persistent volume claim.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PersistentVolumeClaimStatus {
    /// <summary>
    /// AccessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
    /// </summary>
    /// <value>AccessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</value>
    [DataMember(Name="accessModes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessModes")]
    public List<string> AccessModes { get; set; }

    /// <summary>
    /// Represents the actual resources of the underlying volume.
    /// </summary>
    /// <value>Represents the actual resources of the underlying volume.</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capacity")]
    public Dictionary<string, IoK8sApimachineryPkgApiResourceQuantity> Capacity { get; set; }

    /// <summary>
    /// Phase represents the current phase of PersistentVolumeClaim.
    /// </summary>
    /// <value>Phase represents the current phase of PersistentVolumeClaim.</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phase")]
    public string Phase { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PersistentVolumeClaimStatus {\n");
      sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      sb.Append("  Phase: ").Append(Phase).Append("\n");
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
