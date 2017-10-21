using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// JobSpec describes how the job execution will look like.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApisBatchV1JobSpec {
    /// <summary>
    /// Optional duration in seconds relative to the startTime that the job may be active before the system tries to terminate it; value must be positive integer
    /// </summary>
    /// <value>Optional duration in seconds relative to the startTime that the job may be active before the system tries to terminate it; value must be positive integer</value>
    [DataMember(Name="activeDeadlineSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activeDeadlineSeconds")]
    public long? ActiveDeadlineSeconds { get; set; }

    /// <summary>
    /// Specifies the desired number of successfully finished pods the job should be run with.  Setting to nil means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
    /// </summary>
    /// <value>Specifies the desired number of successfully finished pods the job should be run with.  Setting to nil means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</value>
    [DataMember(Name="completions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completions")]
    public int? Completions { get; set; }

    /// <summary>
    /// manualSelector controls generation of pod labels and pod selectors. Leave `manualSelector` unset unless you are certain what you are doing. When false or unset, the system pick labels unique to this job and appends those labels to the pod template.  When true, the user is responsible for picking unique labels and specifying the selector.  Failure to pick a unique label may cause this and other jobs to not function correctly.  However, You may see `manualSelector=true` in jobs that were created with the old `extensions/v1beta1` API. More info: https://git.k8s.io/community/contributors/design-proposals/selector-generation.md
    /// </summary>
    /// <value>manualSelector controls generation of pod labels and pod selectors. Leave `manualSelector` unset unless you are certain what you are doing. When false or unset, the system pick labels unique to this job and appends those labels to the pod template.  When true, the user is responsible for picking unique labels and specifying the selector.  Failure to pick a unique label may cause this and other jobs to not function correctly.  However, You may see `manualSelector=true` in jobs that were created with the old `extensions/v1beta1` API. More info: https://git.k8s.io/community/contributors/design-proposals/selector-generation.md</value>
    [DataMember(Name="manualSelector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "manualSelector")]
    public bool? ManualSelector { get; set; }

    /// <summary>
    /// Specifies the maximum desired number of pods the job should run at any given time. The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) < .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
    /// </summary>
    /// <value>Specifies the maximum desired number of pods the job should run at any given time. The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) < .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</value>
    [DataMember(Name="parallelism", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parallelism")]
    public int? Parallelism { get; set; }

    /// <summary>
    /// A label query over pods that should match the pod count. Normally, the system sets this field for you. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
    /// </summary>
    /// <value>A label query over pods that should match the pod count. Normally, the system sets this field for you. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public IoK8sApimachineryPkgApisMetaV1LabelSelector Selector { get; set; }

    /// <summary>
    /// Describes the pod that will be created when executing a job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
    /// </summary>
    /// <value>Describes the pod that will be created when executing a job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</value>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public IoK8sKubernetesPkgApiV1PodTemplateSpec Template { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApisBatchV1JobSpec {\n");
      sb.Append("  ActiveDeadlineSeconds: ").Append(ActiveDeadlineSeconds).Append("\n");
      sb.Append("  Completions: ").Append(Completions).Append("\n");
      sb.Append("  ManualSelector: ").Append(ManualSelector).Append("\n");
      sb.Append("  Parallelism: ").Append(Parallelism).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
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
