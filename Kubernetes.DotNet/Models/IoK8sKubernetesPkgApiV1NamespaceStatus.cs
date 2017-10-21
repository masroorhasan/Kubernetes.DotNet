using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NamespaceStatus is information about the current status of a Namespace.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NamespaceStatus {
    /// <summary>
    /// Phase is the current lifecycle phase of the namespace. More info: https://git.k8s.io/community/contributors/design-proposals/namespaces.md#phases
    /// </summary>
    /// <value>Phase is the current lifecycle phase of the namespace. More info: https://git.k8s.io/community/contributors/design-proposals/namespaces.md#phases</value>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phase")]
    public string Phase { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NamespaceStatus {\n");
      sb.Append("  Phase: ").Append(Phase).Append("\n");
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
