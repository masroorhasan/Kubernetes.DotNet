using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// specification of a horizontal pod autoscaler.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV1HorizontalPodAutoscalerSpec {
    /// <summary>
    /// upper limit for the number of pods that can be set by the autoscaler; cannot be smaller than MinReplicas.
    /// </summary>
    /// <value>upper limit for the number of pods that can be set by the autoscaler; cannot be smaller than MinReplicas.</value>
    [DataMember(Name="maxReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxReplicas")]
    public int? MaxReplicas { get; set; }

    /// <summary>
    /// lower limit for the number of pods that can be set by the autoscaler, default 1.
    /// </summary>
    /// <value>lower limit for the number of pods that can be set by the autoscaler, default 1.</value>
    [DataMember(Name="minReplicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minReplicas")]
    public int? MinReplicas { get; set; }

    /// <summary>
    /// reference to scaled resource; horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.
    /// </summary>
    /// <value>reference to scaled resource; horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.</value>
    [DataMember(Name="scaleTargetRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaleTargetRef")]
    public IoK8sKubernetesPkgApisAutoscalingV1CrossVersionObjectReference ScaleTargetRef { get; set; }

    /// <summary>
    /// target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified the default autoscaling policy will be used.
    /// </summary>
    /// <value>target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified the default autoscaling policy will be used.</value>
    [DataMember(Name="targetCPUUtilizationPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetCPUUtilizationPercentage")]
    public int? TargetCPUUtilizationPercentage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV1HorizontalPodAutoscalerSpec {\n");
      sb.Append("  MaxReplicas: ").Append(MaxReplicas).Append("\n");
      sb.Append("  MinReplicas: ").Append(MinReplicas).Append("\n");
      sb.Append("  ScaleTargetRef: ").Append(ScaleTargetRef).Append("\n");
      sb.Append("  TargetCPUUtilizationPercentage: ").Append(TargetCPUUtilizationPercentage).Append("\n");
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
