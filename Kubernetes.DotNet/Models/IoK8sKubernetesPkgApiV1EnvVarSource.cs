using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// EnvVarSource represents a source for the value of an EnvVar.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1EnvVarSource {
    /// <summary>
    /// Selects a key of a ConfigMap.
    /// </summary>
    /// <value>Selects a key of a ConfigMap.</value>
    [DataMember(Name="configMapKeyRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configMapKeyRef")]
    public IoK8sKubernetesPkgApiV1ConfigMapKeySelector ConfigMapKeyRef { get; set; }

    /// <summary>
    /// Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
    /// </summary>
    /// <value>Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.</value>
    [DataMember(Name="fieldRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldRef")]
    public IoK8sKubernetesPkgApiV1ObjectFieldSelector FieldRef { get; set; }

    /// <summary>
    /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.
    /// </summary>
    /// <value>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</value>
    [DataMember(Name="resourceFieldRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceFieldRef")]
    public IoK8sKubernetesPkgApiV1ResourceFieldSelector ResourceFieldRef { get; set; }

    /// <summary>
    /// Selects a key of a secret in the pod's namespace
    /// </summary>
    /// <value>Selects a key of a secret in the pod's namespace</value>
    [DataMember(Name="secretKeyRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secretKeyRef")]
    public IoK8sKubernetesPkgApiV1SecretKeySelector SecretKeyRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1EnvVarSource {\n");
      sb.Append("  ConfigMapKeyRef: ").Append(ConfigMapKeyRef).Append("\n");
      sb.Append("  FieldRef: ").Append(FieldRef).Append("\n");
      sb.Append("  ResourceFieldRef: ").Append(ResourceFieldRef).Append("\n");
      sb.Append("  SecretKeyRef: ").Append(SecretKeyRef).Append("\n");
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
