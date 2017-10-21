using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// OwnerReference contains enough information to let you identify an owning object. Currently, an owning object must be in the same namespace, so there is no namespace field.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1OwnerReference {
    /// <summary>
    /// API version of the referent.
    /// </summary>
    /// <value>API version of the referent.</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// If true, AND if the owner has the \"foregroundDeletion\" finalizer, then the owner cannot be deleted from the key-value store until this reference is removed. Defaults to false. To set this field, a user needs \"delete\" permission of the owner, otherwise 422 (Unprocessable Entity) will be returned.
    /// </summary>
    /// <value>If true, AND if the owner has the \"foregroundDeletion\" finalizer, then the owner cannot be deleted from the key-value store until this reference is removed. Defaults to false. To set this field, a user needs \"delete\" permission of the owner, otherwise 422 (Unprocessable Entity) will be returned.</value>
    [DataMember(Name="blockOwnerDeletion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blockOwnerDeletion")]
    public bool? BlockOwnerDeletion { get; set; }

    /// <summary>
    /// If true, this reference points to the managing controller.
    /// </summary>
    /// <value>If true, this reference points to the managing controller.</value>
    [DataMember(Name="controller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controller")]
    public bool? Controller { get; set; }

    /// <summary>
    /// Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Name of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#names
    /// </summary>
    /// <value>Name of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#names</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// UID of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#uids
    /// </summary>
    /// <value>UID of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#uids</value>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uid")]
    public string Uid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1OwnerReference {\n");
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      sb.Append("  BlockOwnerDeletion: ").Append(BlockOwnerDeletion).Append("\n");
      sb.Append("  Controller: ").Append(Controller).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
