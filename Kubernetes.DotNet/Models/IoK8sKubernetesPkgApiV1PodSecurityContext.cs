using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodSecurityContext holds pod-level security attributes and common container settings. Some fields are also present in container.securityContext.  Field values of container.securityContext take precedence over field values of PodSecurityContext.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PodSecurityContext {
    /// <summary>
    /// A special supplemental group that applies to all containers in a pod. Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod:  1. The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw- -- -  If unset, the Kubelet will not modify the ownership and permissions of any volume.
    /// </summary>
    /// <value>A special supplemental group that applies to all containers in a pod. Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod:  1. The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw- -- -  If unset, the Kubelet will not modify the ownership and permissions of any volume.</value>
    [DataMember(Name="fsGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsGroup")]
    public long? FsGroup { get; set; }

    /// <summary>
    /// Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
    /// </summary>
    /// <value>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</value>
    [DataMember(Name="runAsNonRoot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>
    /// The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.
    /// </summary>
    /// <value>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.</value>
    [DataMember(Name="runAsUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runAsUser")]
    public long? RunAsUser { get; set; }

    /// <summary>
    /// The SELinux context to be applied to all containers. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.
    /// </summary>
    /// <value>The SELinux context to be applied to all containers. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.</value>
    [DataMember(Name="seLinuxOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seLinuxOptions")]
    public IoK8sKubernetesPkgApiV1SELinuxOptions SeLinuxOptions { get; set; }

    /// <summary>
    /// A list of groups applied to the first process run in each container, in addition to the container's primary GID.  If unspecified, no groups will be added to any container.
    /// </summary>
    /// <value>A list of groups applied to the first process run in each container, in addition to the container's primary GID.  If unspecified, no groups will be added to any container.</value>
    [DataMember(Name="supplementalGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplementalGroups")]
    public List<long?> SupplementalGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1PodSecurityContext {\n");
      sb.Append("  FsGroup: ").Append(FsGroup).Append("\n");
      sb.Append("  RunAsNonRoot: ").Append(RunAsNonRoot).Append("\n");
      sb.Append("  RunAsUser: ").Append(RunAsUser).Append("\n");
      sb.Append("  SeLinuxOptions: ").Append(SeLinuxOptions).Append("\n");
      sb.Append("  SupplementalGroups: ").Append(SupplementalGroups).Append("\n");
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
