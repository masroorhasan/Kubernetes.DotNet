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
  public class IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetUpdateStrategy {
    /// <summary>
    /// Rolling update config params. Present only if type = \"RollingUpdate\".
    /// </summary>
    /// <value>Rolling update config params. Present only if type = \"RollingUpdate\".</value>
    [DataMember(Name="rollingUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rollingUpdate")]
    public IoK8sKubernetesPkgApisExtensionsV1beta1RollingUpdateDaemonSet RollingUpdate { get; set; }

    /// <summary>
    /// Type of daemon set update. Can be \"RollingUpdate\" or \"OnDelete\". Default is OnDelete.
    /// </summary>
    /// <value>Type of daemon set update. Can be \"RollingUpdate\" or \"OnDelete\". Default is OnDelete.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetUpdateStrategy {\n");
      sb.Append("  RollingUpdate: ").Append(RollingUpdate).Append("\n");
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
