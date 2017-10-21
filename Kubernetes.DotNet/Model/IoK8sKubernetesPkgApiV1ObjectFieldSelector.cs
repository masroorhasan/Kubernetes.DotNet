using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ObjectFieldSelector selects an APIVersioned field of an object.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ObjectFieldSelector {
    /// <summary>
    /// Version of the schema the FieldPath is written in terms of, defaults to \"v1\".
    /// </summary>
    /// <value>Version of the schema the FieldPath is written in terms of, defaults to \"v1\".</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// Path of the field to select in the specified API version.
    /// </summary>
    /// <value>Path of the field to select in the specified API version.</value>
    [DataMember(Name="fieldPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldPath")]
    public string FieldPath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ObjectFieldSelector {\n");
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      sb.Append("  FieldPath: ").Append(FieldPath).Append("\n");
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
