using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Adds and removes POSIX capabilities from running containers.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1Capabilities {
    /// <summary>
    /// Added capabilities
    /// </summary>
    /// <value>Added capabilities</value>
    [DataMember(Name="add", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add")]
    public List<string> Add { get; set; }

    /// <summary>
    /// Removed capabilities
    /// </summary>
    /// <value>Removed capabilities</value>
    [DataMember(Name="drop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drop")]
    public List<string> Drop { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1Capabilities {\n");
      sb.Append("  Add: ").Append(Add).Append("\n");
      sb.Append("  Drop: ").Append(Drop).Append("\n");
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
