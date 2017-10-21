using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Host Port Range defines a range of host ports that will be enabled by a policy for pods to use.  It requires both the start and end to be defined.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1HostPortRange {
    /// <summary>
    /// max is the end of the range, inclusive.
    /// </summary>
    /// <value>max is the end of the range, inclusive.</value>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max")]
    public int? Max { get; set; }

    /// <summary>
    /// min is the start of the range, inclusive.
    /// </summary>
    /// <value>min is the start of the range, inclusive.</value>
    [DataMember(Name="min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min")]
    public int? Min { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1HostPortRange {\n");
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
