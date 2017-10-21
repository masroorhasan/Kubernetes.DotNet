using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ServiceReference holds a reference to Service.legacy.k8s.io
  /// </summary>
  [DataContract]
  public class IoK8sKubeAggregatorPkgApisApiregistrationV1beta1ServiceReference {
    /// <summary>
    /// Name is the name of the service
    /// </summary>
    /// <value>Name is the name of the service</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the service
    /// </summary>
    /// <value>Namespace is the namespace of the service</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespace")]
    public string _Namespace { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubeAggregatorPkgApisApiregistrationV1beta1ServiceReference {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
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
