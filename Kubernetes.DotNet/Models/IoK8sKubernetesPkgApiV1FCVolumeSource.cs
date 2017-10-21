using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents a Fibre Channel volume. Fibre Channel volumes can only be mounted as read/write once. Fibre Channel volumes support ownership management and SELinux relabeling.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1FCVolumeSource {
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.
    /// </summary>
    /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// Required: FC target lun number
    /// </summary>
    /// <value>Required: FC target lun number</value>
    [DataMember(Name="lun", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lun")]
    public int? Lun { get; set; }

    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
    /// </summary>
    /// <value>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// Required: FC target worldwide names (WWNs)
    /// </summary>
    /// <value>Required: FC target worldwide names (WWNs)</value>
    [DataMember(Name="targetWWNs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetWWNs")]
    public List<string> TargetWWNs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1FCVolumeSource {\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  Lun: ").Append(Lun).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  TargetWWNs: ").Append(TargetWWNs).Append("\n");
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
