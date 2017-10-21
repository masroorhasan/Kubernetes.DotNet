using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Info contains versioning information. how we&#39;ll want to distribute that information.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgVersionInfo {
    /// <summary>
    /// Gets or Sets BuildDate
    /// </summary>
    [DataMember(Name="buildDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildDate")]
    public string BuildDate { get; set; }

    /// <summary>
    /// Gets or Sets Compiler
    /// </summary>
    [DataMember(Name="compiler", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compiler")]
    public string Compiler { get; set; }

    /// <summary>
    /// Gets or Sets GitCommit
    /// </summary>
    [DataMember(Name="gitCommit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gitCommit")]
    public string GitCommit { get; set; }

    /// <summary>
    /// Gets or Sets GitTreeState
    /// </summary>
    [DataMember(Name="gitTreeState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gitTreeState")]
    public string GitTreeState { get; set; }

    /// <summary>
    /// Gets or Sets GitVersion
    /// </summary>
    [DataMember(Name="gitVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gitVersion")]
    public string GitVersion { get; set; }

    /// <summary>
    /// Gets or Sets GoVersion
    /// </summary>
    [DataMember(Name="goVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "goVersion")]
    public string GoVersion { get; set; }

    /// <summary>
    /// Gets or Sets Major
    /// </summary>
    [DataMember(Name="major", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "major")]
    public string Major { get; set; }

    /// <summary>
    /// Gets or Sets Minor
    /// </summary>
    [DataMember(Name="minor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minor")]
    public string Minor { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platform")]
    public string Platform { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgVersionInfo {\n");
      sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
      sb.Append("  Compiler: ").Append(Compiler).Append("\n");
      sb.Append("  GitCommit: ").Append(GitCommit).Append("\n");
      sb.Append("  GitTreeState: ").Append(GitTreeState).Append("\n");
      sb.Append("  GitVersion: ").Append(GitVersion).Append("\n");
      sb.Append("  GoVersion: ").Append(GoVersion).Append("\n");
      sb.Append("  Major: ").Append(Major).Append("\n");
      sb.Append("  Minor: ").Append(Minor).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
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
