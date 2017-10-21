using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents an ISCSI disk. ISCSI volumes can only be mounted as read/write once. ISCSI volumes support ownership management and SELinux relabeling.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ISCSIVolumeSource {
    /// <summary>
    /// whether support iSCSI Discovery CHAP authentication
    /// </summary>
    /// <value>whether support iSCSI Discovery CHAP authentication</value>
    [DataMember(Name="chapAuthDiscovery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chapAuthDiscovery")]
    public bool? ChapAuthDiscovery { get; set; }

    /// <summary>
    /// whether support iSCSI Session CHAP authentication
    /// </summary>
    /// <value>whether support iSCSI Session CHAP authentication</value>
    [DataMember(Name="chapAuthSession", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chapAuthSession")]
    public bool? ChapAuthSession { get; set; }

    /// <summary>
    /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi
    /// </summary>
    /// <value>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi</value>
    [DataMember(Name="fsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsType")]
    public string FsType { get; set; }

    /// <summary>
    /// Target iSCSI Qualified Name.
    /// </summary>
    /// <value>Target iSCSI Qualified Name.</value>
    [DataMember(Name="iqn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iqn")]
    public string Iqn { get; set; }

    /// <summary>
    /// Optional: Defaults to 'default' (tcp). iSCSI interface name that uses an iSCSI transport.
    /// </summary>
    /// <value>Optional: Defaults to 'default' (tcp). iSCSI interface name that uses an iSCSI transport.</value>
    [DataMember(Name="iscsiInterface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iscsiInterface")]
    public string IscsiInterface { get; set; }

    /// <summary>
    /// iSCSI target lun number.
    /// </summary>
    /// <value>iSCSI target lun number.</value>
    [DataMember(Name="lun", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lun")]
    public int? Lun { get; set; }

    /// <summary>
    /// iSCSI target portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
    /// </summary>
    /// <value>iSCSI target portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</value>
    [DataMember(Name="portals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "portals")]
    public List<string> Portals { get; set; }

    /// <summary>
    /// ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.
    /// </summary>
    /// <value>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// CHAP secret for iSCSI target and initiator authentication
    /// </summary>
    /// <value>CHAP secret for iSCSI target and initiator authentication</value>
    [DataMember(Name="secretRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secretRef")]
    public IoK8sKubernetesPkgApiV1LocalObjectReference SecretRef { get; set; }

    /// <summary>
    /// iSCSI target portal. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
    /// </summary>
    /// <value>iSCSI target portal. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</value>
    [DataMember(Name="targetPortal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetPortal")]
    public string TargetPortal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ISCSIVolumeSource {\n");
      sb.Append("  ChapAuthDiscovery: ").Append(ChapAuthDiscovery).Append("\n");
      sb.Append("  ChapAuthSession: ").Append(ChapAuthSession).Append("\n");
      sb.Append("  FsType: ").Append(FsType).Append("\n");
      sb.Append("  Iqn: ").Append(Iqn).Append("\n");
      sb.Append("  IscsiInterface: ").Append(IscsiInterface).Append("\n");
      sb.Append("  Lun: ").Append(Lun).Append("\n");
      sb.Append("  Portals: ").Append(Portals).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
      sb.Append("  TargetPortal: ").Append(TargetPortal).Append("\n");
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
