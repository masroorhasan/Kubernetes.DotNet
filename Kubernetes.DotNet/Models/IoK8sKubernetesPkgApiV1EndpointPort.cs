using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// EndpointPort is a tuple that describes a single port.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1EndpointPort {
    /// <summary>
    /// The name of this port (corresponds to ServicePort.Name). Must be a DNS_LABEL. Optional only if one port is defined.
    /// </summary>
    /// <value>The name of this port (corresponds to ServicePort.Name). Must be a DNS_LABEL. Optional only if one port is defined.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The port number of the endpoint.
    /// </summary>
    /// <value>The port number of the endpoint.</value>
    [DataMember(Name="port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "port")]
    public int? Port { get; set; }

    /// <summary>
    /// The IP protocol for this port. Must be UDP or TCP. Default is TCP.
    /// </summary>
    /// <value>The IP protocol for this port. Must be UDP or TCP. Default is TCP.</value>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public string Protocol { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1EndpointPort {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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
