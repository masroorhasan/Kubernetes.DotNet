using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// This information is immutable after the request is created. Only the Request and Usages fields can be set on creation, other fields are derived by Kubernetes and cannot be modified by users.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisCertificatesV1beta1CertificateSigningRequestSpec {
    /// <summary>
    /// Extra information about the requesting user. See user.Info interface for details.
    /// </summary>
    /// <value>Extra information about the requesting user. See user.Info interface for details.</value>
    [DataMember(Name="extra", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extra")]
    public Dictionary<string, List<string>> Extra { get; set; }

    /// <summary>
    /// Group information about the requesting user. See user.Info interface for details.
    /// </summary>
    /// <value>Group information about the requesting user. See user.Info interface for details.</value>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// Base64-encoded PKCS#10 CSR data
    /// </summary>
    /// <value>Base64-encoded PKCS#10 CSR data</value>
    [DataMember(Name="request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request")]
    public byte[] Request { get; set; }

    /// <summary>
    /// UID information about the requesting user. See user.Info interface for details.
    /// </summary>
    /// <value>UID information about the requesting user. See user.Info interface for details.</value>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uid")]
    public string Uid { get; set; }

    /// <summary>
    /// allowedUsages specifies a set of usage contexts the key will be valid for. See: https://tools.ietf.org/html/rfc5280#section-4.2.1.3      https://tools.ietf.org/html/rfc5280#section-4.2.1.12
    /// </summary>
    /// <value>allowedUsages specifies a set of usage contexts the key will be valid for. See: https://tools.ietf.org/html/rfc5280#section-4.2.1.3      https://tools.ietf.org/html/rfc5280#section-4.2.1.12</value>
    [DataMember(Name="usages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usages")]
    public List<string> Usages { get; set; }

    /// <summary>
    /// Information about the requesting user. See user.Info interface for details.
    /// </summary>
    /// <value>Information about the requesting user. See user.Info interface for details.</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisCertificatesV1beta1CertificateSigningRequestSpec {\n");
      sb.Append("  Extra: ").Append(Extra).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Request: ").Append(Request).Append("\n");
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      sb.Append("  Usages: ").Append(Usages).Append("\n");
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
