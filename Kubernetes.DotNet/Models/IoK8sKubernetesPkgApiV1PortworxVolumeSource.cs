using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PortworxVolumeSource represents a Portworx volume resource.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PortworxVolumeSource {
    /// <summary>
    /// FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\". Implicitly inferred to be \"ext4\" if unspecified.
    /// </summary>
    /// <value>FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\". Implicitly inferred to be \"ext4\" if unspecified.</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
    /// </summary>
    /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// VolumeID uniquely identifies a Portworx volume
    /// </summary>
    /// <value>VolumeID uniquely identifies a Portworx volume</value>
    [DataMember(Name="volumeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumeID")]
    public string VolumeID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PortworxVolumeSource {\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  VolumeID: ").Append(VolumeID).Append("\n");
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
