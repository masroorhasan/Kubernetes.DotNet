using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ReplicaSetSpec is the specification of a ReplicaSet.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetSpec {
    /// <summary>
    /// Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)
    /// </summary>
    /// <value>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</value>
    [DataMember(Name="minReadySeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    /// <summary>
    /// Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
    /// </summary>
    /// <value>Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replicas")]
    public int? Replicas { get; set; }

    /// <summary>
    /// Selector is a label query over pods that should match the replica count. If the selector is empty, it is defaulted to the labels present on the pod template. Label keys and values that must match in order to be controlled by this replica set. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
    /// </summary>
    /// <value>Selector is a label query over pods that should match the replica count. If the selector is empty, it is defaulted to the labels present on the pod template. Label keys and values that must match in order to be controlled by this replica set. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector Selector { get; set; }

    /// <summary>
    /// Template is the object that describes the pod that will be created if insufficient replicas are detected. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
    /// </summary>
    /// <value>Template is the object that describes the pod that will be created if insufficient replicas are detected. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public IoK8sKubernetesPkgApiV1PodTemplateSpec Template { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetSpec {\n");
      sb.Append("  MinReadySeconds: ").Append(MinReadySeconds).Append("\n");
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
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
