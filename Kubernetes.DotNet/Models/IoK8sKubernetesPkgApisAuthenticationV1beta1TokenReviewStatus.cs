using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// TokenReviewStatus is the result of the token authentication request.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReviewStatus {
    /// <summary>
    /// Authenticated indicates that the token was associated with a known user.
    /// </summary>
    /// <value>Authenticated indicates that the token was associated with a known user.</value>
    [DataMember(Name="authenticated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticated")]
    public bool? Authenticated { get; set; }

    /// <summary>
    /// Error indicates that the token couldn't be checked
    /// </summary>
    /// <value>Error indicates that the token couldn't be checked</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// User is the UserInfo associated with the provided token.
    /// </summary>
    /// <value>User is the UserInfo associated with the provided token.</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public IoK8sKubernetesPkgApisAuthenticationV1beta1UserInfo User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReviewStatus {\n");
      sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
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
