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
    /// ContainerPort represents a network port in a single container.
    /// </summary>
    [DataContract]
    public partial class V1ContainerPort :  IEquatable<V1ContainerPort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainerPort" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1ContainerPort() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainerPort" /> class.
        /// </summary>
        /// <param name="ContainerPort">Number of port to expose on the pod&#39;s IP address. This must be a valid port number, 0 &lt; x &lt; 65536. (required).</param>
        /// <param name="HostIP">What host IP to bind the external port to..</param>
        /// <param name="HostPort">Number of port to expose on the host. If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this..</param>
        /// <param name="Name">If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services..</param>
        /// <param name="Protocol">Protocol for port. Must be UDP or TCP. Defaults to \&quot;TCP\&quot;..</param>
        public V1ContainerPort(int? ContainerPort = default(int?), string HostIP = default(string), int? HostPort = default(int?), string Name = default(string), string Protocol = default(string))
        {
            // to ensure "ContainerPort" is required (not null)
            if (ContainerPort == null)
            {
                throw new InvalidDataException("ContainerPort is a required property for V1ContainerPort and cannot be null");
            }
            else
            {
                this.ContainerPort = ContainerPort;
            }
            this.HostIP = HostIP;
            this.HostPort = HostPort;
            this.Name = Name;
            this.Protocol = Protocol;
        }
        
        /// <summary>
        /// Number of port to expose on the pod&#39;s IP address. This must be a valid port number, 0 &lt; x &lt; 65536.
        /// </summary>
        /// <value>Number of port to expose on the pod&#39;s IP address. This must be a valid port number, 0 &lt; x &lt; 65536.</value>
        [DataMember(Name="containerPort", EmitDefaultValue=false)]
        public int? ContainerPort { get; set; }

        /// <summary>
        /// What host IP to bind the external port to.
        /// </summary>
        /// <value>What host IP to bind the external port to.</value>
        [DataMember(Name="hostIP", EmitDefaultValue=false)]
        public string HostIP { get; set; }

        /// <summary>
        /// Number of port to expose on the host. If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.
        /// </summary>
        /// <value>Number of port to expose on the host. If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.</value>
        [DataMember(Name="hostPort", EmitDefaultValue=false)]
        public int? HostPort { get; set; }

        /// <summary>
        /// If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.
        /// </summary>
        /// <value>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Protocol for port. Must be UDP or TCP. Defaults to \&quot;TCP\&quot;.
        /// </summary>
        /// <value>Protocol for port. Must be UDP or TCP. Defaults to \&quot;TCP\&quot;.</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ContainerPort {\n");
            sb.Append("  ContainerPort: ").Append(ContainerPort).Append("\n");
            sb.Append("  HostIP: ").Append(HostIP).Append("\n");
            sb.Append("  HostPort: ").Append(HostPort).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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
            return this.Equals(obj as V1ContainerPort);
        }

        /// <summary>
        /// Returns true if V1ContainerPort instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ContainerPort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ContainerPort other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContainerPort == other.ContainerPort ||
                    this.ContainerPort != null &&
                    this.ContainerPort.Equals(other.ContainerPort)
                ) && 
                (
                    this.HostIP == other.HostIP ||
                    this.HostIP != null &&
                    this.HostIP.Equals(other.HostIP)
                ) && 
                (
                    this.HostPort == other.HostPort ||
                    this.HostPort != null &&
                    this.HostPort.Equals(other.HostPort)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Protocol == other.Protocol ||
                    this.Protocol != null &&
                    this.Protocol.Equals(other.Protocol)
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
                if (this.ContainerPort != null)
                    hash = hash * 59 + this.ContainerPort.GetHashCode();
                if (this.HostIP != null)
                    hash = hash * 59 + this.HostIP.GetHashCode();
                if (this.HostPort != null)
                    hash = hash * 59 + this.HostPort.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Protocol != null)
                    hash = hash * 59 + this.Protocol.GetHashCode();
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
