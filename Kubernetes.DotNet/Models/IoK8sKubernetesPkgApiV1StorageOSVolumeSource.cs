using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents a StorageOS persistent volume resource.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1StorageOSVolumeSource {
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.
    /// </summary>
    /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.</value>
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
    /// SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.
    /// </summary>
    /// <value>SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.</value>
    [DataMember(Name="secretRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secretRef")]
    public IoK8sKubernetesPkgApiV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.
    /// </summary>
    /// <value>VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.</value>
    [DataMember(Name="volumeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumeName")]
    public string VolumeName { get; set; }

    /// <summary>
    /// VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to \"default\" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.
    /// </summary>
    /// <value>VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to \"default\" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.</value>
    [DataMember(Name="volumeNamespace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumeNamespace")]
    public string VolumeNamespace { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1StorageOSVolumeSource {\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
      sb.Append("  VolumeName: ").Append(VolumeName).Append("\n");
      sb.Append("  VolumeNamespace: ").Append(VolumeNamespace).Append("\n");
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
