using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Rule is a tuple of APIGroups, APIVersion, and Resources.It is recommended to make sure that all the tuple expansions are valid.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1Rule {
    /// <summary>
    /// APIGroups is the API groups the resources belong to. '*' is all groups. If '*' is present, the length of the slice must be one. Required.
    /// </summary>
    /// <value>APIGroups is the API groups the resources belong to. '*' is all groups. If '*' is present, the length of the slice must be one. Required.</value>
    [DataMember(Name="apiGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiGroups")]
    public List<string> ApiGroups { get; set; }

    /// <summary>
    /// APIVersions is the API versions the resources belong to. '*' is all versions. If '*' is present, the length of the slice must be one. Required.
    /// </summary>
    /// <value>APIVersions is the API versions the resources belong to. '*' is all versions. If '*' is present, the length of the slice must be one. Required.</value>
    [DataMember(Name="apiVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersions")]
    public List<string> ApiVersions { get; set; }

    /// <summary>
    /// Resources is a list of resources this rule applies to.  For example: 'pods' means pods. 'pods/log' means the log subresource of pods. '*' means all resources, but not subresources. 'pods/_*' means all subresources of pods. '*_/scale' means all scale subresources. '*_/_*' means all resources and their subresources.  If wildcard is present, the validation rule will ensure resources do not overlap with each other.  Depending on the enclosing object, subresources might not be allowed. Required.
    /// </summary>
    /// <value>Resources is a list of resources this rule applies to.  For example: 'pods' means pods. 'pods/log' means the log subresource of pods. '*' means all resources, but not subresources. 'pods/_*' means all subresources of pods. '*_/scale' means all scale subresources. '*_/_*' means all resources and their subresources.  If wildcard is present, the validation rule will ensure resources do not overlap with each other.  Depending on the enclosing object, subresources might not be allowed. Required.</value>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public List<string> Resources { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1Rule {\n");
      sb.Append("  ApiGroups: ").Append(ApiGroups).Append("\n");
      sb.Append("  ApiVersions: ").Append(ApiVersions).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
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
