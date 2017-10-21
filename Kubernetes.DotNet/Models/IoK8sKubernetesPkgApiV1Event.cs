using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Event is a report of an event somewhere in the cluster.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1Event {
    /// <summary>
    /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
    /// </summary>
    /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// The number of times this event has occurred.
    /// </summary>
    /// <value>The number of times this event has occurred.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)
    /// </summary>
    /// <value>The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)</value>
    [DataMember(Name="firstTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstTimestamp")]
    // public IoK8sApimachineryPkgApisMetaV1Time FirstTimestamp { get; set; }
    public DateTime FirstTimestamp { get; set; }

    /// <summary>
    /// The object that this event is about.
    /// </summary>
    /// <value>The object that this event is about.</value>
    [DataMember(Name="involvedObject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "involvedObject")]
    public IoK8sKubernetesPkgApiV1ObjectReference InvolvedObject { get; set; }

    /// <summary>
    /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
    /// </summary>
    /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// The time at which the most recent occurrence of this event was recorded.
    /// </summary>
    /// <value>The time at which the most recent occurrence of this event was recorded.</value>
    [DataMember(Name="lastTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTimestamp")]
    // public IoK8sApimachineryPkgApisMetaV1Time LastTimestamp { get; set; }
    public DateTime LastTimestamp { get; set; }

    /// <summary>
    /// A human-readable description of the status of this operation.
    /// </summary>
    /// <value>A human-readable description of the status of this operation.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
    /// </summary>
    /// <value>Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public IoK8sApimachineryPkgApisMetaV1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// This should be a short, machine understandable string that gives the reason for the transition into the object's current status.
    /// </summary>
    /// <value>This should be a short, machine understandable string that gives the reason for the transition into the object's current status.</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The component reporting this event. Should be a short machine understandable string.
    /// </summary>
    /// <value>The component reporting this event. Should be a short machine understandable string.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public IoK8sKubernetesPkgApiV1EventSource Source { get; set; }

    /// <summary>
    /// Type of this event (Normal, Warning), new types could be added in the future
    /// </summary>
    /// <value>Type of this event (Normal, Warning), new types could be added in the future</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1Event {\n");
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  FirstTimestamp: ").Append(FirstTimestamp).Append("\n");
      sb.Append("  InvolvedObject: ").Append(InvolvedObject).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
