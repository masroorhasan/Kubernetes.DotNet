using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// RollingUpdateStatefulSetStrategy is used to communicate parameter for RollingUpdateStatefulSetStrategyType.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAppsV1beta1RollingUpdateStatefulSetStrategy {
    /// <summary>
    /// Partition indicates the ordinal at which the StatefulSet should be partitioned.
    /// </summary>
    /// <value>Partition indicates the ordinal at which the StatefulSet should be partitioned.</value>
    [DataMember(Name="partition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partition")]
    public int? Partition { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAppsV1beta1RollingUpdateStatefulSetStrategy {\n");
      sb.Append("  Partition: ").Append(Partition).Append("\n");
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
