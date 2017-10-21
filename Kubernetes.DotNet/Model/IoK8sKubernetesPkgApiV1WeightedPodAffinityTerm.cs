using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1WeightedPodAffinityTerm {
    /// <summary>
    /// Required. A pod affinity term, associated with the corresponding weight.
    /// </summary>
    /// <value>Required. A pod affinity term, associated with the corresponding weight.</value>
    [DataMember(Name="podAffinityTerm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podAffinityTerm")]
    public IoK8sKubernetesPkgApiV1PodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>
    /// weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
    /// </summary>
    /// <value>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public int? Weight { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1WeightedPodAffinityTerm {\n");
      sb.Append("  PodAffinityTerm: ").Append(PodAffinityTerm).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
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
