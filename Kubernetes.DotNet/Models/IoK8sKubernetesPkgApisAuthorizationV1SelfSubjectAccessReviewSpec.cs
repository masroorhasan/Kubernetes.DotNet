using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// SelfSubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAuthorizationV1SelfSubjectAccessReviewSpec {
    /// <summary>
    /// NonResourceAttributes describes information for a non-resource access request
    /// </summary>
    /// <value>NonResourceAttributes describes information for a non-resource access request</value>
    [DataMember(Name="nonResourceAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonResourceAttributes")]
    public IoK8sKubernetesPkgApisAuthorizationV1NonResourceAttributes NonResourceAttributes { get; set; }

    /// <summary>
    /// ResourceAuthorizationAttributes describes information for a resource access request
    /// </summary>
    /// <value>ResourceAuthorizationAttributes describes information for a resource access request</value>
    [DataMember(Name="resourceAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceAttributes")]
    public IoK8sKubernetesPkgApisAuthorizationV1ResourceAttributes ResourceAttributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAuthorizationV1SelfSubjectAccessReviewSpec {\n");
      sb.Append("  NonResourceAttributes: ").Append(NonResourceAttributes).Append("\n");
      sb.Append("  ResourceAttributes: ").Append(ResourceAttributes).Append("\n");
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
