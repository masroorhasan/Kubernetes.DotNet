using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Describe a container image
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ContainerImage {
    /// <summary>
    /// Names by which this image is known. e.g. [\"gcr.io/google_containers/hyperkube:v1.0.7\", \"dockerhub.io/google_containers/hyperkube:v1.0.7\"]
    /// </summary>
    /// <value>Names by which this image is known. e.g. [\"gcr.io/google_containers/hyperkube:v1.0.7\", \"dockerhub.io/google_containers/hyperkube:v1.0.7\"]</value>
    [DataMember(Name="names", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "names")]
    public List<string> Names { get; set; }

    /// <summary>
    /// The size of the image in bytes.
    /// </summary>
    /// <value>The size of the image in bytes.</value>
    [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sizeBytes")]
    public long? SizeBytes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ContainerImage {\n");
      sb.Append("  Names: ").Append(Names).Append("\n");
      sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
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
