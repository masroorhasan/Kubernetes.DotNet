using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// SELinux  Strategy Options defines the strategy type and any options used to create the strategy.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1SELinuxStrategyOptions {
    /// <summary>
    /// type is the strategy that will dictate the allowable labels that may be set.
    /// </summary>
    /// <value>type is the strategy that will dictate the allowable labels that may be set.</value>
    [DataMember(Name="rule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule")]
    public string Rule { get; set; }

    /// <summary>
    /// seLinuxOptions required to run as; required for MustRunAs More info: https://git.k8s.io/community/contributors/design-proposals/security_context.md
    /// </summary>
    /// <value>seLinuxOptions required to run as; required for MustRunAs More info: https://git.k8s.io/community/contributors/design-proposals/security_context.md</value>
    [DataMember(Name="seLinuxOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seLinuxOptions")]
    public IoK8sKubernetesPkgApiV1SELinuxOptions SeLinuxOptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1SELinuxStrategyOptions {\n");
      sb.Append("  Rule: ").Append(Rule).Append("\n");
      sb.Append("  SeLinuxOptions: ").Append(SeLinuxOptions).Append("\n");
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
