using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Run A sUser Strategy Options defines the strategy type and any options used to create the strategy.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1RunAsUserStrategyOptions {
    /// <summary>
    /// Ranges are the allowed ranges of uids that may be used.
    /// </summary>
    /// <value>Ranges are the allowed ranges of uids that may be used.</value>
    [DataMember(Name="ranges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ranges")]
    public List<IoK8sKubernetesPkgApisExtensionsV1beta1IDRange> Ranges { get; set; }

    /// <summary>
    /// Rule is the strategy that will dictate the allowable RunAsUser values that may be set.
    /// </summary>
    /// <value>Rule is the strategy that will dictate the allowable RunAsUser values that may be set.</value>
    [DataMember(Name="rule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule")]
    public string Rule { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1RunAsUserStrategyOptions {\n");
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
