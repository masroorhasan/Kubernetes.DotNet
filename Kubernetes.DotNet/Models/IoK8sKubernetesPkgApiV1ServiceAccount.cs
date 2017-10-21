using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ServiceAccount binds together: * a name, understood by users, and perhaps by peripheral systems, for an identity * a principal that can be authenticated and authorized * a set of secrets
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ServiceAccount {
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
    /// </summary>
    /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// AutomountServiceAccountToken indicates whether pods running as this service account should have an API token automatically mounted. Can be overridden at the pod level.
    /// </summary>
    /// <value>AutomountServiceAccountToken indicates whether pods running as this service account should have an API token automatically mounted. Can be overridden at the pod level.</value>
    [DataMember(Name="automountServiceAccountToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "automountServiceAccountToken")]
    public bool? AutomountServiceAccountToken { get; set; }

    /// <summary>
    /// ImagePullSecrets is a list of references to secrets in the same namespace to use for pulling any images in pods that reference this ServiceAccount. ImagePullSecrets are distinct from Secrets because Secrets can be mounted in the pod, but ImagePullSecrets are only accessed by the kubelet. More info: https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod
    /// </summary>
    /// <value>ImagePullSecrets is a list of references to secrets in the same namespace to use for pulling any images in pods that reference this ServiceAccount. ImagePullSecrets are distinct from Secrets because Secrets can be mounted in the pod, but ImagePullSecrets are only accessed by the kubelet. More info: https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod</value>
    [DataMember(Name="imagePullSecrets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imagePullSecrets")]
    public List<IoK8sKubernetesPkgApiV1LocalObjectReference> ImagePullSecrets { get; set; }

    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
    /// </summary>
    /// <value>Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public IoK8sApimachineryPkgApisMetaV1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Secrets is the list of secrets allowed to be used by pods running using this ServiceAccount. More info: https://kubernetes.io/docs/concepts/configuration/secret
    /// </summary>
    /// <value>Secrets is the list of secrets allowed to be used by pods running using this ServiceAccount. More info: https://kubernetes.io/docs/concepts/configuration/secret</value>
    [DataMember(Name="secrets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secrets")]
    public List<IoK8sKubernetesPkgApiV1ObjectReference> Secrets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ServiceAccount {\n");
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      sb.Append("  AutomountServiceAccountToken: ").Append(AutomountServiceAccountToken).Append("\n");
      sb.Append("  ImagePullSecrets: ").Append(ImagePullSecrets).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Secrets: ").Append(Secrets).Append("\n");
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
