using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ResourceQuotaStatus defines the enforced hard limits and observed use.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ResourceQuotaStatus {
    /// <summary>
    /// Hard is the set of enforced hard limits for each named resource. More info: https://git.k8s.io/community/contributors/design-proposals/admission_control_resource_quota.md
    /// </summary>
    /// <value>Hard is the set of enforced hard limits for each named resource. More info: https://git.k8s.io/community/contributors/design-proposals/admission_control_resource_quota.md</value>
    [DataMember(Name="hard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hard")]
    public Dictionary<string, IoK8sApimachineryPkgApiResourceQuantity> Hard { get; set; }

    /// <summary>
    /// Used is the current observed total usage of the resource in the namespace.
    /// </summary>
    /// <value>Used is the current observed total usage of the resource in the namespace.</value>
    [DataMember(Name="used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "used")]
    public Dictionary<string, IoK8sApimachineryPkgApiResourceQuantity> Used { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ResourceQuotaStatus {\n");
      sb.Append("  Hard: ").Append(Hard).Append("\n");
      sb.Append("  Used: ").Append(Used).Append("\n");
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
