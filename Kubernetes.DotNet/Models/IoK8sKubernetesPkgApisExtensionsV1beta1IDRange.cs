using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ID Range provides a min/max of an allowed range of IDs.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1IDRange {
    /// <summary>
    /// Max is the end of the range, inclusive.
    /// </summary>
    /// <value>Max is the end of the range, inclusive.</value>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max")]
    public long? Max { get; set; }

    /// <summary>
    /// Min is the start of the range, inclusive.
    /// </summary>
    /// <value>Min is the start of the range, inclusive.</value>
    [DataMember(Name="min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min")]
    public long? Min { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1IDRange {\n");
      sb.Append("  Max: ").Append(Max).Append("\n");
      sb.Append("  Min: ").Append(Min).Append("\n");
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
