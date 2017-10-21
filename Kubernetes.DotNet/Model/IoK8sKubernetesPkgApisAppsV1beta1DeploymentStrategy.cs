using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// DeploymentStrategy describes how to replace existing pods with new ones.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAppsV1beta1DeploymentStrategy {
    /// <summary>
    /// Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.
    /// </summary>
    /// <value>Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.</value>
    [DataMember(Name="rollingUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rollingUpdate")]
    public IoK8sKubernetesPkgApisAppsV1beta1RollingUpdateDeployment RollingUpdate { get; set; }

    /// <summary>
    /// Type of deployment. Can be \"Recreate\" or \"RollingUpdate\". Default is RollingUpdate.
    /// </summary>
    /// <value>Type of deployment. Can be \"Recreate\" or \"RollingUpdate\". Default is RollingUpdate.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAppsV1beta1DeploymentStrategy {\n");
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
