using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// RoleRef contains information that points to the role being used
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisRbacV1alpha1RoleRef {
    /// <summary>
    /// APIGroup is the group for the resource being referenced
    /// </summary>
    /// <value>APIGroup is the group for the resource being referenced</value>
    [DataMember(Name="apiGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiGroup")]
    public string ApiGroup { get; set; }

    /// <summary>
    /// Kind is the type of resource being referenced
    /// </summary>
    /// <value>Kind is the type of resource being referenced</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Name is the name of resource being referenced
    /// </summary>
    /// <value>Name is the name of resource being referenced</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisRbacV1alpha1RoleRef {\n");
      sb.Append("  ApiGroup: ").Append(ApiGroup).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
