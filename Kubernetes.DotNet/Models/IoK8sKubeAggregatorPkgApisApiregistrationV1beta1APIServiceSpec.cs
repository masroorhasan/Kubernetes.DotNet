using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// APIServiceSpec contains information for locating and communicating with a server. Only https is supported, though you are able to disable certificate verification.
  /// </summary>
  [DataContract]
  public class IoK8sKubeAggregatorPkgApisApiregistrationV1beta1APIServiceSpec {
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate an API server's serving certificate.
    /// </summary>
    /// <value>CABundle is a PEM encoded CA bundle which will be used to validate an API server's serving certificate.</value>
    [DataMember(Name="caBundle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "caBundle")]
    public byte[] CaBundle { get; set; }

    /// <summary>
    /// Group is the API group name this server hosts
    /// </summary>
    /// <value>Group is the API group name this server hosts</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// GroupPriorityMininum is the priority this group should have at least. Higher priority means that the group is prefered by clients over lower priority ones. Note that other versions of this group might specify even higher GroupPriorityMininum values such that the whole group gets a higher priority. The primary sort is based on GroupPriorityMinimum, ordered highest number to lowest (20 before 10). The secondary sort is based on the alphabetical comparison of the name of the object.  (v1.bar before v1.foo) We'd recommend something like: *.k8s.io (except extensions) at 18000 and PaaSes (OpenShift, Deis) are recommended to be in the 2000s
    /// </summary>
    /// <value>GroupPriorityMininum is the priority this group should have at least. Higher priority means that the group is prefered by clients over lower priority ones. Note that other versions of this group might specify even higher GroupPriorityMininum values such that the whole group gets a higher priority. The primary sort is based on GroupPriorityMinimum, ordered highest number to lowest (20 before 10). The secondary sort is based on the alphabetical comparison of the name of the object.  (v1.bar before v1.foo) We'd recommend something like: *.k8s.io (except extensions) at 18000 and PaaSes (OpenShift, Deis) are recommended to be in the 2000s</value>
    [DataMember(Name="groupPriorityMinimum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupPriorityMinimum")]
    public int? GroupPriorityMinimum { get; set; }

    /// <summary>
    /// InsecureSkipTLSVerify disables TLS certificate verification when communicating with this server. This is strongly discouraged.  You should use the CABundle instead.
    /// </summary>
    /// <value>InsecureSkipTLSVerify disables TLS certificate verification when communicating with this server. This is strongly discouraged.  You should use the CABundle instead.</value>
    [DataMember(Name="insecureSkipTLSVerify", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insecureSkipTLSVerify")]
    public bool? InsecureSkipTLSVerify { get; set; }

    /// <summary>
    /// Service is a reference to the service for this API server.  It must communicate on port 443 If the Service is nil, that means the handling for the API groupversion is handled locally on this server. The call will simply delegate to the normal handler chain to be fulfilled.
    /// </summary>
    /// <value>Service is a reference to the service for this API server.  It must communicate on port 443 If the Service is nil, that means the handling for the API groupversion is handled locally on this server. The call will simply delegate to the normal handler chain to be fulfilled.</value>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public IoK8sKubeAggregatorPkgApisApiregistrationV1beta1ServiceReference Service { get; set; }

    /// <summary>
    /// Version is the API version this server hosts.  For example, \"v1\"
    /// </summary>
    /// <value>Version is the API version this server hosts.  For example, \"v1\"</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// VersionPriority controls the ordering of this API version inside of its group.  Must be greater than zero. The primary sort is based on VersionPriority, ordered highest to lowest (20 before 10). The secondary sort is based on the alphabetical comparison of the name of the object.  (v1.bar before v1.foo) Since it's inside of a group, the number can be small, probably in the 10s.
    /// </summary>
    /// <value>VersionPriority controls the ordering of this API version inside of its group.  Must be greater than zero. The primary sort is based on VersionPriority, ordered highest to lowest (20 before 10). The secondary sort is based on the alphabetical comparison of the name of the object.  (v1.bar before v1.foo) Since it's inside of a group, the number can be small, probably in the 10s.</value>
    [DataMember(Name="versionPriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionPriority")]
    public int? VersionPriority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubeAggregatorPkgApisApiregistrationV1beta1APIServiceSpec {\n");
      sb.Append("  CaBundle: ").Append(CaBundle).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  GroupPriorityMinimum: ").Append(GroupPriorityMinimum).Append("\n");
      sb.Append("  InsecureSkipTLSVerify: ").Append(InsecureSkipTLSVerify).Append("\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  VersionPriority: ").Append(VersionPriority).Append("\n");
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
