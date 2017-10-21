using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ContainerState holds a possible state of container. Only one of its members may be specified. If none of them is specified, the default one is ContainerStateWaiting.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ContainerState {
    /// <summary>
    /// Details about a running container
    /// </summary>
    /// <value>Details about a running container</value>
    [DataMember(Name="running", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "running")]
    public IoK8sKubernetesPkgApiV1ContainerStateRunning Running { get; set; }

    /// <summary>
    /// Details about a terminated container
    /// </summary>
    /// <value>Details about a terminated container</value>
    [DataMember(Name="terminated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminated")]
    public IoK8sKubernetesPkgApiV1ContainerStateTerminated Terminated { get; set; }

    /// <summary>
    /// Details about a waiting container
    /// </summary>
    /// <value>Details about a waiting container</value>
    [DataMember(Name="waiting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waiting")]
    public IoK8sKubernetesPkgApiV1ContainerStateWaiting Waiting { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ContainerState {\n");
      sb.Append("  Running: ").Append(Running).Append("\n");
      sb.Append("  Terminated: ").Append(Terminated).Append("\n");
      sb.Append("  Waiting: ").Append(Waiting).Append("\n");
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
