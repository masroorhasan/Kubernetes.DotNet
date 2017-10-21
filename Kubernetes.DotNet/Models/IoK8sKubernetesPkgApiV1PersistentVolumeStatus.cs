using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PersistentVolumeStatus is the current status of a persistent volume.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PersistentVolumeStatus {
    /// <summary>
    /// A human-readable message indicating details about why the volume is in this state.
    /// </summary>
    /// <value>A human-readable message indicating details about why the volume is in this state.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#phase
    /// </summary>
    /// <value>Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#phase</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phase")]
    public string Phase { get; set; }

    /// <summary>
    /// Reason is a brief CamelCase string that describes any failure and is meant for machine parsing and tidy display in the CLI.
    /// </summary>
    /// <value>Reason is a brief CamelCase string that describes any failure and is meant for machine parsing and tidy display in the CLI.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PersistentVolumeStatus {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Phase: ").Append(Phase).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
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
