using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ObjectMetricStatus indicates the current value of a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV2alpha1ObjectMetricStatus {
    /// <summary>
    /// currentValue is the current value of the metric (as a quantity).
    /// </summary>
    /// <value>currentValue is the current value of the metric (as a quantity).</value>
    [DataMember(Name="currentValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentValue")]
    public IoK8sApimachineryPkgApiResourceQuantity CurrentValue { get; set; }

    /// <summary>
    /// metricName is the name of the metric in question.
    /// </summary>
    /// <value>metricName is the name of the metric in question.</value>
    [DataMember(Name="metricName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricName")]
    public string MetricName { get; set; }

    /// <summary>
    /// target is the described Kubernetes object.
    /// </summary>
    /// <value>target is the described Kubernetes object.</value>
    [DataMember(Name="target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target")]
    public IoK8sKubernetesPkgApisAutoscalingV2alpha1CrossVersionObjectReference Target { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV2alpha1ObjectMetricStatus {\n");
      sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
      sb.Append("  MetricName: ").Append(MetricName).Append("\n");
      sb.Append("  Target: ").Append(Target).Append("\n");
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
