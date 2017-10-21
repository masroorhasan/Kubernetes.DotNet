using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodsMetricStatus indicates the current value of a metric describing each pod in the current scale target (for example, transactions-processed-per-second).
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV2alpha1PodsMetricStatus {
    /// <summary>
    /// currentAverageValue is the current value of the average of the metric across all relevant pods (as a quantity)
    /// </summary>
    /// <value>currentAverageValue is the current value of the average of the metric across all relevant pods (as a quantity)</value>
    [DataMember(Name="currentAverageValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentAverageValue")]
    public IoK8sApimachineryPkgApiResourceQuantity CurrentAverageValue { get; set; }

    /// <summary>
    /// metricName is the name of the metric in question
    /// </summary>
    /// <value>metricName is the name of the metric in question</value>
    [DataMember(Name="metricName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricName")]
    public string MetricName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV2alpha1PodsMetricStatus {\n");
      sb.Append("  CurrentAverageValue: ").Append(CurrentAverageValue).Append("\n");
      sb.Append("  MetricName: ").Append(MetricName).Append("\n");
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
