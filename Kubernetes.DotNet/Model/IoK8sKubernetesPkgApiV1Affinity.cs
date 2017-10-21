using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Affinity is a group of affinity scheduling rules.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1Affinity {
    /// <summary>
    /// Describes node affinity scheduling rules for the pod.
    /// </summary>
    /// <value>Describes node affinity scheduling rules for the pod.</value>
    [DataMember(Name="nodeAffinity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeAffinity")]
    public IoK8sKubernetesPkgApiV1NodeAffinity NodeAffinity { get; set; }

    /// <summary>
    /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
    /// </summary>
    /// <value>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</value>
    [DataMember(Name="podAffinity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podAffinity")]
    public IoK8sKubernetesPkgApiV1PodAffinity PodAffinity { get; set; }

    /// <summary>
    /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
    /// </summary>
    /// <value>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</value>
    [DataMember(Name="podAntiAffinity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "podAntiAffinity")]
    public IoK8sKubernetesPkgApiV1PodAntiAffinity PodAntiAffinity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1Affinity {\n");
      sb.Append("  NodeAffinity: ").Append(NodeAffinity).Append("\n");
      sb.Append("  PodAffinity: ").Append(PodAffinity).Append("\n");
      sb.Append("  PodAntiAffinity: ").Append(PodAntiAffinity).Append("\n");
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
