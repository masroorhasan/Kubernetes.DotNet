using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Local represents directly-attached storage with node affinity
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1LocalVolumeSource {
    /// <summary>
    /// The full path to the volume on the node For alpha, this path must be a directory Once block as a source is supported, then this path can point to a block device
    /// </summary>
    /// <value>The full path to the volume on the node For alpha, this path must be a directory Once block as a source is supported, then this path can point to a block device</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1LocalVolumeSource {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
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
