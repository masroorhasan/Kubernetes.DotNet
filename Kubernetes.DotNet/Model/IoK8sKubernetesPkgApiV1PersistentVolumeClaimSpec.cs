using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PersistentVolumeClaimSpec describes the common attributes of storage devices and allows a Source for provider-specific attributes
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PersistentVolumeClaimSpec {
    /// <summary>
    /// AccessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
    /// </summary>
    /// <value>AccessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</value>
    [DataMember(Name="accessModes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessModes")]
    public List<string> AccessModes { get; set; }

    /// <summary>
    /// Resources represents the minimum resources the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
    /// </summary>
    /// <value>Resources represents the minimum resources the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</value>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public IoK8sKubernetesPkgApiV1ResourceRequirements Resources { get; set; }

    /// <summary>
    /// A label query over volumes to consider for binding.
    /// </summary>
    /// <value>A label query over volumes to consider for binding.</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector Selector { get; set; }

    /// <summary>
    /// Name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1
    /// </summary>
    /// <value>Name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1</value>
    [DataMember(Name="storageClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storageClassName")]
    public string StorageClassName { get; set; }

    /// <summary>
    /// VolumeName is the binding reference to the PersistentVolume backing this claim.
    /// </summary>
    /// <value>VolumeName is the binding reference to the PersistentVolume backing this claim.</value>
    [DataMember(Name="volumeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumeName")]
    public string VolumeName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PersistentVolumeClaimSpec {\n");
      sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  StorageClassName: ").Append(StorageClassName).Append("\n");
      sb.Append("  VolumeName: ").Append(VolumeName).Append("\n");
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
