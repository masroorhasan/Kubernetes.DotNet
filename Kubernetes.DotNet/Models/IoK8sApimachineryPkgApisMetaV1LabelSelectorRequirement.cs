using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1LabelSelectorRequirement {
    /// <summary>
    /// key is the label key that the selector applies to.
    /// </summary>
    /// <value>key is the label key that the selector applies to.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// operator represents a key's relationship to a set of values. Valid operators ard In, NotIn, Exists and DoesNotExist.
    /// </summary>
    /// <value>operator represents a key's relationship to a set of values. Valid operators ard In, NotIn, Exists and DoesNotExist.</value>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string _Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
    /// </summary>
    /// <value>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</value>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public List<string> Values { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1LabelSelectorRequirement {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  _Operator: ").Append(_Operator).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
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
