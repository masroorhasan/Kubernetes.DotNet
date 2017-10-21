using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Represents an empty directory for a pod. Empty directory volumes support ownership management and SELinux relabeling.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1EmptyDirVolumeSource {
    /// <summary>
    /// What type of storage medium should back this directory. The default is \"\" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
    /// </summary>
    /// <value>What type of storage medium should back this directory. The default is \"\" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir</value>
    [DataMember(Name="medium", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medium")]
    public string Medium { get; set; }

    /// <summary>
    /// Total amount of local storage required for this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: http://kubernetes.io/docs/user-guide/volumes#emptydir
    /// </summary>
    /// <value>Total amount of local storage required for this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: http://kubernetes.io/docs/user-guide/volumes#emptydir</value>
    [DataMember(Name="sizeLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sizeLimit")]
    public IoK8sApimachineryPkgApiResourceQuantity SizeLimit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1EmptyDirVolumeSource {\n");
      sb.Append("  Medium: ").Append(Medium).Append("\n");
      sb.Append("  SizeLimit: ").Append(SizeLimit).Append("\n");
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
