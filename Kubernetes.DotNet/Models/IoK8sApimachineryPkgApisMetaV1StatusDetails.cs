using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// StatusDetails is a set of additional properties that MAY be set by the server to provide additional information about a response. The Reason field of a Status object defines what attributes will be set. Clients must ignore fields that do not match the defined type of each attribute, and should assume that any attribute may be empty, invalid, or under defined.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1StatusDetails {
    /// <summary>
    /// The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.
    /// </summary>
    /// <value>The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.</value>
    [DataMember(Name="causes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "causes")]
    public List<IoK8sApimachineryPkgApisMetaV1StatusCause> Causes { get; set; }

    /// <summary>
    /// The group attribute of the resource associated with the status StatusReason.
    /// </summary>
    /// <value>The group attribute of the resource associated with the status StatusReason.</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).
    /// </summary>
    /// <value>The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// If specified, the time in seconds before the operation should be retried.
    /// </summary>
    /// <value>If specified, the time in seconds before the operation should be retried.</value>
    [DataMember(Name="retryAfterSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retryAfterSeconds")]
    public int? RetryAfterSeconds { get; set; }

    /// <summary>
    /// UID of the resource. (when there is a single resource which can be described). More info: http://kubernetes.io/docs/user-guide/identifiers#uids
    /// </summary>
    /// <value>UID of the resource. (when there is a single resource which can be described). More info: http://kubernetes.io/docs/user-guide/identifiers#uids</value>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uid")]
    public string Uid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1StatusDetails {\n");
      sb.Append("  Causes: ").Append(Causes).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RetryAfterSeconds: ").Append(RetryAfterSeconds).Append("\n");
      sb.Append("  Uid: ").Append(Uid).Append("\n");
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
