using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisCertificatesV1beta1CertificateSigningRequestCondition {
    /// <summary>
    /// timestamp for the last update to this condition
    /// </summary>
    /// <value>timestamp for the last update to this condition</value>
    [DataMember(Name="lastUpdateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdateTime")]
    public IoK8sApimachineryPkgApisMetaV1Time LastUpdateTime { get; set; }

    /// <summary>
    /// human readable message with details about the request state
    /// </summary>
    /// <value>human readable message with details about the request state</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// brief reason for the request state
    /// </summary>
    /// <value>brief reason for the request state</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// request approval state, currently Approved or Denied.
    /// </summary>
    /// <value>request approval state, currently Approved or Denied.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisCertificatesV1beta1CertificateSigningRequestCondition {\n");
      sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
