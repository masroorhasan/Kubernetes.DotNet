using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// DaemonSetSpec is the specification of a daemon set.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetSpec {
    /// <summary>
    /// The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready).
    /// </summary>
    /// <value>The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready).</value>
    [DataMember(Name="minReadySeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minReadySeconds")]
    public int? MinReadySeconds { get; set; }

    /// <summary>
    /// The number of old history to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.
    /// </summary>
    /// <value>The number of old history to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.</value>
    [DataMember(Name="revisionHistoryLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revisionHistoryLimit")]
    public int? RevisionHistoryLimit { get; set; }

    /// <summary>
    /// A label query over pods that are managed by the daemon set. Must match in order to be controlled. If empty, defaulted to labels on Pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
    /// </summary>
    /// <value>A label query over pods that are managed by the daemon set. Must match in order to be controlled. If empty, defaulted to labels on Pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector Selector { get; set; }

    /// <summary>
    /// An object that describes the pod that will be created. The DaemonSet will create exactly one copy of this pod on every node that matches the template's node selector (or on every node if no node selector is specified). More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
    /// </summary>
    /// <value>An object that describes the pod that will be created. The DaemonSet will create exactly one copy of this pod on every node that matches the template's node selector (or on every node if no node selector is specified). More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public IoK8sKubernetesPkgApiV1PodTemplateSpec Template { get; set; }

    /// <summary>
    /// DEPRECATED. A sequence number representing a specific generation of the template. Populated by the system. It can be set only during the creation.
    /// </summary>
    /// <value>DEPRECATED. A sequence number representing a specific generation of the template. Populated by the system. It can be set only during the creation.</value>
    [DataMember(Name="templateGeneration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templateGeneration")]
    public long? TemplateGeneration { get; set; }

    /// <summary>
    /// An update strategy to replace existing DaemonSet pods with new pods.
    /// </summary>
    /// <value>An update strategy to replace existing DaemonSet pods with new pods.</value>
    [DataMember(Name="updateStrategy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateStrategy")]
    public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetUpdateStrategy UpdateStrategy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetSpec {\n");
      sb.Append("  MinReadySeconds: ").Append(MinReadySeconds).Append("\n");
      sb.Append("  RevisionHistoryLimit: ").Append(RevisionHistoryLimit).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  TemplateGeneration: ").Append(TemplateGeneration).Append("\n");
      sb.Append("  UpdateStrategy: ").Append(UpdateStrategy).Append("\n");
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
