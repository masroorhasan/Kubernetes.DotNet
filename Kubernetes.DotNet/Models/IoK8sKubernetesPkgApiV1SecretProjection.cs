using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Adapts a secret into a projected volume.  The contents of the target Secret&#39;s Data field will be presented in a projected volume as files using the keys in the Data field as the file names. Note that this is identical to a secret volume source without the default mode.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1SecretProjection {
    /// <summary>
    /// If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.
    /// </summary>
    /// <value>If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<IoK8sKubernetesPkgApiV1KeyToPath> Items { get; set; }

    /// <summary>
    /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    /// <value>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Specify whether the Secret or its key must be defined
    /// </summary>
    /// <value>Specify whether the Secret or its key must be defined</value>
    [DataMember(Name="optional", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optional")]
    public bool? Optional { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1SecretProjection {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Optional: ").Append(Optional).Append("\n");
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
