using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PolicyRule holds information that describes a policy rule, but does not contain information about who the rule applies to or which namespace the rule applies to.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisRbacV1alpha1PolicyRule {
    /// <summary>
    /// APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.
    /// </summary>
    /// <value>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.</value>
    [DataMember(Name="apiGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiGroups")]
    public List<string> ApiGroups { get; set; }

    /// <summary>
    /// NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path This name is intentionally different than the internal type so that the DefaultConvert works nicely and because the ordering may be different. Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as \"pods\" or \"secrets\") or non-resource URL paths (such as \"/api\"),  but not both.
    /// </summary>
    /// <value>NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path This name is intentionally different than the internal type so that the DefaultConvert works nicely and because the ordering may be different. Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as \"pods\" or \"secrets\") or non-resource URL paths (such as \"/api\"),  but not both.</value>
    [DataMember(Name="nonResourceURLs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonResourceURLs")]
    public List<string> NonResourceURLs { get; set; }

    /// <summary>
    /// ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.
    /// </summary>
    /// <value>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</value>
    [DataMember(Name="resourceNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceNames")]
    public List<string> ResourceNames { get; set; }

    /// <summary>
    /// Resources is a list of resources this rule applies to.  ResourceAll represents all resources.
    /// </summary>
    /// <value>Resources is a list of resources this rule applies to.  ResourceAll represents all resources.</value>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public List<string> Resources { get; set; }

    /// <summary>
    /// Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule.  VerbAll represents all kinds.
    /// </summary>
    /// <value>Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule.  VerbAll represents all kinds.</value>
    [DataMember(Name="verbs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verbs")]
    public List<string> Verbs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisRbacV1alpha1PolicyRule {\n");
      sb.Append("  ApiGroups: ").Append(ApiGroups).Append("\n");
      sb.Append("  NonResourceURLs: ").Append(NonResourceURLs).Append("\n");
      sb.Append("  ResourceNames: ").Append(ResourceNames).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
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
