using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// EndpointSubset is a group of addresses with a common set of ports. The expanded set of endpoints is the Cartesian product of Addresses x Ports. For example, given:   {     Addresses: [{\&quot;ip\&quot;: \&quot;10.10.1.1\&quot;}, {\&quot;ip\&quot;: \&quot;10.10.2.2\&quot;}],     Ports:     [{\&quot;name\&quot;: \&quot;a\&quot;, \&quot;port\&quot;: 8675}, {\&quot;name\&quot;: \&quot;b\&quot;, \&quot;port\&quot;: 309}]   } The resulting set of endpoints can be viewed as:     a: [ 10.10.1.1:8675, 10.10.2.2:8675 ],     b: [ 10.10.1.1:309, 10.10.2.2:309 ]
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1EndpointSubset {
    /// <summary>
    /// IP addresses which offer the related ports that are marked as ready. These endpoints should be considered safe for load balancers and clients to utilize.
    /// </summary>
    /// <value>IP addresses which offer the related ports that are marked as ready. These endpoints should be considered safe for load balancers and clients to utilize.</value>
    [DataMember(Name="addresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addresses")]
    public List<IoK8sKubernetesPkgApiV1EndpointAddress> Addresses { get; set; }

    /// <summary>
    /// IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.
    /// </summary>
    /// <value>IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.</value>
    [DataMember(Name="notReadyAddresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notReadyAddresses")]
    public List<IoK8sKubernetesPkgApiV1EndpointAddress> NotReadyAddresses { get; set; }

    /// <summary>
    /// Port numbers available on the related IP addresses.
    /// </summary>
    /// <value>Port numbers available on the related IP addresses.</value>
    [DataMember(Name="ports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ports")]
    public List<IoK8sKubernetesPkgApiV1EndpointPort> Ports { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1EndpointSubset {\n");
      sb.Append("  Addresses: ").Append(Addresses).Append("\n");
      sb.Append("  NotReadyAddresses: ").Append(NotReadyAddresses).Append("\n");
      sb.Append("  Ports: ").Append(Ports).Append("\n");
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
