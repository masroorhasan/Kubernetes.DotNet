using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodTemplateList is a list of PodTemplates.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PodTemplateList {
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
    /// </summary>
    /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// List of pod templates
    /// </summary>
    /// <value>List of pod templates</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<IoK8sKubernetesPkgApiV1PodTemplate> Items { get; set; }

    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public IoK8sApimachineryPkgApisMetaV1ListMeta Metadata { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PodTemplateList {\n");
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
