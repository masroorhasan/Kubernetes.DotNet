using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents a Photon Controller persistent disk resource.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PhotonPersistentDiskVolumeSource {
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.
    /// </summary>
    /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// ID that identifies Photon Controller persistent disk
    /// </summary>
    /// <value>ID that identifies Photon Controller persistent disk</value>
    [DataMember(Name="pdID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pdID")]
    public string PdID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PhotonPersistentDiskVolumeSource {\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  PdID: ").Append(PdID).Append("\n");
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
