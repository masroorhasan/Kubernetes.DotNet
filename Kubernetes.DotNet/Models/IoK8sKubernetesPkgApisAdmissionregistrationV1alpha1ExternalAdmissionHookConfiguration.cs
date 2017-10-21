using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ExternalAdmissionHookConfiguration describes the configuration of initializers.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1ExternalAdmissionHookConfiguration {
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
    /// </summary>
    /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// ExternalAdmissionHooks is a list of external admission webhooks and the affected resources and operations.
    /// </summary>
    /// <value>ExternalAdmissionHooks is a list of external admission webhooks and the affected resources and operations.</value>
    [DataMember(Name="externalAdmissionHooks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalAdmissionHooks")]
    public List<IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1ExternalAdmissionHook> ExternalAdmissionHooks { get; set; }

    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Standard object metadata; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata.
    /// </summary>
    /// <value>Standard object metadata; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata.</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public IoK8sApimachineryPkgApisMetaV1ObjectMeta Metadata { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAdmissionregistrationV1alpha1ExternalAdmissionHookConfiguration {\n");
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      sb.Append("  ExternalAdmissionHooks: ").Append(ExternalAdmissionHooks).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
