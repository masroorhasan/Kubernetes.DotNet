using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// NodeSystemInfo is a set of ids/uuids to uniquely identify the node.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1NodeSystemInfo {
    /// <summary>
    /// The Architecture reported by the node
    /// </summary>
    /// <value>The Architecture reported by the node</value>
    [DataMember(Name="architecture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "architecture")]
    public string Architecture { get; set; }

    /// <summary>
    /// Boot ID reported by the node.
    /// </summary>
    /// <value>Boot ID reported by the node.</value>
    [DataMember(Name="bootID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bootID")]
    public string BootID { get; set; }

    /// <summary>
    /// ContainerRuntime Version reported by the node through runtime remote API (e.g. docker://1.5.0).
    /// </summary>
    /// <value>ContainerRuntime Version reported by the node through runtime remote API (e.g. docker://1.5.0).</value>
    [DataMember(Name="containerRuntimeVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerRuntimeVersion")]
    public string ContainerRuntimeVersion { get; set; }

    /// <summary>
    /// Kernel Version reported by the node from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).
    /// </summary>
    /// <value>Kernel Version reported by the node from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).</value>
    [DataMember(Name="kernelVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kernelVersion")]
    public string KernelVersion { get; set; }

    /// <summary>
    /// KubeProxy Version reported by the node.
    /// </summary>
    /// <value>KubeProxy Version reported by the node.</value>
    [DataMember(Name="kubeProxyVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kubeProxyVersion")]
    public string KubeProxyVersion { get; set; }

    /// <summary>
    /// Kubelet Version reported by the node.
    /// </summary>
    /// <value>Kubelet Version reported by the node.</value>
    [DataMember(Name="kubeletVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kubeletVersion")]
    public string KubeletVersion { get; set; }

    /// <summary>
    /// MachineID reported by the node. For unique machine identification in the cluster this field is preferred. Learn more from man(5) machine-id: http://man7.org/linux/man-pages/man5/machine-id.5.html
    /// </summary>
    /// <value>MachineID reported by the node. For unique machine identification in the cluster this field is preferred. Learn more from man(5) machine-id: http://man7.org/linux/man-pages/man5/machine-id.5.html</value>
    [DataMember(Name="machineID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "machineID")]
    public string MachineID { get; set; }

    /// <summary>
    /// The Operating System reported by the node
    /// </summary>
    /// <value>The Operating System reported by the node</value>
    [DataMember(Name="operatingSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operatingSystem")]
    public string OperatingSystem { get; set; }

    /// <summary>
    /// OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).
    /// </summary>
    /// <value>OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).</value>
    [DataMember(Name="osImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osImage")]
    public string OsImage { get; set; }

    /// <summary>
    /// SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html
    /// </summary>
    /// <value>SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html</value>
    [DataMember(Name="systemUUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systemUUID")]
    public string SystemUUID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1NodeSystemInfo {\n");
      sb.Append("  Architecture: ").Append(Architecture).Append("\n");
      sb.Append("  BootID: ").Append(BootID).Append("\n");
      sb.Append("  ContainerRuntimeVersion: ").Append(ContainerRuntimeVersion).Append("\n");
      sb.Append("  KernelVersion: ").Append(KernelVersion).Append("\n");
      sb.Append("  KubeProxyVersion: ").Append(KubeProxyVersion).Append("\n");
      sb.Append("  KubeletVersion: ").Append(KubeletVersion).Append("\n");
      sb.Append("  MachineID: ").Append(MachineID).Append("\n");
      sb.Append("  OperatingSystem: ").Append(OperatingSystem).Append("\n");
      sb.Append("  OsImage: ").Append(OsImage).Append("\n");
      sb.Append("  SystemUUID: ").Append(SystemUUID).Append("\n");
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
