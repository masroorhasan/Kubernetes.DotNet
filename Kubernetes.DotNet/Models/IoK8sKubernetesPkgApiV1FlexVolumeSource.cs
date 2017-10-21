using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. This is an alpha feature and may change in future.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1FlexVolumeSource {
    /// <summary>
    /// Driver is the name of the driver to use for this volume.
    /// </summary>
    /// <value>Driver is the name of the driver to use for this volume.</value>
    [DataMember(Name="driver", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "driver")]
    public string Driver { get; set; }

    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". The default filesystem depends on FlexVolume script.
    /// </summary>
    /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". The default filesystem depends on FlexVolume script.</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// Optional: Extra command options if any.
    /// </summary>
    /// <value>Optional: Extra command options if any.</value>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public Dictionary<string, string> Options { get; set; }

    /// <summary>
    /// Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
    /// </summary>
    /// <value>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// Optional: SecretRef is reference to the secret object containing sensitive information to pass to the plugin scripts. This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.
    /// </summary>
    /// <value>Optional: SecretRef is reference to the secret object containing sensitive information to pass to the plugin scripts. This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.</value>
    [DataMember(Name="secretRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secretRef")]
    public IoK8sKubernetesPkgApiV1LocalObjectReference SecretRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1FlexVolumeSource {\n");
      sb.Append("  Driver: ").Append(Driver).Append("\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
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
