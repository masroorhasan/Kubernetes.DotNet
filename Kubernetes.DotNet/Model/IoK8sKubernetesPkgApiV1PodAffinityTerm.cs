using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; tches that of any node on which a pod of the set of pods is running
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PodAffinityTerm {
    /// <summary>
    /// A label query over a set of resources, in this case pods.
    /// </summary>
    /// <value>A label query over a set of resources, in this case pods.</value>
    [DataMember(Name="labelSelector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelSelector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector LabelSelector { get; set; }

    /// <summary>
    /// namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"
    /// </summary>
    /// <value>namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"</value>
    [DataMember(Name="namespaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespaces")]
    public List<string> Namespaces { get; set; }

    /// <summary>
    /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. For PreferredDuringScheduling pod anti-affinity, empty topologyKey is interpreted as \"all topologies\" (\"all topologies\" here means all the topologyKeys indicated by scheduler command-line argument - -failure-domains); for affinity and for RequiredDuringScheduling pod anti-affinity, empty topologyKey is not allowed.
    /// </summary>
    /// <value>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. For PreferredDuringScheduling pod anti-affinity, empty topologyKey is interpreted as \"all topologies\" (\"all topologies\" here means all the topologyKeys indicated by scheduler command-line argument - -failure-domains); for affinity and for RequiredDuringScheduling pod anti-affinity, empty topologyKey is not allowed.</value>
    [DataMember(Name="topologyKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topologyKey")]
    public string TopologyKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PodAffinityTerm {\n");
      sb.Append("  LabelSelector: ").Append(LabelSelector).Append("\n");
      sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
      sb.Append("  TopologyKey: ").Append(TopologyKey).Append("\n");
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
