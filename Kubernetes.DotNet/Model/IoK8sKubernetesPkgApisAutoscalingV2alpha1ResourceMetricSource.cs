using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ResourceMetricSource indicates how to scale on a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  The values will be averaged together before being compared to the target.  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the \&quot;pods\&quot; source.  Only one \&quot;target\&quot; type should be set.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV2alpha1ResourceMetricSource {
    /// <summary>
    /// name is the name of the resource in question.
    /// </summary>
    /// <value>name is the name of the resource in question.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// targetAverageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.
    /// </summary>
    /// <value>targetAverageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.</value>
    [DataMember(Name="targetAverageUtilization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetAverageUtilization")]
    public int? TargetAverageUtilization { get; set; }

    /// <summary>
    /// targetAverageValue is the target value of the average of the resource metric across all relevant pods, as a raw value (instead of as a percentage of the request), similar to the \"pods\" metric source type.
    /// </summary>
    /// <value>targetAverageValue is the target value of the average of the resource metric across all relevant pods, as a raw value (instead of as a percentage of the request), similar to the \"pods\" metric source type.</value>
    [DataMember(Name="targetAverageValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetAverageValue")]
    public IoK8sApimachineryPkgApiResourceQuantity TargetAverageValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV2alpha1ResourceMetricSource {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  TargetAverageUtilization: ").Append(TargetAverageUtilization).Append("\n");
      sb.Append("  TargetAverageValue: ").Append(TargetAverageValue).Append("\n");
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
