using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// The node this Taint is attached to has the effect \&quot;effect\&quot; on any pod that that does not tolerate the Taint.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1Taint {
    /// <summary>
    /// Required. The effect of the taint on pods that do not tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule and NoExecute.
    /// </summary>
    /// <value>Required. The effect of the taint on pods that do not tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule and NoExecute.</value>
    [DataMember(Name="effect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect")]
    public string Effect { get; set; }

    /// <summary>
    /// Required. The taint key to be applied to a node.
    /// </summary>
    /// <value>Required. The taint key to be applied to a node.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// TimeAdded represents the time at which the taint was added. It is only written for NoExecute taints.
    /// </summary>
    /// <value>TimeAdded represents the time at which the taint was added. It is only written for NoExecute taints.</value>
    [DataMember(Name="timeAdded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeAdded")]
    public IoK8sApimachineryPkgApisMetaV1Time TimeAdded { get; set; }

    /// <summary>
    /// Required. The taint value corresponding to the taint key.
    /// </summary>
    /// <value>Required. The taint value corresponding to the taint key.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1Taint {\n");
      sb.Append("  Effect: ").Append(Effect).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  TimeAdded: ").Append(TimeAdded).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
