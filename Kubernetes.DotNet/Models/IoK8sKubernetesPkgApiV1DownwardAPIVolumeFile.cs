using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// DownwardAPIVolumeFile represents information to create the file containing the pod field
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1DownwardAPIVolumeFile {
    /// <summary>
    /// Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.
    /// </summary>
    /// <value>Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.</value>
    [DataMember(Name="fieldRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldRef")]
    public IoK8sKubernetesPkgApiV1ObjectFieldSelector FieldRef { get; set; }

    /// <summary>
    /// Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
    /// </summary>
    /// <value>Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</value>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public int? Mode { get; set; }

    /// <summary>
    /// Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'
    /// </summary>
    /// <value>Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.
    /// </summary>
    /// <value>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</value>
    [DataMember(Name="resourceFieldRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceFieldRef")]
    public IoK8sKubernetesPkgApiV1ResourceFieldSelector ResourceFieldRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1DownwardAPIVolumeFile {\n");
      sb.Append("  FieldRef: ").Append(FieldRef).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  ResourceFieldRef: ").Append(ResourceFieldRef).Append("\n");
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
