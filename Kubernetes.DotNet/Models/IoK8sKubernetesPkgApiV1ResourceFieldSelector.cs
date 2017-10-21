using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ResourceFieldSelector represents container resources (cpu, memory) and their output format
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ResourceFieldSelector {
    /// <summary>
    /// Container name: required for volumes, optional for env vars
    /// </summary>
    /// <value>Container name: required for volumes, optional for env vars</value>
    [DataMember(Name="containerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerName")]
    public string ContainerName { get; set; }

    /// <summary>
    /// Specifies the output format of the exposed resources, defaults to \"1\"
    /// </summary>
    /// <value>Specifies the output format of the exposed resources, defaults to \"1\"</value>
    [DataMember(Name="divisor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "divisor")]
    public IoK8sApimachineryPkgApiResourceQuantity Divisor { get; set; }

    /// <summary>
    /// Required: resource to select
    /// </summary>
    /// <value>Required: resource to select</value>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ResourceFieldSelector {\n");
      sb.Append("  ContainerName: ").Append(ContainerName).Append("\n");
      sb.Append("  Divisor: ").Append(Divisor).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
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
