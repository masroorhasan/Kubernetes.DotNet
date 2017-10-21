using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1AzureFileVolumeSource {
    /// <summary>
    /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
    /// </summary>
    /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }

    /// <summary>
    /// the name of secret that contains Azure Storage Account Name and Key
    /// </summary>
    /// <value>the name of secret that contains Azure Storage Account Name and Key</value>
    [DataMember(Name="secretName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secretName")]
    public string SecretName { get; set; }

    /// <summary>
    /// Share Name
    /// </summary>
    /// <value>Share Name</value>
    [DataMember(Name="shareName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shareName")]
    public string ShareName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1AzureFileVolumeSource {\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("  SecretName: ").Append(SecretName).Append("\n");
      sb.Append("  ShareName: ").Append(ShareName).Append("\n");
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
