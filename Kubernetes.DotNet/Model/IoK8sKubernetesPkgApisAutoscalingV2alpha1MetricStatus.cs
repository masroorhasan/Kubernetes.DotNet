using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// MetricStatus describes the last-read state of a single metric.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV2alpha1MetricStatus {
    /// <summary>
    /// object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object).
    /// </summary>
    /// <value>object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object).</value>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public IoK8sKubernetesPkgApisAutoscalingV2alpha1ObjectMetricStatus _Object { get; set; }

    /// <summary>
    /// pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.
    /// </summary>
    /// <value>pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.</value>
    [DataMember(Name="pods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pods")]
    public IoK8sKubernetesPkgApisAutoscalingV2alpha1PodsMetricStatus Pods { get; set; }

    /// <summary>
    /// resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the \"pods\" source.
    /// </summary>
    /// <value>resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the \"pods\" source.</value>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public IoK8sKubernetesPkgApisAutoscalingV2alpha1ResourceMetricStatus Resource { get; set; }

    /// <summary>
    /// type is the type of metric source.  It will match one of the fields below.
    /// </summary>
    /// <value>type is the type of metric source.  It will match one of the fields below.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV2alpha1MetricStatus {\n");
      sb.Append("  _Object: ").Append(_Object).Append("\n");
      sb.Append("  Pods: ").Append(Pods).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
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
