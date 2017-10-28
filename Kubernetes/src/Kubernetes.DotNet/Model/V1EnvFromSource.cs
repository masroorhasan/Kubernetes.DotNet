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
    /// EnvFromSource represents the source of a set of ConfigMaps
    /// </summary>
    [DataContract]
    public partial class V1EnvFromSource :  IEquatable<V1EnvFromSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvFromSource" /> class.
        /// </summary>
        /// <param name="ConfigMapRef">The ConfigMap to select from.</param>
        /// <param name="Prefix">An optional identifer to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER..</param>
        /// <param name="SecretRef">The Secret to select from.</param>
        public V1EnvFromSource(V1ConfigMapEnvSource ConfigMapRef = default(V1ConfigMapEnvSource), string Prefix = default(string), V1SecretEnvSource SecretRef = default(V1SecretEnvSource))
        {
            this.ConfigMapRef = ConfigMapRef;
            this.Prefix = Prefix;
            this.SecretRef = SecretRef;
        }
        
        /// <summary>
        /// The ConfigMap to select from
        /// </summary>
        /// <value>The ConfigMap to select from</value>
        [DataMember(Name="configMapRef", EmitDefaultValue=false)]
        public V1ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>
        /// An optional identifer to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.
        /// </summary>
        /// <value>An optional identifer to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The Secret to select from
        /// </summary>
        /// <value>The Secret to select from</value>
        [DataMember(Name="secretRef", EmitDefaultValue=false)]
        public V1SecretEnvSource SecretRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1EnvFromSource {\n");
            sb.Append("  ConfigMapRef: ").Append(ConfigMapRef).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
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
            return this.Equals(obj as V1EnvFromSource);
        }

        /// <summary>
        /// Returns true if V1EnvFromSource instances are equal
        /// </summary>
        /// <param name="other">Instance of V1EnvFromSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1EnvFromSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConfigMapRef == other.ConfigMapRef ||
                    this.ConfigMapRef != null &&
                    this.ConfigMapRef.Equals(other.ConfigMapRef)
                ) && 
                (
                    this.Prefix == other.Prefix ||
                    this.Prefix != null &&
                    this.Prefix.Equals(other.Prefix)
                ) && 
                (
                    this.SecretRef == other.SecretRef ||
                    this.SecretRef != null &&
                    this.SecretRef.Equals(other.SecretRef)
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
                if (this.ConfigMapRef != null)
                    hash = hash * 59 + this.ConfigMapRef.GetHashCode();
                if (this.Prefix != null)
                    hash = hash * 59 + this.Prefix.GetHashCode();
                if (this.SecretRef != null)
                    hash = hash * 59 + this.SecretRef.GetHashCode();
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
