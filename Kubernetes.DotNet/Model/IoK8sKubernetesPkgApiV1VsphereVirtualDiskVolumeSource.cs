using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents a vSphere volume resource.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1VsphereVirtualDiskVolumeSource {
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.
    /// </summary>
    /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.
    /// </summary>
    /// <value>Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.</value>
    [DataMember(Name="storagePolicyID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storagePolicyID")]
    public string StoragePolicyID { get; set; }

    /// <summary>
    /// Storage Policy Based Management (SPBM) profile name.
    /// </summary>
    /// <value>Storage Policy Based Management (SPBM) profile name.</value>
    [DataMember(Name="storagePolicyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storagePolicyName")]
    public string StoragePolicyName { get; set; }

    /// <summary>
    /// Path that identifies vSphere volume vmdk
    /// </summary>
    /// <value>Path that identifies vSphere volume vmdk</value>
    [DataMember(Name="volumePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumePath")]
    public string VolumePath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1VsphereVirtualDiskVolumeSource {\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  StoragePolicyID: ").Append(StoragePolicyID).Append("\n");
      sb.Append("  StoragePolicyName: ").Append(StoragePolicyName).Append("\n");
      sb.Append("  VolumePath: ").Append(VolumePath).Append("\n");
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
