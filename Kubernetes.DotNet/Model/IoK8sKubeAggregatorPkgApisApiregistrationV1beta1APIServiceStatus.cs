using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// APIServiceStatus contains derived information about an API server
  /// </summary>
  [DataContract]
  public class IoK8sKubeAggregatorPkgApisApiregistrationV1beta1APIServiceStatus {
    /// <summary>
    /// Current service state of apiService.
    /// </summary>
    /// <value>Current service state of apiService.</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<IoK8sKubeAggregatorPkgApisApiregistrationV1beta1APIServiceCondition> Conditions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubeAggregatorPkgApisApiregistrationV1beta1APIServiceStatus {\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
