using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1AzureDiskVolumeSource {
    /// <summary>
    /// Host Caching mode: None, Read Only, Read Write.
    /// </summary>
    /// <value>Host Caching mode: None, Read Only, Read Write.</value>
    [DataMember(Name="cachingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cachingMode")]
    public string CachingMode { get; set; }

    /// <summary>
    /// The Name of the data disk in the blob storage
    /// </summary>
    /// <value>The Name of the data disk in the blob storage</value>
    [DataMember(Name="diskName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diskName")]
    public string DiskName { get; set; }

    /// <summary>
    /// The URI the data disk in the blob storage
    /// </summary>
    /// <value>The URI the data disk in the blob storage</value>
    [DataMember(Name="diskURI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diskURI")]
    public string DiskURI { get; set; }

    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.
    /// </summary>
    /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// Expected values Shared: mulitple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared
    /// </summary>
    /// <value>Expected values Shared: mulitple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
    /// </summary>
    /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1AzureDiskVolumeSource {\n");
      sb.Append("  CachingMode: ").Append(CachingMode).Append("\n");
      sb.Append("  DiskName: ").Append(DiskName).Append("\n");
      sb.Append("  DiskURI: ").Append(DiskURI).Append("\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
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
