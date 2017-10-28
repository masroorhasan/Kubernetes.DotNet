/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Kubernetes.DotNet.Client.SwaggerDateConverter;

namespace Kubernetes.DotNet.Model
{
    /// <summary>
    /// PodStatus represents information about the status of a pod. Status may trail the actual state of a system.
    /// </summary>
    [DataContract]
    public partial class V1PodStatus :  IEquatable<V1PodStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PodStatus" /> class.
        /// </summary>
        /// <param name="Conditions">Current service state of pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions.</param>
        /// <param name="ContainerStatuses">The list has one entry per container in the manifest. Each entry is currently the output of &#x60;docker inspect&#x60;. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status.</param>
        /// <param name="HostIP">IP address of the host to which the pod is assigned. Empty if not yet scheduled..</param>
        /// <param name="InitContainerStatuses">The list has one entry per init container in the manifest. The most recent successful init container will have ready &#x3D; true, the most recently started container will have startTime set. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status.</param>
        /// <param name="Message">A human readable message indicating details about why the pod is in this condition..</param>
        /// <param name="Phase">Current condition of the pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase.</param>
        /// <param name="PodIP">IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated..</param>
        /// <param name="QosClass">The Quality of Service (QOS) classification assigned to the pod based on resource requirements See PodQOSClass type for available QOS classes More info: https://github.com/kubernetes/kubernetes/blob/master/docs/design/resource-qos.md.</param>
        /// <param name="Reason">A brief CamelCase message indicating details about why the pod is in this state. e.g. &#39;OutOfDisk&#39;.</param>
        /// <param name="StartTime">RFC 3339 date and time at which the object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod..</param>
        public V1PodStatus(List<V1PodCondition> Conditions = default(List<V1PodCondition>), List<V1ContainerStatus> ContainerStatuses = default(List<V1ContainerStatus>), string HostIP = default(string), List<V1ContainerStatus> InitContainerStatuses = default(List<V1ContainerStatus>), string Message = default(string), string Phase = default(string), string PodIP = default(string), string QosClass = default(string), string Reason = default(string), DateTime? StartTime = default(DateTime?))
        {
            this.Conditions = Conditions;
            this.ContainerStatuses = ContainerStatuses;
            this.HostIP = HostIP;
            this.InitContainerStatuses = InitContainerStatuses;
            this.Message = Message;
            this.Phase = Phase;
            this.PodIP = PodIP;
            this.QosClass = QosClass;
            this.Reason = Reason;
            this.StartTime = StartTime;
        }
        
        /// <summary>
        /// Current service state of pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
        /// </summary>
        /// <value>Current service state of pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<V1PodCondition> Conditions { get; set; }

        /// <summary>
        /// The list has one entry per container in the manifest. Each entry is currently the output of &#x60;docker inspect&#x60;. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status
        /// </summary>
        /// <value>The list has one entry per container in the manifest. Each entry is currently the output of &#x60;docker inspect&#x60;. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</value>
        [DataMember(Name="containerStatuses", EmitDefaultValue=false)]
        public List<V1ContainerStatus> ContainerStatuses { get; set; }

        /// <summary>
        /// IP address of the host to which the pod is assigned. Empty if not yet scheduled.
        /// </summary>
        /// <value>IP address of the host to which the pod is assigned. Empty if not yet scheduled.</value>
        [DataMember(Name="hostIP", EmitDefaultValue=false)]
        public string HostIP { get; set; }

        /// <summary>
        /// The list has one entry per init container in the manifest. The most recent successful init container will have ready &#x3D; true, the most recently started container will have startTime set. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status
        /// </summary>
        /// <value>The list has one entry per init container in the manifest. The most recent successful init container will have ready &#x3D; true, the most recently started container will have startTime set. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</value>
        [DataMember(Name="initContainerStatuses", EmitDefaultValue=false)]
        public List<V1ContainerStatus> InitContainerStatuses { get; set; }

        /// <summary>
        /// A human readable message indicating details about why the pod is in this condition.
        /// </summary>
        /// <value>A human readable message indicating details about why the pod is in this condition.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Current condition of the pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase
        /// </summary>
        /// <value>Current condition of the pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase</value>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public string Phase { get; set; }

        /// <summary>
        /// IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated.
        /// </summary>
        /// <value>IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated.</value>
        [DataMember(Name="podIP", EmitDefaultValue=false)]
        public string PodIP { get; set; }

        /// <summary>
        /// The Quality of Service (QOS) classification assigned to the pod based on resource requirements See PodQOSClass type for available QOS classes More info: https://github.com/kubernetes/kubernetes/blob/master/docs/design/resource-qos.md
        /// </summary>
        /// <value>The Quality of Service (QOS) classification assigned to the pod based on resource requirements See PodQOSClass type for available QOS classes More info: https://github.com/kubernetes/kubernetes/blob/master/docs/design/resource-qos.md</value>
        [DataMember(Name="qosClass", EmitDefaultValue=false)]
        public string QosClass { get; set; }

        /// <summary>
        /// A brief CamelCase message indicating details about why the pod is in this state. e.g. &#39;OutOfDisk&#39;
        /// </summary>
        /// <value>A brief CamelCase message indicating details about why the pod is in this state. e.g. &#39;OutOfDisk&#39;</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// RFC 3339 date and time at which the object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod.
        /// </summary>
        /// <value>RFC 3339 date and time at which the object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PodStatus {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  ContainerStatuses: ").Append(ContainerStatuses).Append("\n");
            sb.Append("  HostIP: ").Append(HostIP).Append("\n");
            sb.Append("  InitContainerStatuses: ").Append(InitContainerStatuses).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  PodIP: ").Append(PodIP).Append("\n");
            sb.Append("  QosClass: ").Append(QosClass).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1PodStatus);
        }

        /// <summary>
        /// Returns true if V1PodStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PodStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PodStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
                ) && 
                (
                    this.ContainerStatuses == other.ContainerStatuses ||
                    this.ContainerStatuses != null &&
                    this.ContainerStatuses.SequenceEqual(other.ContainerStatuses)
                ) && 
                (
                    this.HostIP == other.HostIP ||
                    this.HostIP != null &&
                    this.HostIP.Equals(other.HostIP)
                ) && 
                (
                    this.InitContainerStatuses == other.InitContainerStatuses ||
                    this.InitContainerStatuses != null &&
                    this.InitContainerStatuses.SequenceEqual(other.InitContainerStatuses)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Phase == other.Phase ||
                    this.Phase != null &&
                    this.Phase.Equals(other.Phase)
                ) && 
                (
                    this.PodIP == other.PodIP ||
                    this.PodIP != null &&
                    this.PodIP.Equals(other.PodIP)
                ) && 
                (
                    this.QosClass == other.QosClass ||
                    this.QosClass != null &&
                    this.QosClass.Equals(other.QosClass)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();
                if (this.ContainerStatuses != null)
                    hash = hash * 59 + this.ContainerStatuses.GetHashCode();
                if (this.HostIP != null)
                    hash = hash * 59 + this.HostIP.GetHashCode();
                if (this.InitContainerStatuses != null)
                    hash = hash * 59 + this.InitContainerStatuses.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Phase != null)
                    hash = hash * 59 + this.Phase.GetHashCode();
                if (this.PodIP != null)
                    hash = hash * 59 + this.PodIP.GetHashCode();
                if (this.QosClass != null)
                    hash = hash * 59 + this.QosClass.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
