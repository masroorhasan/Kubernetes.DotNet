using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// SupplementalGroupsStrategyOptions defines the strategy type and options used to create the strategy.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1SupplementalGroupsStrategyOptions {
    /// <summary>
    /// Ranges are the allowed ranges of supplemental groups.  If you would like to force a single supplemental group then supply a single range with the same start and end.
    /// </summary>
    /// <value>Ranges are the allowed ranges of supplemental groups.  If you would like to force a single supplemental group then supply a single range with the same start and end.</value>
    [DataMember(Name="ranges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ranges")]
    public List<IoK8sKubernetesPkgApisExtensionsV1beta1IDRange> Ranges { get; set; }

    /// <summary>
    /// Rule is the strategy that will dictate what supplemental groups is used in the SecurityContext.
    /// </summary>
    /// <value>Rule is the strategy that will dictate what supplemental groups is used in the SecurityContext.</value>
    [DataMember(Name="rule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule")]
    public string Rule { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1SupplementalGroupsStrategyOptions {\n");
      sb.Append("  Ranges: ").Append(Ranges).Append("\n");
      sb.Append("  Rule: ").Append(Rule).Append("\n");
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
