using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents a Flocker volume mounted by the Flocker agent. One and only one of datasetName and datasetUUID should be set. Flocker volumes do not support ownership management or SELinux relabeling.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1FlockerVolumeSource {
    /// <summary>
    /// Name of the dataset stored as metadata -> name on the dataset for Flocker should be considered as deprecated
    /// </summary>
    /// <value>Name of the dataset stored as metadata -> name on the dataset for Flocker should be considered as deprecated</value>
    [DataMember(Name="datasetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datasetName")]
    public string DatasetName { get; set; }

    /// <summary>
    /// UUID of the dataset. This is unique identifier of a Flocker dataset
    /// </summary>
    /// <value>UUID of the dataset. This is unique identifier of a Flocker dataset</value>
    [DataMember(Name="datasetUUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datasetUUID")]
    public string DatasetUUID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1FlockerVolumeSource {\n");
      sb.Append("  DatasetName: ").Append(DatasetName).Append("\n");
      sb.Append("  DatasetUUID: ").Append(DatasetUUID).Append("\n");
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
