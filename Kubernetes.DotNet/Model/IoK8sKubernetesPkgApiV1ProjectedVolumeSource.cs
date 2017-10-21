using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents a projected volume source
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ProjectedVolumeSource {
    /// <summary>
    /// Mode bits to use on created files by default. Must be a value between 0 and 0777. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
    /// </summary>
    /// <value>Mode bits to use on created files by default. Must be a value between 0 and 0777. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</value>
    [DataMember(Name="defaultMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>
    /// list of volume projections
    /// </summary>
    /// <value>list of volume projections</value>
    [DataMember(Name="sources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sources")]
    public List<IoK8sKubernetesPkgApiV1VolumeProjection> Sources { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ProjectedVolumeSource {\n");
      sb.Append("  DefaultMode: ").Append(DefaultMode).Append("\n");
      sb.Append("  Sources: ").Append(Sources).Append("\n");
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
