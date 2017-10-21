using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NodeSpec describes the attributes that a node is created with.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NodeSpec {
    /// <summary>
    /// External ID of the node assigned by some machine database (e.g. a cloud provider). Deprecated.
    /// </summary>
    /// <value>External ID of the node assigned by some machine database (e.g. a cloud provider). Deprecated.</value>
    [DataMember(Name="externalID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalID")]
    public string ExternalID { get; set; }

    /// <summary>
    /// PodCIDR represents the pod IP range assigned to the node.
    /// </summary>
    /// <value>PodCIDR represents the pod IP range assigned to the node.</value>
    [DataMember(Name="podCIDR", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podCIDR")]
    public string PodCIDR { get; set; }

    /// <summary>
    /// ID of the node assigned by the cloud provider in the format: <ProviderName>://<ProviderSpecificNodeID>
    /// </summary>
    /// <value>ID of the node assigned by the cloud provider in the format: <ProviderName>://<ProviderSpecificNodeID></value>
    [DataMember(Name="providerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "providerID")]
    public string ProviderID { get; set; }

    /// <summary>
    /// If specified, the node's taints.
    /// </summary>
    /// <value>If specified, the node's taints.</value>
    [DataMember(Name="taints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taints")]
    public List<IoK8sKubernetesPkgApiV1Taint> Taints { get; set; }

    /// <summary>
    /// Unschedulable controls node schedulability of new pods. By default, node is schedulable. More info: https://kubernetes.io/docs/concepts/nodes/node/#manual-node-administration
    /// </summary>
    /// <value>Unschedulable controls node schedulability of new pods. By default, node is schedulable. More info: https://kubernetes.io/docs/concepts/nodes/node/#manual-node-administration</value>
    [DataMember(Name="unschedulable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unschedulable")]
    public bool? Unschedulable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NodeSpec {\n");
      sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
      sb.Append("  PodCIDR: ").Append(PodCIDR).Append("\n");
      sb.Append("  ProviderID: ").Append(ProviderID).Append("\n");
      sb.Append("  Taints: ").Append(Taints).Append("\n");
      sb.Append("  Unschedulable: ").Append(Unschedulable).Append("\n");
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
