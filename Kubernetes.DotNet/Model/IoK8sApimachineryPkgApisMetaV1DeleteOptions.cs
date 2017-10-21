using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// DeleteOptions may be provided when deleting an API object.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1DeleteOptions {
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
    /// </summary>
    /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.
    /// </summary>
    /// <value>The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</value>
    [DataMember(Name="gracePeriodSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gracePeriodSeconds")]
    public long? GracePeriodSeconds { get; set; }

    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both.
    /// </summary>
    /// <value>Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both.</value>
    [DataMember(Name="orphanDependents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orphanDependents")]
    public bool? OrphanDependents { get; set; }

    /// <summary>
    /// Must be fulfilled before a deletion is carried out. If not possible, a 409 Conflict status will be returned.
    /// </summary>
    /// <value>Must be fulfilled before a deletion is carried out. If not possible, a 409 Conflict status will be returned.</value>
    [DataMember(Name="preconditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preconditions")]
    public IoK8sApimachineryPkgApisMetaV1Preconditions Preconditions { get; set; }

    /// <summary>
    /// Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.
    /// </summary>
    /// <value>Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</value>
    [DataMember(Name="propagationPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propagationPolicy")]
    public string PropagationPolicy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1DeleteOptions {\n");
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      sb.Append("  GracePeriodSeconds: ").Append(GracePeriodSeconds).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  OrphanDependents: ").Append(OrphanDependents).Append("\n");
      sb.Append("  Preconditions: ").Append(Preconditions).Append("\n");
      sb.Append("  PropagationPolicy: ").Append(PropagationPolicy).Append("\n");
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
