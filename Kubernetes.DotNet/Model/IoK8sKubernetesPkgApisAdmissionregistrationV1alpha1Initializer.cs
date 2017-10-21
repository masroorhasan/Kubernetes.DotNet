using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Initializer describes the name and the failure policy of an initializer, and what resources it applies to.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1Initializer {
    /// <summary>
    /// FailurePolicy defines what happens if the responsible initializer controller fails to takes action. Allowed values are Ignore, or Fail. If \"Ignore\" is set, initializer is removed from the initializers list of an object if the timeout is reached; If \"Fail\" is set, admissionregistration returns timeout error if the timeout is reached.
    /// </summary>
    /// <value>FailurePolicy defines what happens if the responsible initializer controller fails to takes action. Allowed values are Ignore, or Fail. If \"Ignore\" is set, initializer is removed from the initializers list of an object if the timeout is reached; If \"Fail\" is set, admissionregistration returns timeout error if the timeout is reached.</value>
    [DataMember(Name="failurePolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failurePolicy")]
    public string FailurePolicy { get; set; }

    /// <summary>
    /// Name is the identifier of the initializer. It will be added to the object that needs to be initialized. Name should be fully qualified, e.g., alwayspullimages.kubernetes.io, where \"alwayspullimages\" is the name of the webhook, and kubernetes.io is the name of the organization. Required
    /// </summary>
    /// <value>Name is the identifier of the initializer. It will be added to the object that needs to be initialized. Name should be fully qualified, e.g., alwayspullimages.kubernetes.io, where \"alwayspullimages\" is the name of the webhook, and kubernetes.io is the name of the organization. Required</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Rules describes what resources/subresources the initializer cares about. The initializer cares about an operation if it matches _any_ Rule. Rule.Resources must not include subresources.
    /// </summary>
    /// <value>Rules describes what resources/subresources the initializer cares about. The initializer cares about an operation if it matches _any_ Rule. Rule.Resources must not include subresources.</value>
    [DataMember(Name="rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rules")]
    public List<IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1Rule> Rules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1Initializer {\n");
      sb.Append("  FailurePolicy: ").Append(FailurePolicy).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Rules: ").Append(Rules).Append("\n");
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
