using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// A null or empty node selector term matches no objects.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NodeSelectorTerm {
    /// <summary>
    /// Required. A list of node selector requirements. The requirements are ANDed.
    /// </summary>
    /// <value>Required. A list of node selector requirements. The requirements are ANDed.</value>
    [DataMember(Name="matchExpressions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matchExpressions")]
    public List<IoK8sKubernetesPkgApiV1NodeSelectorRequirement> MatchExpressions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NodeSelectorTerm {\n");
      sb.Append("  MatchExpressions: ").Append(MatchExpressions).Append("\n");
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
