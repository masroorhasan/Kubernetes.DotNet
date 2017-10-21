using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Initializers tracks the progress of initialization.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1Initializers {
    /// <summary>
    /// Pending is a list of initializers that must execute in order before this object is visible. When the last pending initializer is removed, and no failing result is set, the initializers struct will be set to nil and the object is considered as initialized and visible to all clients.
    /// </summary>
    /// <value>Pending is a list of initializers that must execute in order before this object is visible. When the last pending initializer is removed, and no failing result is set, the initializers struct will be set to nil and the object is considered as initialized and visible to all clients.</value>
    [DataMember(Name="pending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending")]
    public List<IoK8sApimachineryPkgApisMetaV1Initializer> Pending { get; set; }

    /// <summary>
    /// If result is set with the Failure field, the object will be persisted to storage and then deleted, ensuring that other clients can observe the deletion.
    /// </summary>
    /// <value>If result is set with the Failure field, the object will be persisted to storage and then deleted, ensuring that other clients can observe the deletion.</value>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public IoK8sApimachineryPkgApisMetaV1Status Result { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1Initializers {\n");
      sb.Append("  Pending: ").Append(Pending).Append("\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
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
