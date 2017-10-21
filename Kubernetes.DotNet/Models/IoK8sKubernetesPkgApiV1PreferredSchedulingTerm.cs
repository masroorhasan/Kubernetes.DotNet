using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it&#39;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PreferredSchedulingTerm {
    /// <summary>
    /// A node selector term, associated with the corresponding weight.
    /// </summary>
    /// <value>A node selector term, associated with the corresponding weight.</value>
    [DataMember(Name="preference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preference")]
    public IoK8sKubernetesPkgApiV1NodeSelectorTerm Preference { get; set; }

    /// <summary>
    /// Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
    /// </summary>
    /// <value>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public int? Weight { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PreferredSchedulingTerm {\n");
      sb.Append("  Preference: ").Append(Preference).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
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
