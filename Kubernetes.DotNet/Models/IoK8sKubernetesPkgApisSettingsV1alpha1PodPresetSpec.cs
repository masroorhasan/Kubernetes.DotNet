using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PodPresetSpec is a description of a pod preset.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisSettingsV1alpha1PodPresetSpec {
    /// <summary>
    /// Env defines the collection of EnvVar to inject into containers.
    /// </summary>
    /// <value>Env defines the collection of EnvVar to inject into containers.</value>
    [DataMember(Name="env", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "env")]
    public List<IoK8sKubernetesPkgApiV1EnvVar> Env { get; set; }

    /// <summary>
    /// EnvFrom defines the collection of EnvFromSource to inject into containers.
    /// </summary>
    /// <value>EnvFrom defines the collection of EnvFromSource to inject into containers.</value>
    [DataMember(Name="envFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "envFrom")]
    public List<IoK8sKubernetesPkgApiV1EnvFromSource> EnvFrom { get; set; }

    /// <summary>
    /// Selector is a label query over a set of resources, in this case pods. Required.
    /// </summary>
    /// <value>Selector is a label query over a set of resources, in this case pods. Required.</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector Selector { get; set; }

    /// <summary>
    /// VolumeMounts defines the collection of VolumeMount to inject into containers.
    /// </summary>
    /// <value>VolumeMounts defines the collection of VolumeMount to inject into containers.</value>
    [DataMember(Name="volumeMounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumeMounts")]
    public List<IoK8sKubernetesPkgApiV1VolumeMount> VolumeMounts { get; set; }

    /// <summary>
    /// Volumes defines the collection of Volume to inject into the pod.
    /// </summary>
    /// <value>Volumes defines the collection of Volume to inject into the pod.</value>
    [DataMember(Name="volumes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumes")]
    public List<IoK8sKubernetesPkgApiV1Volume> Volumes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisSettingsV1alpha1PodPresetSpec {\n");
      sb.Append("  Env: ").Append(Env).Append("\n");
      sb.Append("  EnvFrom: ").Append(EnvFrom).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  VolumeMounts: ").Append(VolumeMounts).Append("\n");
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
