using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// HorizontalPodAutoscalerSpec describes the desired functionality of the HorizontalPodAutoscaler.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV2alpha1HorizontalPodAutoscalerSpec {
    /// <summary>
    /// maxReplicas is the upper limit for the number of replicas to which the autoscaler can scale up. It cannot be less that minReplicas.
    /// </summary>
    /// <value>maxReplicas is the upper limit for the number of replicas to which the autoscaler can scale up. It cannot be less that minReplicas.</value>
    [DataMember(Name="maxReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxReplicas")]
    public int? MaxReplicas { get; set; }

    /// <summary>
    /// metrics contains the specifications for which to use to calculate the desired replica count (the maximum replica count across all metrics will be used).  The desired replica count is calculated multiplying the ratio between the target value and the current value by the current number of pods.  Ergo, metrics used must decrease as the pod count is increased, and vice-versa.  See the individual metric source types for more information about how each type of metric must respond.
    /// </summary>
    /// <value>metrics contains the specifications for which to use to calculate the desired replica count (the maximum replica count across all metrics will be used).  The desired replica count is calculated multiplying the ratio between the target value and the current value by the current number of pods.  Ergo, metrics used must decrease as the pod count is increased, and vice-versa.  See the individual metric source types for more information about how each type of metric must respond.</value>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public List<IoK8sKubernetesPkgApisAutoscalingV2alpha1MetricSpec> Metrics { get; set; }

    /// <summary>
    /// minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down. It defaults to 1 pod.
    /// </summary>
    /// <value>minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down. It defaults to 1 pod.</value>
    [DataMember(Name="minReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minReplicas")]
    public int? MinReplicas { get; set; }

    /// <summary>
    /// scaleTargetRef points to the target resource to scale, and is used to the pods for which metrics should be collected, as well as to actually change the replica count.
    /// </summary>
    /// <value>scaleTargetRef points to the target resource to scale, and is used to the pods for which metrics should be collected, as well as to actually change the replica count.</value>
    [DataMember(Name="scaleTargetRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaleTargetRef")]
    public IoK8sKubernetesPkgApisAutoscalingV2alpha1CrossVersionObjectReference ScaleTargetRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV2alpha1HorizontalPodAutoscalerSpec {\n");
      sb.Append("  MaxReplicas: ").Append(MaxReplicas).Append("\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
      sb.Append("  MinReplicas: ").Append(MinReplicas).Append("\n");
      sb.Append("  ScaleTargetRef: ").Append(ScaleTargetRef).Append("\n");
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
