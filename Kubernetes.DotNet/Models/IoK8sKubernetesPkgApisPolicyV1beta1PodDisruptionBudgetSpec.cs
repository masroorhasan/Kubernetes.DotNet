using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodDisruptionBudgetSpec is a description of a PodDisruptionBudget.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisPolicyV1beta1PodDisruptionBudgetSpec {
    /// <summary>
    /// An eviction is allowed if at most \"maxUnavailable\" pods selected by \"selector\" are unavailable after the eviction, i.e. even in absence of the evicted pod. For example, one can prevent all voluntary evictions by specifying 0. This is a mutually exclusive setting with \"minAvailable\".
    /// </summary>
    /// <value>An eviction is allowed if at most \"maxUnavailable\" pods selected by \"selector\" are unavailable after the eviction, i.e. even in absence of the evicted pod. For example, one can prevent all voluntary evictions by specifying 0. This is a mutually exclusive setting with \"minAvailable\".</value>
    [DataMember(Name="maxUnavailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxUnavailable")]
    public IoK8sApimachineryPkgUtilIntstrIntOrString MaxUnavailable { get; set; }

    /// <summary>
    /// An eviction is allowed if at least \"minAvailable\" pods selected by \"selector\" will still be available after the eviction, i.e. even in the absence of the evicted pod.  So for example you can prevent all voluntary evictions by specifying \"100%\".
    /// </summary>
    /// <value>An eviction is allowed if at least \"minAvailable\" pods selected by \"selector\" will still be available after the eviction, i.e. even in the absence of the evicted pod.  So for example you can prevent all voluntary evictions by specifying \"100%\".</value>
    [DataMember(Name="minAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minAvailable")]
    public IoK8sApimachineryPkgUtilIntstrIntOrString MinAvailable { get; set; }

    /// <summary>
    /// Label query over pods whose evictions are managed by the disruption budget.
    /// </summary>
    /// <value>Label query over pods whose evictions are managed by the disruption budget.</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector Selector { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisPolicyV1beta1PodDisruptionBudgetSpec {\n");
      sb.Append("  MaxUnavailable: ").Append(MaxUnavailable).Append("\n");
      sb.Append("  MinAvailable: ").Append(MinAvailable).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
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
