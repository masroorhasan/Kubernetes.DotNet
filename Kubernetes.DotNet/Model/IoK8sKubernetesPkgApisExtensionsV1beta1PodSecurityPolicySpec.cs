using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Pod Security Policy Spec defines the policy enforced.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicySpec {
    /// <summary>
    /// AllowedCapabilities is a list of capabilities that can be requested to add to the container. Capabilities in this field may be added at the pod author's discretion. You must not list a capability in both AllowedCapabilities and RequiredDropCapabilities.
    /// </summary>
    /// <value>AllowedCapabilities is a list of capabilities that can be requested to add to the container. Capabilities in this field may be added at the pod author's discretion. You must not list a capability in both AllowedCapabilities and RequiredDropCapabilities.</value>
    [DataMember(Name="allowedCapabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedCapabilities")]
    public List<string> AllowedCapabilities { get; set; }

    /// <summary>
    /// DefaultAddCapabilities is the default set of capabilities that will be added to the container unless the pod spec specifically drops the capability.  You may not list a capabiility in both DefaultAddCapabilities and RequiredDropCapabilities.
    /// </summary>
    /// <value>DefaultAddCapabilities is the default set of capabilities that will be added to the container unless the pod spec specifically drops the capability.  You may not list a capabiility in both DefaultAddCapabilities and RequiredDropCapabilities.</value>
    [DataMember(Name="defaultAddCapabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultAddCapabilities")]
    public List<string> DefaultAddCapabilities { get; set; }

    /// <summary>
    /// FSGroup is the strategy that will dictate what fs group is used by the SecurityContext.
    /// </summary>
    /// <value>FSGroup is the strategy that will dictate what fs group is used by the SecurityContext.</value>
    [DataMember(Name="fsGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fsGroup")]
    public IoK8sKubernetesPkgApisExtensionsV1beta1FSGroupStrategyOptions FsGroup { get; set; }

    /// <summary>
    /// hostIPC determines if the policy allows the use of HostIPC in the pod spec.
    /// </summary>
    /// <value>hostIPC determines if the policy allows the use of HostIPC in the pod spec.</value>
    [DataMember(Name="hostIPC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostIPC")]
    public bool? HostIPC { get; set; }

    /// <summary>
    /// hostNetwork determines if the policy allows the use of HostNetwork in the pod spec.
    /// </summary>
    /// <value>hostNetwork determines if the policy allows the use of HostNetwork in the pod spec.</value>
    [DataMember(Name="hostNetwork", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary>
    /// hostPID determines if the policy allows the use of HostPID in the pod spec.
    /// </summary>
    /// <value>hostPID determines if the policy allows the use of HostPID in the pod spec.</value>
    [DataMember(Name="hostPID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostPID")]
    public bool? HostPID { get; set; }

    /// <summary>
    /// hostPorts determines which host port ranges are allowed to be exposed.
    /// </summary>
    /// <value>hostPorts determines which host port ranges are allowed to be exposed.</value>
    [DataMember(Name="hostPorts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostPorts")]
    public List<IoK8sKubernetesPkgApisExtensionsV1beta1HostPortRange> HostPorts { get; set; }

    /// <summary>
    /// privileged determines if a pod can request to be run as privileged.
    /// </summary>
    /// <value>privileged determines if a pod can request to be run as privileged.</value>
    [DataMember(Name="privileged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privileged")]
    public bool? Privileged { get; set; }

    /// <summary>
    /// ReadOnlyRootFilesystem when set to true will force containers to run with a read only root file system.  If the container specifically requests to run with a non-read only root file system the PSP should deny the pod. If set to false the container may run with a read only root file system if it wishes but it will not be forced to.
    /// </summary>
    /// <value>ReadOnlyRootFilesystem when set to true will force containers to run with a read only root file system.  If the container specifically requests to run with a non-read only root file system the PSP should deny the pod. If set to false the container may run with a read only root file system if it wishes but it will not be forced to.</value>
    [DataMember(Name="readOnlyRootFilesystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    /// <summary>
    /// RequiredDropCapabilities are the capabilities that will be dropped from the container.  These are required to be dropped and cannot be added.
    /// </summary>
    /// <value>RequiredDropCapabilities are the capabilities that will be dropped from the container.  These are required to be dropped and cannot be added.</value>
    [DataMember(Name="requiredDropCapabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredDropCapabilities")]
    public List<string> RequiredDropCapabilities { get; set; }

    /// <summary>
    /// runAsUser is the strategy that will dictate the allowable RunAsUser values that may be set.
    /// </summary>
    /// <value>runAsUser is the strategy that will dictate the allowable RunAsUser values that may be set.</value>
    [DataMember(Name="runAsUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runAsUser")]
    public IoK8sKubernetesPkgApisExtensionsV1beta1RunAsUserStrategyOptions RunAsUser { get; set; }

    /// <summary>
    /// seLinux is the strategy that will dictate the allowable labels that may be set.
    /// </summary>
    /// <value>seLinux is the strategy that will dictate the allowable labels that may be set.</value>
    [DataMember(Name="seLinux", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seLinux")]
    public IoK8sKubernetesPkgApisExtensionsV1beta1SELinuxStrategyOptions SeLinux { get; set; }

    /// <summary>
    /// SupplementalGroups is the strategy that will dictate what supplemental groups are used by the SecurityContext.
    /// </summary>
    /// <value>SupplementalGroups is the strategy that will dictate what supplemental groups are used by the SecurityContext.</value>
    [DataMember(Name="supplementalGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplementalGroups")]
    public IoK8sKubernetesPkgApisExtensionsV1beta1SupplementalGroupsStrategyOptions SupplementalGroups { get; set; }

    /// <summary>
    /// volumes is a white list of allowed volume plugins.  Empty indicates that all plugins may be used.
    /// </summary>
    /// <value>volumes is a white list of allowed volume plugins.  Empty indicates that all plugins may be used.</value>
    [DataMember(Name="volumes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumes")]
    public List<string> Volumes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicySpec {\n");
      sb.Append("  AllowedCapabilities: ").Append(AllowedCapabilities).Append("\n");
      sb.Append("  DefaultAddCapabilities: ").Append(DefaultAddCapabilities).Append("\n");
      sb.Append("  FsGroup: ").Append(FsGroup).Append("\n");
      sb.Append("  HostIPC: ").Append(HostIPC).Append("\n");
      sb.Append("  HostNetwork: ").Append(HostNetwork).Append("\n");
      sb.Append("  HostPID: ").Append(HostPID).Append("\n");
      sb.Append("  HostPorts: ").Append(HostPorts).Append("\n");
      sb.Append("  Privileged: ").Append(Privileged).Append("\n");
      sb.Append("  ReadOnlyRootFilesystem: ").Append(ReadOnlyRootFilesystem).Append("\n");
      sb.Append("  RequiredDropCapabilities: ").Append(RequiredDropCapabilities).Append("\n");
      sb.Append("  RunAsUser: ").Append(RunAsUser).Append("\n");
      sb.Append("  SeLinux: ").Append(SeLinux).Append("\n");
      sb.Append("  SupplementalGroups: ").Append(SupplementalGroups).Append("\n");
      sb.Append("  Volumes: ").Append(Volumes).Append("\n");
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
