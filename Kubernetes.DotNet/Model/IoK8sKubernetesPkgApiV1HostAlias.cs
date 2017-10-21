using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod&#39;s hosts file.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1HostAlias {
    /// <summary>
    /// Hostnames for the above IP address.
    /// </summary>
    /// <value>Hostnames for the above IP address.</value>
    [DataMember(Name="hostnames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostnames")]
    public List<string> Hostnames { get; set; }

    /// <summary>
    /// IP address of the host file entry.
    /// </summary>
    /// <value>IP address of the host file entry.</value>
    [DataMember(Name="ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1HostAlias {\n");
      sb.Append("  Hostnames: ").Append(Hostnames).Append("\n");
      sb.Append("  Ip: ").Append(Ip).Append("\n");
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
