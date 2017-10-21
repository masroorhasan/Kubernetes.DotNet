using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// EndpointAddress is a tuple that describes single IP address.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1EndpointAddress {
    /// <summary>
    /// The Hostname of this endpoint
    /// </summary>
    /// <value>The Hostname of this endpoint</value>
    [DataMember(Name="hostname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostname")]
    public string Hostname { get; set; }

    /// <summary>
    /// The IP of this endpoint. May not be loopback (127.0.0.0/8), link-local (169.254.0.0/16), or link-local multicast ((224.0.0.0/24). IPv6 is also accepted but not fully supported on all platforms. Also, certain kubernetes components, like kube-proxy, are not IPv6 ready.
    /// </summary>
    /// <value>The IP of this endpoint. May not be loopback (127.0.0.0/8), link-local (169.254.0.0/16), or link-local multicast ((224.0.0.0/24). IPv6 is also accepted but not fully supported on all platforms. Also, certain kubernetes components, like kube-proxy, are not IPv6 ready.</value>
    [DataMember(Name="ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }

    /// <summary>
    /// Optional: Node hosting this endpoint. This can be used to determine endpoints local to a node.
    /// </summary>
    /// <value>Optional: Node hosting this endpoint. This can be used to determine endpoints local to a node.</value>
    [DataMember(Name="nodeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeName")]
    public string NodeName { get; set; }

    /// <summary>
    /// Reference to object providing the endpoint.
    /// </summary>
    /// <value>Reference to object providing the endpoint.</value>
    [DataMember(Name="targetRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetRef")]
    public IoK8sKubernetesPkgApiV1ObjectReference TargetRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1EndpointAddress {\n");
      sb.Append("  Hostname: ").Append(Hostname).Append("\n");
      sb.Append("  Ip: ").Append(Ip).Append("\n");
      sb.Append("  NodeName: ").Append(NodeName).Append("\n");
      sb.Append("  TargetRef: ").Append(TargetRef).Append("\n");
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
