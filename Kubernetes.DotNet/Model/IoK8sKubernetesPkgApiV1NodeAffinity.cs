using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Node affinity is a group of node affinity scheduling rules.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NodeAffinity {
    /// <summary>
    /// The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \"weight\" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
    /// </summary>
    /// <value>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \"weight\" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</value>
    [DataMember(Name="preferredDuringSchedulingIgnoredDuringExecution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preferredDuringSchedulingIgnoredDuringExecution")]
    public List<IoK8sKubernetesPkgApiV1PreferredSchedulingTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>
    /// If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
    /// </summary>
    /// <value>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</value>
    [DataMember(Name="requiredDuringSchedulingIgnoredDuringExecution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredDuringSchedulingIgnoredDuringExecution")]
    public IoK8sKubernetesPkgApiV1NodeSelector RequiredDuringSchedulingIgnoredDuringExecution { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NodeAffinity {\n");
      sb.Append("  PreferredDuringSchedulingIgnoredDuringExecution: ").Append(PreferredDuringSchedulingIgnoredDuringExecution).Append("\n");
      sb.Append("  RequiredDuringSchedulingIgnoredDuringExecution: ").Append(RequiredDuringSchedulingIgnoredDuringExecution).Append("\n");
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
