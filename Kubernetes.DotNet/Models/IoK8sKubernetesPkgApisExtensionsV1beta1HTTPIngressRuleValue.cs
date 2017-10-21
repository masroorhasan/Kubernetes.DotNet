using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// HTTPIngressRuleValue is a list of http selectors pointing to backends. In the example: http://&lt;host&gt;/&lt;path&gt;?&lt;searchpart&gt; -&gt; backend where where parts of the url correspond to RFC 3986, this resource will be used to match against everything after the last &#39;/&#39; and before the first &#39;?&#39; or &#39;#&#39;.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1HTTPIngressRuleValue {
    /// <summary>
    /// A collection of paths that map requests to backends.
    /// </summary>
    /// <value>A collection of paths that map requests to backends.</value>
    [DataMember(Name="paths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paths")]
    public List<IoK8sKubernetesPkgApisExtensionsV1beta1HTTPIngressPath> Paths { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1HTTPIngressRuleValue {\n");
      sb.Append("  Paths: ").Append(Paths).Append("\n");
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
