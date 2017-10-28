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
    /// Handler defines a specific action that should be taken
    /// </summary>
    [DataContract]
    public partial class V1Handler :  IEquatable<V1Handler>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Handler" /> class.
        /// </summary>
        /// <param name="Exec">One and only one of the following should be specified. Exec specifies the action to take..</param>
        /// <param name="HttpGet">HTTPGet specifies the http request to perform..</param>
        /// <param name="TcpSocket">TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</param>
        public V1Handler(V1ExecAction Exec = default(V1ExecAction), V1HTTPGetAction HttpGet = default(V1HTTPGetAction), V1TCPSocketAction TcpSocket = default(V1TCPSocketAction))
        {
            this.Exec = Exec;
            this.HttpGet = HttpGet;
            this.TcpSocket = TcpSocket;
        }
        
        /// <summary>
        /// One and only one of the following should be specified. Exec specifies the action to take.
        /// </summary>
        /// <value>One and only one of the following should be specified. Exec specifies the action to take.</value>
        [DataMember(Name="exec", EmitDefaultValue=false)]
        public V1ExecAction Exec { get; set; }

        /// <summary>
        /// HTTPGet specifies the http request to perform.
        /// </summary>
        /// <value>HTTPGet specifies the http request to perform.</value>
        [DataMember(Name="httpGet", EmitDefaultValue=false)]
        public V1HTTPGetAction HttpGet { get; set; }

        /// <summary>
        /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported
        /// </summary>
        /// <value>TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported</value>
        [DataMember(Name="tcpSocket", EmitDefaultValue=false)]
        public V1TCPSocketAction TcpSocket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Handler {\n");
            sb.Append("  Exec: ").Append(Exec).Append("\n");
            sb.Append("  HttpGet: ").Append(HttpGet).Append("\n");
            sb.Append("  TcpSocket: ").Append(TcpSocket).Append("\n");
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
            return this.Equals(obj as V1Handler);
        }

        /// <summary>
        /// Returns true if V1Handler instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Handler to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Handler other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Exec == other.Exec ||
                    this.Exec != null &&
                    this.Exec.Equals(other.Exec)
                ) && 
                (
                    this.HttpGet == other.HttpGet ||
                    this.HttpGet != null &&
                    this.HttpGet.Equals(other.HttpGet)
                ) && 
                (
                    this.TcpSocket == other.TcpSocket ||
                    this.TcpSocket != null &&
                    this.TcpSocket.Equals(other.TcpSocket)
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
                if (this.Exec != null)
                    hash = hash * 59 + this.Exec.GetHashCode();
                if (this.HttpGet != null)
                    hash = hash * 59 + this.HttpGet.GetHashCode();
                if (this.TcpSocket != null)
                    hash = hash * 59 + this.TcpSocket.GetHashCode();
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
