using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// SecurityContext holds security configuration that will be applied to a container. Some fields are present in both SecurityContext and PodSecurityContext.  When both are set, the values in SecurityContext take precedence.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1SecurityContext {
    /// <summary>
    /// The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.
    /// </summary>
    /// <value>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.</value>
    [DataMember(Name="capabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capabilities")]
    public IoK8sKubernetesPkgApiV1Capabilities Capabilities { get; set; }

    /// <summary>
    /// Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false.
    /// </summary>
    /// <value>Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false.</value>
    [DataMember(Name="privileged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privileged")]
    public bool? Privileged { get; set; }

    /// <summary>
    /// Whether this container has a read-only root filesystem. Default is false.
    /// </summary>
    /// <value>Whether this container has a read-only root filesystem. Default is false.</value>
    [DataMember(Name="readOnlyRootFilesystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary>
    /// Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
    /// </summary>
    /// <value>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</value>
    [DataMember(Name="runAsNonRoot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>
    /// The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
    /// </summary>
    /// <value>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</value>
    [DataMember(Name="runAsUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary>
    /// The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
    /// </summary>
    /// <value>The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</value>
    [DataMember(Name="seLinuxOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seLinuxOptions")]
    public IoK8sKubernetesPkgApiV1SELinuxOptions SeLinuxOptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1SecurityContext {\n");
      sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
      sb.Append("  Privileged: ").Append(Privileged).Append("\n");
      sb.Append("  ReadOnlyRootFilesystem: ").Append(ReadOnlyRootFilesystem).Append("\n");
      sb.Append("  RunAsNonRoot: ").Append(RunAsNonRoot).Append("\n");
      sb.Append("  RunAsUser: ").Append(RunAsUser).Append("\n");
      sb.Append("  SeLinuxOptions: ").Append(SeLinuxOptions).Append("\n");
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
