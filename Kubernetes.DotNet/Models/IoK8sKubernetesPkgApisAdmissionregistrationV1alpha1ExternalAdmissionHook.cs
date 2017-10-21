using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ExternalAdmissionHook describes an external admission webhook and the resources and operations it applies to.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1ExternalAdmissionHook {
    /// <summary>
    /// ClientConfig defines how to communicate with the hook. Required
    /// </summary>
    /// <value>ClientConfig defines how to communicate with the hook. Required</value>
    [DataMember(Name="clientConfig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientConfig")]
    public IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1AdmissionHookClientConfig ClientConfig { get; set; }

    /// <summary>
    /// FailurePolicy defines how unrecognized errors from the admission endpoint are handled - allowed values are Ignore or Fail. Defaults to Ignore.
    /// </summary>
    /// <value>FailurePolicy defines how unrecognized errors from the admission endpoint are handled - allowed values are Ignore or Fail. Defaults to Ignore.</value>
    [DataMember(Name="failurePolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failurePolicy")]
    public string FailurePolicy { get; set; }

    /// <summary>
    /// The name of the external admission webhook. Name should be fully qualified, e.g., imagepolicy.kubernetes.io, where \"imagepolicy\" is the name of the webhook, and kubernetes.io is the name of the organization. Required.
    /// </summary>
    /// <value>The name of the external admission webhook. Name should be fully qualified, e.g., imagepolicy.kubernetes.io, where \"imagepolicy\" is the name of the webhook, and kubernetes.io is the name of the organization. Required.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Rules describes what operations on what resources/subresources the webhook cares about. The webhook cares about an operation if it matches _any_ Rule.
    /// </summary>
    /// <value>Rules describes what operations on what resources/subresources the webhook cares about. The webhook cares about an operation if it matches _any_ Rule.</value>
    [DataMember(Name="rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rules")]
    public List<IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1RuleWithOperations> Rules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1ExternalAdmissionHook {\n");
      sb.Append("  ClientConfig: ").Append(ClientConfig).Append("\n");
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
