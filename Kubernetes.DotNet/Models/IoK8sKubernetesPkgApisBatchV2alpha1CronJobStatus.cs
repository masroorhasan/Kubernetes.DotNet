using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// CronJobStatus represents the current state of a cron job.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisBatchV2alpha1CronJobStatus {
    /// <summary>
    /// A list of pointers to currently running jobs.
    /// </summary>
    /// <value>A list of pointers to currently running jobs.</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public List<IoK8sKubernetesPkgApiV1ObjectReference> Active { get; set; }

    /// <summary>
    /// Information when was the last time the job was successfully scheduled.
    /// </summary>
    /// <value>Information when was the last time the job was successfully scheduled.</value>
    [DataMember(Name="lastScheduleTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastScheduleTime")]
    public IoK8sApimachineryPkgApisMetaV1Time LastScheduleTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisBatchV2alpha1CronJobStatus {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  LastScheduleTime: ").Append(LastScheduleTime).Append("\n");
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
