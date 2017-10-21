using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisAuthorizationV1beta1ResourceAttributes {
    /// <summary>
    /// Group is the API Group of the Resource.  \"*\" means all.
    /// </summary>
    /// <value>Group is the API Group of the Resource.  \"*\" means all.</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// Name is the name of the resource being requested for a \"get\" or deleted for a \"delete\". \"\" (empty) means all.
    /// </summary>
    /// <value>Name is the name of the resource being requested for a \"get\" or deleted for a \"delete\". \"\" (empty) means all.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the action being requested.  Currently, there is no distinction between no namespace and all namespaces \"\" (empty) is defaulted for LocalSubjectAccessReviews \"\" (empty) is empty for cluster-scoped resources \"\" (empty) means \"all\" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview
    /// </summary>
    /// <value>Namespace is the namespace of the action being requested.  Currently, there is no distinction between no namespace and all namespaces \"\" (empty) is defaulted for LocalSubjectAccessReviews \"\" (empty) is empty for cluster-scoped resources \"\" (empty) means \"all\" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespace")]
    public string _Namespace { get; set; }

    /// <summary>
    /// Resource is one of the existing resource types.  \"*\" means all.
    /// </summary>
    /// <value>Resource is one of the existing resource types.  \"*\" means all.</value>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }

    /// <summary>
    /// Subresource is one of the existing resource types.  \"\" means none.
    /// </summary>
    /// <value>Subresource is one of the existing resource types.  \"\" means none.</value>
    [DataMember(Name="subresource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subresource")]
    public string Subresource { get; set; }

    /// <summary>
    /// Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.  \"*\" means all.
    /// </summary>
    /// <value>Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.  \"*\" means all.</value>
    [DataMember(Name="verb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verb")]
    public string Verb { get; set; }

    /// <summary>
    /// Version is the API Version of the Resource.  \"*\" means all.
    /// </summary>
    /// <value>Version is the API Version of the Resource.  \"*\" means all.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisAuthorizationV1beta1ResourceAttributes {\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
      sb.Append("  Subresource: ").Append(Subresource).Append("\n");
      sb.Append("  Verb: ").Append(Verb).Append("\n");
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
