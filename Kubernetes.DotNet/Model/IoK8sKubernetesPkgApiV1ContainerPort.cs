using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ContainerPort represents a network port in a single container.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ContainerPort {
    /// <summary>
    /// Number of port to expose on the pod's IP address. This must be a valid port number, 0 < x < 65536.
    /// </summary>
    /// <value>Number of port to expose on the pod's IP address. This must be a valid port number, 0 < x < 65536.</value>
    [DataMember(Name="containerPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerPort")]
    public int? ContainerPort { get; set; }

    /// <summary>
    /// What host IP to bind the external port to.
    /// </summary>
    /// <value>What host IP to bind the external port to.</value>
    [DataMember(Name="hostIP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostIP")]
    public string HostIP { get; set; }

    /// <summary>
    /// Number of port to expose on the host. If specified, this must be a valid port number, 0 < x < 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.
    /// </summary>
    /// <value>Number of port to expose on the host. If specified, this must be a valid port number, 0 < x < 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.</value>
    [DataMember(Name="hostPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostPort")]
    public int? HostPort { get; set; }

    /// <summary>
    /// If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.
    /// </summary>
    /// <value>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Protocol for port. Must be UDP or TCP. Defaults to \"TCP\".
    /// </summary>
    /// <value>Protocol for port. Must be UDP or TCP. Defaults to \"TCP\".</value>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public string Protocol { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ContainerPort {\n");
      sb.Append("  ContainerPort: ").Append(ContainerPort).Append("\n");
      sb.Append("  HostIP: ").Append(HostIP).Append("\n");
      sb.Append("  HostPort: ").Append(HostPort).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
