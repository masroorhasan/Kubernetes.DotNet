using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// TCPSocketAction describes an action based on opening a socket
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1TCPSocketAction {
    /// <summary>
    /// Optional: Host name to connect to, defaults to the pod IP.
    /// </summary>
    /// <value>Optional: Host name to connect to, defaults to the pod IP.</value>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public string Host { get; set; }

    /// <summary>
    /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
    /// </summary>
    /// <value>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</value>
    [DataMember(Name="port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "port")]
    public IoK8sApimachineryPkgUtilIntstrIntOrString Port { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1TCPSocketAction {\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
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
