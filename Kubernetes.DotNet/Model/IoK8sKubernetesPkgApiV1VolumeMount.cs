using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// VolumeMount describes a mounting of a Volume within a container.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1VolumeMount {
    /// <summary>
    /// Path within the container at which the volume should be mounted.  Must not contain ':'.
    /// </summary>
    /// <value>Path within the container at which the volume should be mounted.  Must not contain ':'.</value>
    [DataMember(Name="mountPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mountPath")]
    public string MountPath { get; set; }

    /// <summary>
    /// This must match the Name of a Volume.
    /// </summary>
    /// <value>This must match the Name of a Volume.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.
    /// </summary>
    /// <value>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// Path within the volume from which the container's volume should be mounted. Defaults to \"\" (volume's root).
    /// </summary>
    /// <value>Path within the volume from which the container's volume should be mounted. Defaults to \"\" (volume's root).</value>
    [DataMember(Name="subPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subPath")]
    public string SubPath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1VolumeMount {\n");
      sb.Append("  MountPath: ").Append(MountPath).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  SubPath: ").Append(SubPath).Append("\n");
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
