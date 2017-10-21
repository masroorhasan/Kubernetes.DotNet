using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NetworkPolicyPort describes a port to allow traffic on
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisNetworkingV1NetworkPolicyPort {
    /// <summary>
    /// The port on the given protocol. This can either be a numerical or named port on a pod. If this field is not provided, this matches all port names and numbers.
    /// </summary>
    /// <value>The port on the given protocol. This can either be a numerical or named port on a pod. If this field is not provided, this matches all port names and numbers.</value>
    [DataMember(Name="port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "port")]
    public IoK8sApimachineryPkgUtilIntstrIntOrString Port { get; set; }

    /// <summary>
    /// The protocol (TCP or UDP) which traffic must match. If not specified, this field defaults to TCP.
    /// </summary>
    /// <value>The protocol (TCP or UDP) which traffic must match. If not specified, this field defaults to TCP.</value>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public string Protocol { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisNetworkingV1NetworkPolicyPort {\n");
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
