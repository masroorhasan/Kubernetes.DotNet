using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAuthorizationV1beta1NonResourceAttributes {
    /// <summary>
    /// Path is the URL path of the request
    /// </summary>
    /// <value>Path is the URL path of the request</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Verb is the standard HTTP verb
    /// </summary>
    /// <value>Verb is the standard HTTP verb</value>
    [DataMember(Name="verb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verb")]
    public string Verb { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAuthorizationV1beta1NonResourceAttributes {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Verb: ").Append(Verb).Append("\n");
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
