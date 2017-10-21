using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// IngressBackend describes all endpoints for a given service and port.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1IngressBackend {
    /// <summary>
    /// Specifies the name of the referenced service.
    /// </summary>
    /// <value>Specifies the name of the referenced service.</value>
    [DataMember(Name="serviceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Specifies the port of the referenced service.
    /// </summary>
    /// <value>Specifies the port of the referenced service.</value>
    [DataMember(Name="servicePort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "servicePort")]
    public IoK8sApimachineryPkgUtilIntstrIntOrString ServicePort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1IngressBackend {\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ServicePort: ").Append(ServicePort).Append("\n");
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
