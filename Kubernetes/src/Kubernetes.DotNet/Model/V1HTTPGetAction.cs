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
    /// HTTPGetAction describes an action based on HTTP Get requests.
    /// </summary>
    [DataContract]
    public partial class V1HTTPGetAction :  IEquatable<V1HTTPGetAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1HTTPGetAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1HTTPGetAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1HTTPGetAction" /> class.
        /// </summary>
        /// <param name="Host">Host name to connect to, defaults to the pod IP. You probably want to set \&quot;Host\&quot; in httpHeaders instead..</param>
        /// <param name="HttpHeaders">Custom headers to set in the request. HTTP allows repeated headers..</param>
        /// <param name="Path">Path to access on the HTTP server..</param>
        /// <param name="Port">Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. (required).</param>
        /// <param name="Scheme">Scheme to use for connecting to the host. Defaults to HTTP..</param>
        public V1HTTPGetAction(string Host = default(string), List<V1HTTPHeader> HttpHeaders = default(List<V1HTTPHeader>), string Path = default(string), Object Port = default(Object), string Scheme = default(string))
        {
            // to ensure "Port" is required (not null)
            if (Port == null)
            {
                throw new InvalidDataException("Port is a required property for V1HTTPGetAction and cannot be null");
            }
            else
            {
                this.Port = Port;
            }
            this.Host = Host;
            this.HttpHeaders = HttpHeaders;
            this.Path = Path;
            this.Scheme = Scheme;
        }
        
        /// <summary>
        /// Host name to connect to, defaults to the pod IP. You probably want to set \&quot;Host\&quot; in httpHeaders instead.
        /// </summary>
        /// <value>Host name to connect to, defaults to the pod IP. You probably want to set \&quot;Host\&quot; in httpHeaders instead.</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

        /// <summary>
        /// Custom headers to set in the request. HTTP allows repeated headers.
        /// </summary>
        /// <value>Custom headers to set in the request. HTTP allows repeated headers.</value>
        [DataMember(Name="httpHeaders", EmitDefaultValue=false)]
        public List<V1HTTPHeader> HttpHeaders { get; set; }

        /// <summary>
        /// Path to access on the HTTP server.
        /// </summary>
        /// <value>Path to access on the HTTP server.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        /// </summary>
        /// <value>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public Object Port { get; set; }

        /// <summary>
        /// Scheme to use for connecting to the host. Defaults to HTTP.
        /// </summary>
        /// <value>Scheme to use for connecting to the host. Defaults to HTTP.</value>
        [DataMember(Name="scheme", EmitDefaultValue=false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1HTTPGetAction {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  HttpHeaders: ").Append(HttpHeaders).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
            return this.Equals(obj as V1HTTPGetAction);
        }

        /// <summary>
        /// Returns true if V1HTTPGetAction instances are equal
        /// </summary>
        /// <param name="other">Instance of V1HTTPGetAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1HTTPGetAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
                ) && 
                (
                    this.HttpHeaders == other.HttpHeaders ||
                    this.HttpHeaders != null &&
                    this.HttpHeaders.SequenceEqual(other.HttpHeaders)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.Scheme == other.Scheme ||
                    this.Scheme != null &&
                    this.Scheme.Equals(other.Scheme)
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
                if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();
                if (this.HttpHeaders != null)
                    hash = hash * 59 + this.HttpHeaders.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                if (this.Scheme != null)
                    hash = hash * 59 + this.Scheme.GetHashCode();
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
