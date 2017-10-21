using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// UserInfo holds the information about the user needed to implement the user.Info interface.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAuthenticationV1UserInfo {
    /// <summary>
    /// Any additional information provided by the authenticator.
    /// </summary>
    /// <value>Any additional information provided by the authenticator.</value>
    [DataMember(Name="extra", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extra")]
    public Dictionary<string, List<string>> Extra { get; set; }

    /// <summary>
    /// The names of groups this user is a part of.
    /// </summary>
    /// <value>The names of groups this user is a part of.</value>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.
    /// </summary>
    /// <value>A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.</value>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uid")]
    public string Uid { get; set; }

    /// <summary>
    /// The name that uniquely identifies this user among all active users.
    /// </summary>
    /// <value>The name that uniquely identifies this user among all active users.</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAuthenticationV1UserInfo {\n");
      sb.Append("  Extra: ").Append(Extra).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
