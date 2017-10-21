using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ScaleIOVolumeSource represents a persistent ScaleIO volume
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ScaleIOVolumeSource {
    /// <summary>
    /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.
    /// </summary>
    /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// The host address of the ScaleIO API Gateway.
    /// </summary>
    /// <value>The host address of the ScaleIO API Gateway.</value>
    [DataMember(Name="gateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gateway")]
    public string Gateway { get; set; }

    /// <summary>
    /// The name of the Protection Domain for the configured storage (defaults to \"default\").
    /// </summary>
    /// <value>The name of the Protection Domain for the configured storage (defaults to \"default\").</value>
    [DataMember(Name="protectionDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protectionDomain")]
    public string ProtectionDomain { get; set; }

    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
    /// </summary>
    /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.
    /// </summary>
    /// <value>SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.</value>
    [DataMember(Name="secretRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secretRef")]
    public IoK8sKubernetesPkgApiV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// Flag to enable/disable SSL communication with Gateway, default false
    /// </summary>
    /// <value>Flag to enable/disable SSL communication with Gateway, default false</value>
    [DataMember(Name="sslEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sslEnabled")]
    public bool? SslEnabled { get; set; }

    /// <summary>
    /// Indicates whether the storage for a volume should be thick or thin (defaults to \"thin\").
    /// </summary>
    /// <value>Indicates whether the storage for a volume should be thick or thin (defaults to \"thin\").</value>
    [DataMember(Name="storageMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storageMode")]
    public string StorageMode { get; set; }

    /// <summary>
    /// The Storage Pool associated with the protection domain (defaults to \"default\").
    /// </summary>
    /// <value>The Storage Pool associated with the protection domain (defaults to \"default\").</value>
    [DataMember(Name="storagePool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storagePool")]
    public string StoragePool { get; set; }

    /// <summary>
    /// The name of the storage system as configured in ScaleIO.
    /// </summary>
    /// <value>The name of the storage system as configured in ScaleIO.</value>
    [DataMember(Name="system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system")]
    public string System { get; set; }

    /// <summary>
    /// The name of a volume already created in the ScaleIO system that is associated with this volume source.
    /// </summary>
    /// <value>The name of a volume already created in the ScaleIO system that is associated with this volume source.</value>
    [DataMember(Name="volumeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumeName")]
    public string VolumeName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ScaleIOVolumeSource {\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  Gateway: ").Append(Gateway).Append("\n");
      sb.Append("  ProtectionDomain: ").Append(ProtectionDomain).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
      sb.Append("  SslEnabled: ").Append(SslEnabled).Append("\n");
      sb.Append("  StorageMode: ").Append(StorageMode).Append("\n");
      sb.Append("  StoragePool: ").Append(StoragePool).Append("\n");
      sb.Append("  System: ").Append(System).Append("\n");
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
