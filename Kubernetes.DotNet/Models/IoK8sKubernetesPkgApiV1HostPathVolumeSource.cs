using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents a host path mapped into a pod. Host path volumes do not support ownership management or SELinux relabeling.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1HostPathVolumeSource {
    /// <summary>
    /// Path of the directory on the host. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
    /// </summary>
    /// <value>Path of the directory on the host. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1HostPathVolumeSource {\n");
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
