using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// A StatefulSetSpec is the specification of a StatefulSet.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAppsV1beta1StatefulSetSpec {
    /// <summary>
    /// podManagementPolicy controls how pods are created during initial scale up, when replacing pods on nodes, or when scaling down. The default policy is `OrderedReady`, where pods are created in increasing order (pod-0, then pod-1, etc) and the controller will wait until each pod is ready before continuing. When scaling down, the pods are removed in the opposite order. The alternative policy is `Parallel` which will create pods in parallel to match the desired scale without waiting, and on scale down will delete all pods at once.
    /// </summary>
    /// <value>podManagementPolicy controls how pods are created during initial scale up, when replacing pods on nodes, or when scaling down. The default policy is `OrderedReady`, where pods are created in increasing order (pod-0, then pod-1, etc) and the controller will wait until each pod is ready before continuing. When scaling down, the pods are removed in the opposite order. The alternative policy is `Parallel` which will create pods in parallel to match the desired scale without waiting, and on scale down will delete all pods at once.</value>
    [DataMember(Name="podManagementPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podManagementPolicy")]
    public string PodManagementPolicy { get; set; }

    /// <summary>
    /// replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.
    /// </summary>
    /// <value>replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replicas")]
    public int? Replicas { get; set; }

    /// <summary>
    /// revisionHistoryLimit is the maximum number of revisions that will be maintained in the StatefulSet's revision history. The revision history consists of all revisions not represented by a currently applied StatefulSetSpec version. The default value is 10.
    /// </summary>
    /// <value>revisionHistoryLimit is the maximum number of revisions that will be maintained in the StatefulSet's revision history. The revision history consists of all revisions not represented by a currently applied StatefulSetSpec version. The default value is 10.</value>
    [DataMember(Name="revisionHistoryLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revisionHistoryLimit")]
    public int? RevisionHistoryLimit { get; set; }

    /// <summary>
    /// selector is a label query over pods that should match the replica count. If empty, defaulted to labels on the pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
    /// </summary>
    /// <value>selector is a label query over pods that should match the replica count. If empty, defaulted to labels on the pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector Selector { get; set; }

    /// <summary>
    /// serviceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-string.serviceName.default.svc.cluster.local where \"pod-specific-string\" is managed by the StatefulSet controller.
    /// </summary>
    /// <value>serviceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-string.serviceName.default.svc.cluster.local where \"pod-specific-string\" is managed by the StatefulSet controller.</value>
    [DataMember(Name="serviceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// template is the object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet.
    /// </summary>
    /// <value>template is the object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet.</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public IoK8sKubernetesPkgApiV1PodTemplateSpec Template { get; set; }

    /// <summary>
    /// updateStrategy indicates the StatefulSetUpdateStrategy that will be employed to update Pods in the StatefulSet when a revision is made to Template.
    /// </summary>
    /// <value>updateStrategy indicates the StatefulSetUpdateStrategy that will be employed to update Pods in the StatefulSet when a revision is made to Template.</value>
    [DataMember(Name="updateStrategy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateStrategy")]
    public IoK8sKubernetesPkgApisAppsV1beta1StatefulSetUpdateStrategy UpdateStrategy { get; set; }

    /// <summary>
    /// volumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.
    /// </summary>
    /// <value>volumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.</value>
    [DataMember(Name="volumeClaimTemplates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumeClaimTemplates")]
    public List<IoK8sKubernetesPkgApiV1PersistentVolumeClaim> VolumeClaimTemplates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAppsV1beta1StatefulSetSpec {\n");
      sb.Append("  PodManagementPolicy: ").Append(PodManagementPolicy).Append("\n");
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      sb.Append("  RevisionHistoryLimit: ").Append(RevisionHistoryLimit).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  UpdateStrategy: ").Append(UpdateStrategy).Append("\n");
      sb.Append("  VolumeClaimTemplates: ").Append(VolumeClaimTemplates).Append("\n");
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
