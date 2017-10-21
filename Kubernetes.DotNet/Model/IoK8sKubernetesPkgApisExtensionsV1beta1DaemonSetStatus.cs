using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// DaemonSetStatus represents the current status of a daemon set.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetStatus {
    /// <summary>
    /// Count of hash collisions for the DaemonSet. The DaemonSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.
    /// </summary>
    /// <value>Count of hash collisions for the DaemonSet. The DaemonSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</value>
    [DataMember(Name="collisionCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collisionCount")]
    public long? CollisionCount { get; set; }

    /// <summary>
    /// The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/
    /// </summary>
    /// <value>The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</value>
    [DataMember(Name="currentNumberScheduled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentNumberScheduled")]
    public int? CurrentNumberScheduled { get; set; }

    /// <summary>
    /// The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/
    /// </summary>
    /// <value>The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</value>
    [DataMember(Name="desiredNumberScheduled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desiredNumberScheduled")]
    public int? DesiredNumberScheduled { get; set; }

    /// <summary>
    /// The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)
    /// </summary>
    /// <value>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)</value>
    [DataMember(Name="numberAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberAvailable")]
    public int? NumberAvailable { get; set; }

    /// <summary>
    /// The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/
    /// </summary>
    /// <value>The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</value>
    [DataMember(Name="numberMisscheduled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberMisscheduled")]
    public int? NumberMisscheduled { get; set; }

    /// <summary>
    /// The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready.
    /// </summary>
    /// <value>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready.</value>
    [DataMember(Name="numberReady", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberReady")]
    public int? NumberReady { get; set; }

    /// <summary>
    /// The number of nodes that should be running the daemon pod and have none of the daemon pod running and available (ready for at least spec.minReadySeconds)
    /// </summary>
    /// <value>The number of nodes that should be running the daemon pod and have none of the daemon pod running and available (ready for at least spec.minReadySeconds)</value>
    [DataMember(Name="numberUnavailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberUnavailable")]
    public int? NumberUnavailable { get; set; }

    /// <summary>
    /// The most recent generation observed by the daemon set controller.
    /// </summary>
    /// <value>The most recent generation observed by the daemon set controller.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// The total number of nodes that are running updated daemon pod
    /// </summary>
    /// <value>The total number of nodes that are running updated daemon pod</value>
    [DataMember(Name="updatedNumberScheduled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedNumberScheduled")]
    public int? UpdatedNumberScheduled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetStatus {\n");
      sb.Append("  CollisionCount: ").Append(CollisionCount).Append("\n");
      sb.Append("  CurrentNumberScheduled: ").Append(CurrentNumberScheduled).Append("\n");
      sb.Append("  DesiredNumberScheduled: ").Append(DesiredNumberScheduled).Append("\n");
      sb.Append("  NumberAvailable: ").Append(NumberAvailable).Append("\n");
      sb.Append("  NumberMisscheduled: ").Append(NumberMisscheduled).Append("\n");
      sb.Append("  NumberReady: ").Append(NumberReady).Append("\n");
      sb.Append("  NumberUnavailable: ").Append(NumberUnavailable).Append("\n");
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
      sb.Append("  UpdatedNumberScheduled: ").Append(UpdatedNumberScheduled).Append("\n");
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
