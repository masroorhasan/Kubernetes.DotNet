using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// SubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReviewSpec {
    /// <summary>
    /// Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.
    /// </summary>
    /// <value>Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.</value>
    [DataMember(Name="extra", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extra")]
    public Dictionary<string, List<string>> Extra { get; set; }

    /// <summary>
    /// Groups is the groups you're testing for.
    /// </summary>
    /// <value>Groups is the groups you're testing for.</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public List<string> Group { get; set; }

    /// <summary>
    /// NonResourceAttributes describes information for a non-resource access request
    /// </summary>
    /// <value>NonResourceAttributes describes information for a non-resource access request</value>
    [DataMember(Name="nonResourceAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonResourceAttributes")]
    public IoK8sKubernetesPkgApisAuthorizationV1beta1NonResourceAttributes NonResourceAttributes { get; set; }

    /// <summary>
    /// ResourceAuthorizationAttributes describes information for a resource access request
    /// </summary>
    /// <value>ResourceAuthorizationAttributes describes information for a resource access request</value>
    [DataMember(Name="resourceAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceAttributes")]
    public IoK8sKubernetesPkgApisAuthorizationV1beta1ResourceAttributes ResourceAttributes { get; set; }

    /// <summary>
    /// User is the user you're testing for. If you specify \"User\" but not \"Group\", then is it interpreted as \"What if User were not a member of any groups
    /// </summary>
    /// <value>User is the user you're testing for. If you specify \"User\" but not \"Group\", then is it interpreted as \"What if User were not a member of any groups</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public string User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReviewSpec {\n");
      sb.Append("  Extra: ").Append(Extra).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  NonResourceAttributes: ").Append(NonResourceAttributes).Append("\n");
      sb.Append("  ResourceAttributes: ").Append(ResourceAttributes).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
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
