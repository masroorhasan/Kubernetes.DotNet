using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// LimitRangeSpec defines a min/max usage limit for resources that match on kind.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1LimitRangeSpec {
    /// <summary>
    /// Limits is the list of LimitRangeItem objects that are enforced.
    /// </summary>
    /// <value>Limits is the list of LimitRangeItem objects that are enforced.</value>
    [DataMember(Name="limits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limits")]
    public List<IoK8sKubernetesPkgApiV1LimitRangeItem> Limits { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1LimitRangeSpec {\n");
      sb.Append("  Limits: ").Append(Limits).Append("\n");
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
