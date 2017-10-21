using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NamespaceSpec describes the attributes on a Namespace.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NamespaceSpec {
    /// <summary>
    /// Finalizers is an opaque list of values that must be empty to permanently remove object from storage. More info: https://git.k8s.io/community/contributors/design-proposals/namespaces.md#finalizers
    /// </summary>
    /// <value>Finalizers is an opaque list of values that must be empty to permanently remove object from storage. More info: https://git.k8s.io/community/contributors/design-proposals/namespaces.md#finalizers</value>
    [DataMember(Name="finalizers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finalizers")]
    public List<string> Finalizers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NamespaceSpec {\n");
      sb.Append("  Finalizers: ").Append(Finalizers).Append("\n");
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
