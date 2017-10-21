using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// SubjectAccessReviewStatus
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReviewStatus {
    /// <summary>
    /// Allowed is required.  True if the action would be allowed, false otherwise.
    /// </summary>
    /// <value>Allowed is required.  True if the action would be allowed, false otherwise.</value>
    [DataMember(Name="allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed")]
    public bool? Allowed { get; set; }

    /// <summary>
    /// EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request.
    /// </summary>
    /// <value>EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request.</value>
    [DataMember(Name="evaluationError", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "evaluationError")]
    public string EvaluationError { get; set; }

    /// <summary>
    /// Reason is optional.  It indicates why a request was allowed or denied.
    /// </summary>
    /// <value>Reason is optional.  It indicates why a request was allowed or denied.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReviewStatus {\n");
      sb.Append("  Allowed: ").Append(Allowed).Append("\n");
      sb.Append("  EvaluationError: ").Append(EvaluationError).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
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
