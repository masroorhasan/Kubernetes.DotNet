using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodsMetricSource indicates how to scale on a metric describing each pod in the current scale target (for example, transactions-processed-per-second). The values will be averaged together before being compared to the target value.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV2alpha1PodsMetricSource {
    /// <summary>
    /// metricName is the name of the metric in question
    /// </summary>
    /// <value>metricName is the name of the metric in question</value>
    [DataMember(Name="metricName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricName")]
    public string MetricName { get; set; }

    /// <summary>
    /// targetAverageValue is the target value of the average of the metric across all relevant pods (as a quantity)
    /// </summary>
    /// <value>targetAverageValue is the target value of the average of the metric across all relevant pods (as a quantity)</value>
    [DataMember(Name="targetAverageValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetAverageValue")]
    public IoK8sApimachineryPkgApiResourceQuantity TargetAverageValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV2alpha1PodsMetricSource {\n");
      sb.Append("  MetricName: ").Append(MetricName).Append("\n");
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
