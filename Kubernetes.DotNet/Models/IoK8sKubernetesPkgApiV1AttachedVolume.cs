using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// AttachedVolume describes a volume attached to a node
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1AttachedVolume {
    /// <summary>
    /// DevicePath represents the device path where the volume should be available
    /// </summary>
    /// <value>DevicePath represents the device path where the volume should be available</value>
    [DataMember(Name="devicePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "devicePath")]
    public string DevicePath { get; set; }

    /// <summary>
    /// Name of the attached volume
    /// </summary>
    /// <value>Name of the attached volume</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1AttachedVolume {\n");
      sb.Append("  DevicePath: ").Append(DevicePath).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
