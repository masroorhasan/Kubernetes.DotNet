using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Projection that may be projected along with other supported volume types
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1VolumeProjection {
    /// <summary>
    /// information about the configMap data to project
    /// </summary>
    /// <value>information about the configMap data to project</value>
    [DataMember(Name="configMap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configMap")]
    public IoK8sKubernetesPkgApiV1ConfigMapProjection ConfigMap { get; set; }

    /// <summary>
    /// information about the downwardAPI data to project
    /// </summary>
    /// <value>information about the downwardAPI data to project</value>
    [DataMember(Name="downwardAPI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "downwardAPI")]
    public IoK8sKubernetesPkgApiV1DownwardAPIProjection DownwardAPI { get; set; }

    /// <summary>
    /// information about the secret data to project
    /// </summary>
    /// <value>information about the secret data to project</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public IoK8sKubernetesPkgApiV1SecretProjection Secret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1VolumeProjection {\n");
      sb.Append("  ConfigMap: ").Append(ConfigMap).Append("\n");
      sb.Append("  DownwardAPI: ").Append(DownwardAPI).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
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
