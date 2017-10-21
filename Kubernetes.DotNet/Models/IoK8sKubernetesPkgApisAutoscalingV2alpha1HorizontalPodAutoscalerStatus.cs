using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// HorizontalPodAutoscalerStatus describes the current status of a horizontal pod autoscaler.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV2alpha1HorizontalPodAutoscalerStatus {
    /// <summary>
    /// conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met.
    /// </summary>
    /// <value>conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met.</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<IoK8sKubernetesPkgApisAutoscalingV2alpha1HorizontalPodAutoscalerCondition> Conditions { get; set; }

    /// <summary>
    /// currentMetrics is the last read state of the metrics used by this autoscaler.
    /// </summary>
    /// <value>currentMetrics is the last read state of the metrics used by this autoscaler.</value>
    [DataMember(Name="currentMetrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentMetrics")]
    public List<IoK8sKubernetesPkgApisAutoscalingV2alpha1MetricStatus> CurrentMetrics { get; set; }

    /// <summary>
    /// currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler.
    /// </summary>
    /// <value>currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler.</value>
    [DataMember(Name="currentReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentReplicas")]
    public int? CurrentReplicas { get; set; }

    /// <summary>
    /// desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.
    /// </summary>
    /// <value>desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.</value>
    [DataMember(Name="desiredReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desiredReplicas")]
    public int? DesiredReplicas { get; set; }

    /// <summary>
    /// lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed.
    /// </summary>
    /// <value>lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed.</value>
    [DataMember(Name="lastScaleTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastScaleTime")]
    public IoK8sApimachineryPkgApisMetaV1Time LastScaleTime { get; set; }

    /// <summary>
    /// observedGeneration is the most recent generation observed by this autoscaler.
    /// </summary>
    /// <value>observedGeneration is the most recent generation observed by this autoscaler.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "observedGeneration")]
    public long? ObservedGeneration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV2alpha1HorizontalPodAutoscalerStatus {\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  CurrentMetrics: ").Append(CurrentMetrics).Append("\n");
      sb.Append("  CurrentReplicas: ").Append(CurrentReplicas).Append("\n");
      sb.Append("  DesiredReplicas: ").Append(DesiredReplicas).Append("\n");
      sb.Append("  LastScaleTime: ").Append(LastScaleTime).Append("\n");
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
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
