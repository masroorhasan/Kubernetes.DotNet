using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NetworkPolicySpec provides the specification of a NetworkPolicy
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisNetworkingV1NetworkPolicySpec {
    /// <summary>
    /// List of ingress rules to be applied to the selected pods. Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic source is the pod's local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default)
    /// </summary>
    /// <value>List of ingress rules to be applied to the selected pods. Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic source is the pod's local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default)</value>
    [DataMember(Name="ingress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ingress")]
    public List<IoK8sKubernetesPkgApisNetworkingV1NetworkPolicyIngressRule> Ingress { get; set; }

    /// <summary>
    /// Selects the pods to which this NetworkPolicy object applies. The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods. In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace.
    /// </summary>
    /// <value>Selects the pods to which this NetworkPolicy object applies. The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods. In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace.</value>
    [DataMember(Name="podSelector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podSelector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector PodSelector { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisNetworkingV1NetworkPolicySpec {\n");
      sb.Append("  Ingress: ").Append(Ingress).Append("\n");
      sb.Append("  PodSelector: ").Append(PodSelector).Append("\n");
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
