using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// LoadBalancerStatus represents the status of a load-balancer.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1LoadBalancerStatus {
    /// <summary>
    /// Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.
    /// </summary>
    /// <value>Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.</value>
    [DataMember(Name="ingress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ingress")]
    public List<IoK8sKubernetesPkgApiV1LoadBalancerIngress> Ingress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1LoadBalancerStatus {\n");
      sb.Append("  Ingress: ").Append(Ingress).Append("\n");
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
