using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ContainerStateTerminated is a terminated state of a container.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ContainerStateTerminated {
    /// <summary>
    /// Container's ID in the format 'docker://<container_id>'
    /// </summary>
    /// <value>Container's ID in the format 'docker://<container_id>'</value>
    [DataMember(Name="containerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerID")]
    public string ContainerID { get; set; }

    /// <summary>
    /// Exit status from the last termination of the container
    /// </summary>
    /// <value>Exit status from the last termination of the container</value>
    [DataMember(Name="exitCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exitCode")]
    public int? ExitCode { get; set; }

    /// <summary>
    /// Time at which the container last terminated
    /// </summary>
    /// <value>Time at which the container last terminated</value>
    [DataMember(Name="finishedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finishedAt")]
    // public IoK8sApimachineryPkgApisMetaV1Time FinishedAt { get; set; }
    public DateTime FinishedAt { get; set; }

    /// <summary>
    /// Message regarding the last termination of the container
    /// </summary>
    /// <value>Message regarding the last termination of the container</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// (brief) reason from the last termination of the container
    /// </summary>
    /// <value>(brief) reason from the last termination of the container</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Signal from the last termination of the container
    /// </summary>
    /// <value>Signal from the last termination of the container</value>
    [DataMember(Name="signal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signal")]
    public int? Signal { get; set; }

    /// <summary>
    /// Time at which previous execution of the container started
    /// </summary>
    /// <value>Time at which previous execution of the container started</value>
    [DataMember(Name="startedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startedAt")]
    // public IoK8sApimachineryPkgApisMetaV1Time StartedAt { get; set; }
    public DateTime StartedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ContainerStateTerminated {\n");
      sb.Append("  ContainerID: ").Append(ContainerID).Append("\n");
      sb.Append("  ExitCode: ").Append(ExitCode).Append("\n");
      sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Signal: ").Append(Signal).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
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
