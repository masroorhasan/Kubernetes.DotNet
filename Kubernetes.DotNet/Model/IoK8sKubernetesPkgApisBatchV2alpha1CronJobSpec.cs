using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// CronJobSpec describes how the job execution will look like and when it will actually run.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisBatchV2alpha1CronJobSpec {
    /// <summary>
    /// Specifies how to treat concurrent executions of a Job. Defaults to Allow.
    /// </summary>
    /// <value>Specifies how to treat concurrent executions of a Job. Defaults to Allow.</value>
    [DataMember(Name="concurrencyPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "concurrencyPolicy")]
    public string ConcurrencyPolicy { get; set; }

    /// <summary>
    /// The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
    /// </summary>
    /// <value>The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.</value>
    [DataMember(Name="failedJobsHistoryLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failedJobsHistoryLimit")]
    public int? FailedJobsHistoryLimit { get; set; }

    /// <summary>
    /// Specifies the job that will be created when executing a CronJob.
    /// </summary>
    /// <value>Specifies the job that will be created when executing a CronJob.</value>
    [DataMember(Name="jobTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobTemplate")]
    public IoK8sKubernetesPkgApisBatchV2alpha1JobTemplateSpec JobTemplate { get; set; }

    /// <summary>
    /// The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.
    /// </summary>
    /// <value>The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.</value>
    [DataMember(Name="schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedule")]
    public string Schedule { get; set; }

    /// <summary>
    /// Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.
    /// </summary>
    /// <value>Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.</value>
    [DataMember(Name="startingDeadlineSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startingDeadlineSeconds")]
    public long? StartingDeadlineSeconds { get; set; }

    /// <summary>
    /// The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
    /// </summary>
    /// <value>The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.</value>
    [DataMember(Name="successfulJobsHistoryLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successfulJobsHistoryLimit")]
    public int? SuccessfulJobsHistoryLimit { get; set; }

    /// <summary>
    /// This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.
    /// </summary>
    /// <value>This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.</value>
    [DataMember(Name="suspend", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspend")]
    public bool? Suspend { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisBatchV2alpha1CronJobSpec {\n");
      sb.Append("  ConcurrencyPolicy: ").Append(ConcurrencyPolicy).Append("\n");
      sb.Append("  FailedJobsHistoryLimit: ").Append(FailedJobsHistoryLimit).Append("\n");
      sb.Append("  JobTemplate: ").Append(JobTemplate).Append("\n");
      sb.Append("  Schedule: ").Append(Schedule).Append("\n");
      sb.Append("  StartingDeadlineSeconds: ").Append(StartingDeadlineSeconds).Append("\n");
      sb.Append("  SuccessfulJobsHistoryLimit: ").Append(SuccessfulJobsHistoryLimit).Append("\n");
      sb.Append("  Suspend: ").Append(Suspend).Append("\n");
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
