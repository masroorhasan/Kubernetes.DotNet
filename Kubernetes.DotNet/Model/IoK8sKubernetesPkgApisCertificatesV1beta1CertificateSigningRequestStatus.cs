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
  public class IoK8sKubernetesPkgApisCertificatesV1beta1CertificateSigningRequestStatus {
    /// <summary>
    /// If request was approved, the controller will place the issued certificate here.
    /// </summary>
    /// <value>If request was approved, the controller will place the issued certificate here.</value>
    [DataMember(Name="certificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "certificate")]
    public byte[] Certificate { get; set; }

    /// <summary>
    /// Conditions applied to the request, such as approval or denial.
    /// </summary>
    /// <value>Conditions applied to the request, such as approval or denial.</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<IoK8sKubernetesPkgApisCertificatesV1beta1CertificateSigningRequestCondition> Conditions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisCertificatesV1beta1CertificateSigningRequestStatus {\n");
      sb.Append("  Certificate: ").Append(Certificate).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
