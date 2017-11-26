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
    /// AdmissionHookClientConfig contains the information to make a TLS connection with the webhook
    /// </summary>
    [DataContract]
    public partial class V1alpha1AdmissionHookClientConfig :  IEquatable<V1alpha1AdmissionHookClientConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1alpha1AdmissionHookClientConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1alpha1AdmissionHookClientConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1alpha1AdmissionHookClientConfig" /> class.
        /// </summary>
        /// <param name="CaBundle">CABundle is a PEM encoded CA bundle which will be used to validate webhook&#39;s server certificate. Required (required).</param>
        /// <param name="Service">Service is a reference to the service for this webhook. If there is only one port open for the service, that port will be used. If there are multiple ports open, port 443 will be used if it is open, otherwise it is an error. Required (required).</param>
        public V1alpha1AdmissionHookClientConfig(byte[] CaBundle = default(byte[]), V1alpha1ServiceReference Service = default(V1alpha1ServiceReference))
        {
            // to ensure "CaBundle" is required (not null)
            if (CaBundle == null)
            {
                throw new InvalidDataException("CaBundle is a required property for V1alpha1AdmissionHookClientConfig and cannot be null");
            }
            else
            {
                this.CaBundle = CaBundle;
            }
            // to ensure "Service" is required (not null)
            if (Service == null)
            {
                throw new InvalidDataException("Service is a required property for V1alpha1AdmissionHookClientConfig and cannot be null");
            }
            else
            {
                this.Service = Service;
            }
        }
        
        /// <summary>
        /// CABundle is a PEM encoded CA bundle which will be used to validate webhook&#39;s server certificate. Required
        /// </summary>
        /// <value>CABundle is a PEM encoded CA bundle which will be used to validate webhook&#39;s server certificate. Required</value>
        [DataMember(Name="caBundle", EmitDefaultValue=false)]
        public byte[] CaBundle { get; set; }

        /// <summary>
        /// Service is a reference to the service for this webhook. If there is only one port open for the service, that port will be used. If there are multiple ports open, port 443 will be used if it is open, otherwise it is an error. Required
        /// </summary>
        /// <value>Service is a reference to the service for this webhook. If there is only one port open for the service, that port will be used. If there are multiple ports open, port 443 will be used if it is open, otherwise it is an error. Required</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public V1alpha1ServiceReference Service { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1alpha1AdmissionHookClientConfig {\n");
            sb.Append("  CaBundle: ").Append(CaBundle).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
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
            return this.Equals(obj as V1alpha1AdmissionHookClientConfig);
        }

        /// <summary>
        /// Returns true if V1alpha1AdmissionHookClientConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of V1alpha1AdmissionHookClientConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1alpha1AdmissionHookClientConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CaBundle == other.CaBundle ||
                    this.CaBundle != null &&
                    this.CaBundle.Equals(other.CaBundle)
                ) && 
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.Equals(other.Service)
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
                if (this.CaBundle != null)
                    hash = hash * 59 + this.CaBundle.GetHashCode();
                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();
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