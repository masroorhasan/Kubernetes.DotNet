using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// EnvFromSource represents the source of a set of ConfigMaps
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1EnvFromSource {
    /// <summary>
    /// The ConfigMap to select from
    /// </summary>
    /// <value>The ConfigMap to select from</value>
    [DataMember(Name="configMapRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configMapRef")]
    public IoK8sKubernetesPkgApiV1ConfigMapEnvSource ConfigMapRef { get; set; }

    /// <summary>
    /// An optional identifer to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.
    /// </summary>
    /// <value>An optional identifer to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</value>
    [DataMember(Name="prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefix")]
    public string Prefix { get; set; }

    /// <summary>
    /// The Secret to select from
    /// </summary>
    /// <value>The Secret to select from</value>
    [DataMember(Name="secretRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secretRef")]
    public IoK8sKubernetesPkgApiV1SecretEnvSource SecretRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1EnvFromSource {\n");
      sb.Append("  ConfigMapRef: ").Append(ConfigMapRef).Append("\n");
      sb.Append("  Prefix: ").Append(Prefix).Append("\n");
      sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
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
