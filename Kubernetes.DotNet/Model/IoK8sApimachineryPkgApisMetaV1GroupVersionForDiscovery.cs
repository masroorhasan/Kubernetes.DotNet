using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// GroupVersion contains the \&quot;group/version\&quot; and \&quot;version\&quot; string of a version. It is made a struct to keep extensibility.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1GroupVersionForDiscovery {
    /// <summary>
    /// groupVersion specifies the API group and version in the form \"group/version\"
    /// </summary>
    /// <value>groupVersion specifies the API group and version in the form \"group/version\"</value>
    [DataMember(Name="groupVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupVersion")]
    public string GroupVersion { get; set; }

    /// <summary>
    /// version specifies the version in the form of \"version\". This is to save the clients the trouble of splitting the GroupVersion.
    /// </summary>
    /// <value>version specifies the version in the form of \"version\". This is to save the clients the trouble of splitting the GroupVersion.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1GroupVersionForDiscovery {\n");
      sb.Append("  GroupVersion: ").Append(GroupVersion).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
