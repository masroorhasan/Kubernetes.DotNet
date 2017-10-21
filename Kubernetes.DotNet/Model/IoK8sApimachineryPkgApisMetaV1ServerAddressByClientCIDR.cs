using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ServerAddressByClientCIDR helps the client to determine the server address that they should use, depending on the clientCIDR that they match.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1ServerAddressByClientCIDR {
    /// <summary>
    /// The CIDR with which clients can match their IP to figure out the server address that they should use.
    /// </summary>
    /// <value>The CIDR with which clients can match their IP to figure out the server address that they should use.</value>
    [DataMember(Name="clientCIDR", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientCIDR")]
    public string ClientCIDR { get; set; }

    /// <summary>
    /// Address of this server, suitable for a client that matches the above CIDR. This can be a hostname, hostname:port, IP or IP:port.
    /// </summary>
    /// <value>Address of this server, suitable for a client that matches the above CIDR. This can be a hostname, hostname:port, IP or IP:port.</value>
    [DataMember(Name="serverAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverAddress")]
    public string ServerAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1ServerAddressByClientCIDR {\n");
      sb.Append("  ClientCIDR: ").Append(ClientCIDR).Append("\n");
      sb.Append("  ServerAddress: ").Append(ServerAddress).Append("\n");
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
