using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// A single application container that you want to run within a pod.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1Container {
    /// <summary>
    /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
    /// </summary>
    /// <value>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</value>
    [DataMember(Name="args", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "args")]
    public List<string> Args { get; set; }

    /// <summary>
    /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
    /// </summary>
    /// <value>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</value>
    [DataMember(Name="command", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "command")]
    public List<string> Command { get; set; }

    /// <summary>
    /// List of environment variables to set in the container. Cannot be updated.
    /// </summary>
    /// <value>List of environment variables to set in the container. Cannot be updated.</value>
    [DataMember(Name="env", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "env")]
    public List<IoK8sKubernetesPkgApiV1EnvVar> Env { get; set; }

    /// <summary>
    /// List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
    /// </summary>
    /// <value>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</value>
    [DataMember(Name="envFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "envFrom")]
    public List<IoK8sKubernetesPkgApiV1EnvFromSource> EnvFrom { get; set; }

    /// <summary>
    /// Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images
    /// </summary>
    /// <value>Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
    /// </summary>
    /// <value>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</value>
    [DataMember(Name="imagePullPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imagePullPolicy")]
    public string ImagePullPolicy { get; set; }

    /// <summary>
    /// Actions that the management system should take in response to container lifecycle events. Cannot be updated.
    /// </summary>
    /// <value>Actions that the management system should take in response to container lifecycle events. Cannot be updated.</value>
    [DataMember(Name="lifecycle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lifecycle")]
    public IoK8sKubernetesPkgApiV1Lifecycle Lifecycle { get; set; }

    /// <summary>
    /// Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    /// <value>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</value>
    [DataMember(Name="livenessProbe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "livenessProbe")]
    public IoK8sKubernetesPkgApiV1Probe LivenessProbe { get; set; }

    /// <summary>
    /// Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.
    /// </summary>
    /// <value>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// List of ports to expose from the container. Exposing a port here gives the system additional information about the network connections a container uses, but is primarily informational. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default \"0.0.0.0\" address inside a container will be accessible from the network. Cannot be updated.
    /// </summary>
    /// <value>List of ports to expose from the container. Exposing a port here gives the system additional information about the network connections a container uses, but is primarily informational. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default \"0.0.0.0\" address inside a container will be accessible from the network. Cannot be updated.</value>
    [DataMember(Name="ports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ports")]
    public List<IoK8sKubernetesPkgApiV1ContainerPort> Ports { get; set; }

    /// <summary>
    /// Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
    /// </summary>
    /// <value>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</value>
    [DataMember(Name="readinessProbe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readinessProbe")]
    public IoK8sKubernetesPkgApiV1Probe ReadinessProbe { get; set; }

    /// <summary>
    /// Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
    /// </summary>
    /// <value>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</value>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public IoK8sKubernetesPkgApiV1ResourceRequirements Resources { get; set; }

    /// <summary>
    /// Security options the pod should run with. More info: https://kubernetes.io/docs/concepts/policy/security-context/ More info: https://git.k8s.io/community/contributors/design-proposals/security_context.md
    /// </summary>
    /// <value>Security options the pod should run with. More info: https://kubernetes.io/docs/concepts/policy/security-context/ More info: https://git.k8s.io/community/contributors/design-proposals/security_context.md</value>
    [DataMember(Name="securityContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityContext")]
    public IoK8sKubernetesPkgApiV1SecurityContext SecurityContext { get; set; }

    /// <summary>
    /// Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.
    /// </summary>
    /// <value>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.</value>
    [DataMember(Name="stdin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stdin")]
    public bool? Stdin { get; set; }

    /// <summary>
    /// Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
    /// </summary>
    /// <value>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false</value>
    [DataMember(Name="stdinOnce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stdinOnce")]
    public bool? StdinOnce { get; set; }

    /// <summary>
    /// Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
    /// </summary>
    /// <value>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</value>
    [DataMember(Name="terminationMessagePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminationMessagePath")]
    public string TerminationMessagePath { get; set; }

    /// <summary>
    /// Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.
    /// </summary>
    /// <value>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.</value>
    [DataMember(Name="terminationMessagePolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminationMessagePolicy")]
    public string TerminationMessagePolicy { get; set; }

    /// <summary>
    /// Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.
    /// </summary>
    /// <value>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.</value>
    [DataMember(Name="tty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tty")]
    public bool? Tty { get; set; }

    /// <summary>
    /// Pod volumes to mount into the container's filesystem. Cannot be updated.
    /// </summary>
    /// <value>Pod volumes to mount into the container's filesystem. Cannot be updated.</value>
    [DataMember(Name="volumeMounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volumeMounts")]
    public List<IoK8sKubernetesPkgApiV1VolumeMount> VolumeMounts { get; set; }

    /// <summary>
    /// Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.
    /// </summary>
    /// <value>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.</value>
    [DataMember(Name="workingDir", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workingDir")]
    public string WorkingDir { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1Container {\n");
      sb.Append("  Args: ").Append(Args).Append("\n");
      sb.Append("  Command: ").Append(Command).Append("\n");
      sb.Append("  Env: ").Append(Env).Append("\n");
      sb.Append("  EnvFrom: ").Append(EnvFrom).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  ImagePullPolicy: ").Append(ImagePullPolicy).Append("\n");
      sb.Append("  Lifecycle: ").Append(Lifecycle).Append("\n");
      sb.Append("  LivenessProbe: ").Append(LivenessProbe).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Ports: ").Append(Ports).Append("\n");
      sb.Append("  ReadinessProbe: ").Append(ReadinessProbe).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
      sb.Append("  Stdin: ").Append(Stdin).Append("\n");
      sb.Append("  StdinOnce: ").Append(StdinOnce).Append("\n");
      sb.Append("  TerminationMessagePath: ").Append(TerminationMessagePath).Append("\n");
      sb.Append("  TerminationMessagePolicy: ").Append(TerminationMessagePolicy).Append("\n");
      sb.Append("  Tty: ").Append(Tty).Append("\n");
      sb.Append("  VolumeMounts: ").Append(VolumeMounts).Append("\n");
      sb.Append("  WorkingDir: ").Append(WorkingDir).Append("\n");
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
