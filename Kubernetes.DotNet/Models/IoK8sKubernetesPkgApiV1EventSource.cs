using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// EventSource contains information for an event.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1EventSource {
    /// <summary>
    /// Component from which the event is generated.
    /// </summary>
    /// <value>Component from which the event is generated.</value>
    [DataMember(Name="component", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "component")]
    public string Component { get; set; }

    /// <summary>
    /// Node name on which the event is generated.
    /// </summary>
    /// <value>Node name on which the event is generated.</value>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public string Host { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1EventSource {\n");
      sb.Append("  Component: ").Append(Component).Append("\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
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
