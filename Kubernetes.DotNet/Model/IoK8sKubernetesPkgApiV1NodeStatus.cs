using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NodeStatus is information about the current status of a node.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NodeStatus {
    /// <summary>
    /// List of addresses reachable to the node. Queried from cloud provider, if available. More info: https://kubernetes.io/docs/concepts/nodes/node/#addresses
    /// </summary>
    /// <value>List of addresses reachable to the node. Queried from cloud provider, if available. More info: https://kubernetes.io/docs/concepts/nodes/node/#addresses</value>
    [DataMember(Name="addresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addresses")]
    public List<IoK8sKubernetesPkgApiV1NodeAddress> Addresses { get; set; }

    /// <summary>
    /// Allocatable represents the resources of a node that are available for scheduling. Defaults to Capacity.
    /// </summary>
    /// <value>Allocatable represents the resources of a node that are available for scheduling. Defaults to Capacity.</value>
    [DataMember(Name="allocatable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allocatable")]
    public Dictionary<string, IoK8sApimachineryPkgApiResourceQuantity> Allocatable { get; set; }

    /// <summary>
    /// Capacity represents the total resources of a node. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
    /// </summary>
    /// <value>Capacity represents the total resources of a node. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capacity")]
    public Dictionary<string, IoK8sApimachineryPkgApiResourceQuantity> Capacity { get; set; }

    /// <summary>
    /// Conditions is an array of current observed node conditions. More info: https://kubernetes.io/docs/concepts/nodes/node/#condition
    /// </summary>
    /// <value>Conditions is an array of current observed node conditions. More info: https://kubernetes.io/docs/concepts/nodes/node/#condition</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<IoK8sKubernetesPkgApiV1NodeCondition> Conditions { get; set; }

    /// <summary>
    /// Endpoints of daemons running on the Node.
    /// </summary>
    /// <value>Endpoints of daemons running on the Node.</value>
    [DataMember(Name="daemonEndpoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "daemonEndpoints")]
    public IoK8sKubernetesPkgApiV1NodeDaemonEndpoints DaemonEndpoints { get; set; }

    /// <summary>
    /// List of container images on this node
    /// </summary>
    /// <value>List of container images on this node</value>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public List<IoK8sKubernetesPkgApiV1ContainerImage> Images { get; set; }

    /// <summary>
    /// Set of ids/uuids to uniquely identify the node. More info: https://kubernetes.io/docs/concepts/nodes/node/#info
    /// </summary>
    /// <value>Set of ids/uuids to uniquely identify the node. More info: https://kubernetes.io/docs/concepts/nodes/node/#info</value>
    [DataMember(Name="nodeInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeInfo")]
    public IoK8sKubernetesPkgApiV1NodeSystemInfo NodeInfo { get; set; }

    /// <summary>
    /// NodePhase is the recently observed lifecycle phase of the node. More info: https://kubernetes.io/docs/concepts/nodes/node/#phase The field is never populated, and now is deprecated.
    /// </summary>
    /// <value>NodePhase is the recently observed lifecycle phase of the node. More info: https://kubernetes.io/docs/concepts/nodes/node/#phase The field is never populated, and now is deprecated.</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phase")]
    public string Phase { get; set; }

    /// <summary>
    /// List of volumes that are attached to the node.
    /// </summary>
    /// <value>List of volumes that are attached to the node.</value>
    [DataMember(Name="volumesAttached", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumesAttached")]
    public List<IoK8sKubernetesPkgApiV1AttachedVolume> VolumesAttached { get; set; }

    /// <summary>
    /// List of attachable volumes in use (mounted) by the node.
    /// </summary>
    /// <value>List of attachable volumes in use (mounted) by the node.</value>
    [DataMember(Name="volumesInUse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumesInUse")]
    public List<string> VolumesInUse { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NodeStatus {\n");
      sb.Append("  Addresses: ").Append(Addresses).Append("\n");
      sb.Append("  Allocatable: ").Append(Allocatable).Append("\n");
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  DaemonEndpoints: ").Append(DaemonEndpoints).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
      sb.Append("  NodeInfo: ").Append(NodeInfo).Append("\n");
      sb.Append("  Phase: ").Append(Phase).Append("\n");
      sb.Append("  VolumesAttached: ").Append(VolumesAttached).Append("\n");
      sb.Append("  VolumesInUse: ").Append(VolumesInUse).Append("\n");
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
