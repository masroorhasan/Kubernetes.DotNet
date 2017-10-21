using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// DaemonEndpoint contains information about a single Daemon endpoint.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1DaemonEndpoint {
    /// <summary>
    /// Port number of the given endpoint.
    /// </summary>
    /// <value>Port number of the given endpoint.</value>
    [DataMember(Name="Port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Port")]
    public int? Port { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1DaemonEndpoint {\n");
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
