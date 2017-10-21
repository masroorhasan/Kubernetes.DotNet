using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// RawExtension is used to hold extensions in external versions.  To use this, make a field which has RawExtension as its type in your external, versioned struct, and Object in your internal struct. You also need to register your various plugin types.  // Internal package: type MyAPIObject struct {  runtime.TypeMeta &#x60;json:\&quot;,inline\&quot;&#x60;  MyPlugin runtime.Object &#x60;json:\&quot;myPlugin\&quot;&#x60; } type PluginA struct {  AOption string &#x60;json:\&quot;aOption\&quot;&#x60; }  // External package: type MyAPIObject struct {  runtime.TypeMeta &#x60;json:\&quot;,inline\&quot;&#x60;  MyPlugin runtime.RawExtension &#x60;json:\&quot;myPlugin\&quot;&#x60; } type PluginA struct {  AOption string &#x60;json:\&quot;aOption\&quot;&#x60; }  // On the wire, the JSON will look something like this: {  \&quot;kind\&quot;:\&quot;MyAPIObject\&quot;,  \&quot;apiVersion\&quot;:\&quot;v1\&quot;,  \&quot;myPlugin\&quot;: {   \&quot;kind\&quot;:\&quot;PluginA\&quot;,   \&quot;aOption\&quot;:\&quot;foo\&quot;,  }, }  So what happens? Decode first uses json or yaml to unmarshal the serialized data into your external MyAPIObject. That causes the raw JSON to be stored, but not unpacked. The next step is to copy (using pkg/conversion) into the internal struct. The runtime package&#39;s DefaultScheme has conversion functions installed which will unpack the JSON stored in RawExtension, turning it into the correct object type, and storing it in the Object. (TODO: In the case where the object is of an unknown type, a runtime.Unknown object will be created and stored.)
  /// </summary>
  [DataContract]
  public class IoK8sApimachineryPkgRuntimeRawExtension {
    /// <summary>
    /// Raw is the underlying serialization of this object.
    /// </summary>
    /// <value>Raw is the underlying serialization of this object.</value>
    [DataMember(Name="Raw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Raw")]
    public byte[] Raw { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sApimachineryPkgRuntimeRawExtension {\n");
      sb.Append("  Raw: ").Append(Raw).Append("\n");
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
