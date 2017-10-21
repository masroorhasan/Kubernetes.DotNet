using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// JobStatus represents the current state of a Job.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisBatchV1JobStatus {
    /// <summary>
    /// The number of actively running pods.
    /// </summary>
    /// <value>The number of actively running pods.</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public int? Active { get; set; }

    /// <summary>
    /// Represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.
    /// </summary>
    /// <value>Represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.</value>
    [DataMember(Name="completionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionTime")]
    public IoK8sApimachineryPkgApisMetaV1Time CompletionTime { get; set; }

    /// <summary>
    /// The latest available observations of an object's current state. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
    /// </summary>
    /// <value>The latest available observations of an object's current state. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</value>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<IoK8sKubernetesPkgApisBatchV1JobCondition> Conditions { get; set; }

    /// <summary>
    /// The number of pods which reached phase Failed.
    /// </summary>
    /// <value>The number of pods which reached phase Failed.</value>
    [DataMember(Name="failed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed")]
    public int? Failed { get; set; }

    /// <summary>
    /// Represents time when the job was acknowledged by the job controller. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.
    /// </summary>
    /// <value>Represents time when the job was acknowledged by the job controller. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    // public IoK8sApimachineryPkgApisMetaV1Time StartTime { get; set; }
    public DateTime StartTime { get; set; }

    /// <summary>
    /// The number of pods which reached phase Succeeded.
    /// </summary>
    /// <value>The number of pods which reached phase Succeeded.</value>
    [DataMember(Name="succeeded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "succeeded")]
    public int? Succeeded { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisBatchV1JobStatus {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  CompletionTime: ").Append(CompletionTime).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  Failed: ").Append(Failed).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
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
