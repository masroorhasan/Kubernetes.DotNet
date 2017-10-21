using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// APIResource specifies the name of a resource and whether it is namespaced.
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgApisMetaV1APIResource {
    /// <summary>
    /// categories is a list of the grouped resources this resource belongs to (e.g. 'all')
    /// </summary>
    /// <value>categories is a list of the grouped resources this resource belongs to (e.g. 'all')</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<string> Categories { get; set; }

    /// <summary>
    /// kind is the kind for the resource (e.g. 'Foo' is the kind for a resource 'foo')
    /// </summary>
    /// <value>kind is the kind for the resource (e.g. 'Foo' is the kind for a resource 'foo')</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// name is the plural name of the resource.
    /// </summary>
    /// <value>name is the plural name of the resource.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// namespaced indicates if a resource is namespaced or not.
    /// </summary>
    /// <value>namespaced indicates if a resource is namespaced or not.</value>
    [DataMember(Name="namespaced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespaced")]
    public bool? Namespaced { get; set; }

    /// <summary>
    /// shortNames is a list of suggested short names of the resource.
    /// </summary>
    /// <value>shortNames is a list of suggested short names of the resource.</value>
    [DataMember(Name="shortNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortNames")]
    public List<string> ShortNames { get; set; }

    /// <summary>
    /// singularName is the singular name of the resource.  This allows clients to handle plural and singular opaquely. The singularName is more correct for reporting status on a single item and both singular and plural are allowed from the kubectl CLI interface.
    /// </summary>
    /// <value>singularName is the singular name of the resource.  This allows clients to handle plural and singular opaquely. The singularName is more correct for reporting status on a single item and both singular and plural are allowed from the kubectl CLI interface.</value>
    [DataMember(Name="singularName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "singularName")]
    public string SingularName { get; set; }

    /// <summary>
    /// verbs is a list of supported kube verbs (this includes get, list, watch, create, update, patch, delete, deletecollection, and proxy)
    /// </summary>
    /// <value>verbs is a list of supported kube verbs (this includes get, list, watch, create, update, patch, delete, deletecollection, and proxy)</value>
    [DataMember(Name="verbs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verbs")]
    public List<string> Verbs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgApisMetaV1APIResource {\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Namespaced: ").Append(Namespaced).Append("\n");
      sb.Append("  ShortNames: ").Append(ShortNames).Append("\n");
      sb.Append("  SingularName: ").Append(SingularName).Append("\n");
      sb.Append("  Verbs: ").Append(Verbs).Append("\n");
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
