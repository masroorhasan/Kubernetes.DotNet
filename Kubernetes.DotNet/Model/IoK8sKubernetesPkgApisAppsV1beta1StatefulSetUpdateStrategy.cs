using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// StatefulSetUpdateStrategy indicates the strategy that the StatefulSet controller will use to perform updates. It includes any additional parameters necessary to perform the update for the indicated strategy.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAppsV1beta1StatefulSetUpdateStrategy {
    /// <summary>
    /// RollingUpdate is used to communicate parameters when Type is RollingUpdateStatefulSetStrategyType.
    /// </summary>
    /// <value>RollingUpdate is used to communicate parameters when Type is RollingUpdateStatefulSetStrategyType.</value>
    [DataMember(Name="rollingUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rollingUpdate")]
    public IoK8sKubernetesPkgApisAppsV1beta1RollingUpdateStatefulSetStrategy RollingUpdate { get; set; }

    /// <summary>
    /// Type indicates the type of the StatefulSetUpdateStrategy.
    /// </summary>
    /// <value>Type indicates the type of the StatefulSetUpdateStrategy.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAppsV1beta1StatefulSetUpdateStrategy {\n");
      sb.Append("  RollingUpdate: ").Append(RollingUpdate).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
