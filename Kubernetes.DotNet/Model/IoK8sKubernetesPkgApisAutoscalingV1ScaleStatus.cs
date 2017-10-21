using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ScaleStatus represents the current status of a scale subresource.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAutoscalingV1ScaleStatus {
    /// <summary>
    /// actual number of observed instances of the scaled object.
    /// </summary>
    /// <value>actual number of observed instances of the scaled object.</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replicas")]
    public int? Replicas { get; set; }

    /// <summary>
    /// label query over pods that should match the replicas count. This is same as the label selector but in the string format to avoid introspection by clients. The string will be in the same format as the query-param syntax. More info about label selectors: http://kubernetes.io/docs/user-guide/labels#label-selectors
    /// </summary>
    /// <value>label query over pods that should match the replicas count. This is same as the label selector but in the string format to avoid introspection by clients. The string will be in the same format as the query-param syntax. More info about label selectors: http://kubernetes.io/docs/user-guide/labels#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public string Selector { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAutoscalingV1ScaleStatus {\n");
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
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
