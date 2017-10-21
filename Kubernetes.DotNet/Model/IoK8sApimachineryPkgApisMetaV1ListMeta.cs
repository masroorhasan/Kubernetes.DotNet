using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1ListMeta {
    /// <summary>
    /// String that identifies the server's internal version of this object that can be used by clients to determine when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    /// <value>String that identifies the server's internal version of this object that can be used by clients to determine when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency</value>
    [DataMember(Name="resourceVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceVersion")]
    public string ResourceVersion { get; set; }

    /// <summary>
    /// SelfLink is a URL representing this object. Populated by the system. Read-only.
    /// </summary>
    /// <value>SelfLink is a URL representing this object. Populated by the system. Read-only.</value>
    [DataMember(Name="selfLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selfLink")]
    public string SelfLink { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1ListMeta {\n");
      sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
      sb.Append("  SelfLink: ").Append(SelfLink).Append("\n");
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
