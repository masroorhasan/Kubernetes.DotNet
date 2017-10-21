using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Handler defines a specific action that should be taken
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1Handler {
    /// <summary>
    /// One and only one of the following should be specified. Exec specifies the action to take.
    /// </summary>
    /// <value>One and only one of the following should be specified. Exec specifies the action to take.</value>
    [DataMember(Name="exec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exec")]
    public IoK8sKubernetesPkgApiV1ExecAction Exec { get; set; }

    /// <summary>
    /// HTTPGet specifies the http request to perform.
    /// </summary>
    /// <value>HTTPGet specifies the http request to perform.</value>
    [DataMember(Name="httpGet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "httpGet")]
    public IoK8sKubernetesPkgApiV1HTTPGetAction HttpGet { get; set; }

    /// <summary>
    /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported
    /// </summary>
    /// <value>TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported</value>
    [DataMember(Name="tcpSocket", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tcpSocket")]
    public IoK8sKubernetesPkgApiV1TCPSocketAction TcpSocket { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1Handler {\n");
      sb.Append("  Exec: ").Append(Exec).Append("\n");
      sb.Append("  HttpGet: ").Append(HttpGet).Append("\n");
      sb.Append("  TcpSocket: ").Append(TcpSocket).Append("\n");
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
