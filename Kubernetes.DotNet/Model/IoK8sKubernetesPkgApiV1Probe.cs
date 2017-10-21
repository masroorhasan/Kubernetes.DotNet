using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1Probe {
    /// <summary>
    /// One and only one of the following should be specified. Exec specifies the action to take.
    /// </summary>
    /// <value>One and only one of the following should be specified. Exec specifies the action to take.</value>
    [DataMember(Name="exec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exec")]
    public IoK8sKubernetesPkgApiV1ExecAction Exec { get; set; }

    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    /// <value>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</value>
    [DataMember(Name="failureThreshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>
    /// HTTPGet specifies the http request to perform.
    /// </summary>
    /// <value>HTTPGet specifies the http request to perform.</value>
    [DataMember(Name="httpGet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "httpGet")]
    public IoK8sKubernetesPkgApiV1HTTPGetAction HttpGet { get; set; }

    /// <summary>
    /// Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    /// <value>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</value>
    [DataMember(Name="initialDelaySeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>
    /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
    /// </summary>
    /// <value>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</value>
    [DataMember(Name="periodSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>
    /// Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.
    /// </summary>
    /// <value>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</value>
    [DataMember(Name="successThreshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>
    /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported
    /// </summary>
    /// <value>TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported</value>
    [DataMember(Name="tcpSocket", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tcpSocket")]
    public IoK8sKubernetesPkgApiV1TCPSocketAction TcpSocket { get; set; }

    /// <summary>
    /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    /// <value>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</value>
    [DataMember(Name="timeoutSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1Probe {\n");
      sb.Append("  Exec: ").Append(Exec).Append("\n");
      sb.Append("  FailureThreshold: ").Append(FailureThreshold).Append("\n");
      sb.Append("  HttpGet: ").Append(HttpGet).Append("\n");
      sb.Append("  InitialDelaySeconds: ").Append(InitialDelaySeconds).Append("\n");
      sb.Append("  PeriodSeconds: ").Append(PeriodSeconds).Append("\n");
      sb.Append("  SuccessThreshold: ").Append(SuccessThreshold).Append("\n");
      sb.Append("  TcpSocket: ").Append(TcpSocket).Append("\n");
      sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
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
