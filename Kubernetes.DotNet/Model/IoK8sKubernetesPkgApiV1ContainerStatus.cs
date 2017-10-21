using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ContainerStatus contains details for the current status of this container.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ContainerStatus {
    /// <summary>
    /// Container's ID in the format 'docker://<container_id>'.
    /// </summary>
    /// <value>Container's ID in the format 'docker://<container_id>'.</value>
    [DataMember(Name="containerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerID")]
    public string ContainerID { get; set; }

    /// <summary>
    /// The image the container is running. More info: https://kubernetes.io/docs/concepts/containers/images
    /// </summary>
    /// <value>The image the container is running. More info: https://kubernetes.io/docs/concepts/containers/images</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// ImageID of the container's image.
    /// </summary>
    /// <value>ImageID of the container's image.</value>
    [DataMember(Name="imageID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageID")]
    public string ImageID { get; set; }

    /// <summary>
    /// Details about the container's last termination condition.
    /// </summary>
    /// <value>Details about the container's last termination condition.</value>
    [DataMember(Name="lastState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastState")]
    public IoK8sKubernetesPkgApiV1ContainerState LastState { get; set; }

    /// <summary>
    /// This must be a DNS_LABEL. Each container in a pod must have a unique name. Cannot be updated.
    /// </summary>
    /// <value>This must be a DNS_LABEL. Each container in a pod must have a unique name. Cannot be updated.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Specifies whether the container has passed its readiness probe.
    /// </summary>
    /// <value>Specifies whether the container has passed its readiness probe.</value>
    [DataMember(Name="ready", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ready")]
    public bool? Ready { get; set; }

    /// <summary>
    /// The number of times the container has been restarted, currently based on the number of dead containers that have not yet been removed. Note that this is calculated from dead containers. But those containers are subject to garbage collection. This value will get capped at 5 by GC.
    /// </summary>
    /// <value>The number of times the container has been restarted, currently based on the number of dead containers that have not yet been removed. Note that this is calculated from dead containers. But those containers are subject to garbage collection. This value will get capped at 5 by GC.</value>
    [DataMember(Name="restartCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restartCount")]
    public int? RestartCount { get; set; }

    /// <summary>
    /// Details about the container's current condition.
    /// </summary>
    /// <value>Details about the container's current condition.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public IoK8sKubernetesPkgApiV1ContainerState State { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ContainerStatus {\n");
      sb.Append("  ContainerID: ").Append(ContainerID).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  ImageID: ").Append(ImageID).Append("\n");
      sb.Append("  LastState: ").Append(LastState).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Ready: ").Append(Ready).Append("\n");
      sb.Append("  RestartCount: ").Append(RestartCount).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
