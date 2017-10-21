using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// A node selector represents the union of the results of one or more label queries over a set of nodes; that is, it represents the OR of the selectors represented by the node selector terms.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NodeSelector {
    /// <summary>
    /// Required. A list of node selector terms. The terms are ORed.
    /// </summary>
    /// <value>Required. A list of node selector terms. The terms are ORed.</value>
    [DataMember(Name="nodeSelectorTerms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeSelectorTerms")]
    public List<IoK8sKubernetesPkgApiV1NodeSelectorTerm> NodeSelectorTerms { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NodeSelector {\n");
      sb.Append("  NodeSelectorTerms: ").Append(NodeSelectorTerms).Append("\n");
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
