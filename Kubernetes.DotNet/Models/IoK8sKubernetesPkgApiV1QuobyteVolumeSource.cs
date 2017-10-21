using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte volumes do not support ownership management or SELinux relabeling.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1QuobyteVolumeSource {
    /// <summary>
    /// Group to map volume access to Default is no group
    /// </summary>
    /// <value>Group to map volume access to Default is no group</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.
    /// </summary>
    /// <value>ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes
    /// </summary>
    /// <value>Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes</value>
    [DataMember(Name="registry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registry")]
    public string Registry { get; set; }

    /// <summary>
    /// User to map volume access to Defaults to serivceaccount user
    /// </summary>
    /// <value>User to map volume access to Defaults to serivceaccount user</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public string User { get; set; }

    /// <summary>
    /// Volume is a string that references an already created Quobyte volume by name.
    /// </summary>
    /// <value>Volume is a string that references an already created Quobyte volume by name.</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public string Volume { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1QuobyteVolumeSource {\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  Registry: ").Append(Registry).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
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
