using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// AdmissionHookClientConfig contains the information to make a TLS connection with the webhook
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1AdmissionHookClientConfig {
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate webhook's server certificate. Required
    /// </summary>
    /// <value>CABundle is a PEM encoded CA bundle which will be used to validate webhook's server certificate. Required</value>
    [DataMember(Name="caBundle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "caBundle")]
    public byte[] CaBundle { get; set; }

    /// <summary>
    /// Service is a reference to the service for this webhook. If there is only one port open for the service, that port will be used. If there are multiple ports open, port 443 will be used if it is open, otherwise it is an error. Required
    /// </summary>
    /// <value>Service is a reference to the service for this webhook. If there is only one port open for the service, that port will be used. If there are multiple ports open, port 443 will be used if it is open, otherwise it is an error. Required</value>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1ServiceReference Service { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1AdmissionHookClientConfig {\n");
      sb.Append("  CaBundle: ").Append(CaBundle).Append("\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
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
