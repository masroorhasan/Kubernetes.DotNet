using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NetworkPolicyPeer describes a peer to allow traffic from. Exactly one of its fields must be specified.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisNetworkingV1NetworkPolicyPeer {
    /// <summary>
    /// Selects Namespaces using cluster scoped-labels. This matches all pods in all namespaces selected by this label selector. This field follows standard label selector semantics. If present but empty, this selector selects all namespaces.
    /// </summary>
    /// <value>Selects Namespaces using cluster scoped-labels. This matches all pods in all namespaces selected by this label selector. This field follows standard label selector semantics. If present but empty, this selector selects all namespaces.</value>
    [DataMember(Name="namespaceSelector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespaceSelector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector NamespaceSelector { get; set; }

    /// <summary>
    /// This is a label selector which selects Pods in this namespace. This field follows standard label selector semantics. If present but empty, this selector selects all pods in this namespace.
    /// </summary>
    /// <value>This is a label selector which selects Pods in this namespace. This field follows standard label selector semantics. If present but empty, this selector selects all pods in this namespace.</value>
    [DataMember(Name="podSelector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podSelector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector PodSelector { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisNetworkingV1NetworkPolicyPeer {\n");
      sb.Append("  NamespaceSelector: ").Append(NamespaceSelector).Append("\n");
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
