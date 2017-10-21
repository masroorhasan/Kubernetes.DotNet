using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents downward API info for projecting into a projected volume. Note that this is identical to a downwardAPI volume source without the default mode.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1DownwardAPIProjection {
    /// <summary>
    /// Items is a list of DownwardAPIVolume file
    /// </summary>
    /// <value>Items is a list of DownwardAPIVolume file</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<IoK8sKubernetesPkgApiV1DownwardAPIVolumeFile> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1DownwardAPIProjection {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
