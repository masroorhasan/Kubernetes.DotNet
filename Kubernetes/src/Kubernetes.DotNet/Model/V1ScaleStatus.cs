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
    /// ScaleStatus represents the current status of a scale subresource.
    /// </summary>
    [DataContract]
    public partial class V1ScaleStatus :  IEquatable<V1ScaleStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ScaleStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1ScaleStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ScaleStatus" /> class.
        /// </summary>
        /// <param name="Replicas">actual number of observed instances of the scaled object. (required).</param>
        /// <param name="Selector">label query over pods that should match the replicas count. This is same as the label selector but in the string format to avoid introspection by clients. The string will be in the same format as the query-param syntax. More info about label selectors: http://kubernetes.io/docs/user-guide/labels#label-selectors.</param>
        public V1ScaleStatus(int? Replicas = default(int?), string Selector = default(string))
        {
            // to ensure "Replicas" is required (not null)
            if (Replicas == null)
            {
                throw new InvalidDataException("Replicas is a required property for V1ScaleStatus and cannot be null");
            }
            else
            {
                this.Replicas = Replicas;
            }
            this.Selector = Selector;
        }
        
        /// <summary>
        /// actual number of observed instances of the scaled object.
        /// </summary>
        /// <value>actual number of observed instances of the scaled object.</value>
        [DataMember(Name="replicas", EmitDefaultValue=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// label query over pods that should match the replicas count. This is same as the label selector but in the string format to avoid introspection by clients. The string will be in the same format as the query-param syntax. More info about label selectors: http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        /// <value>label query over pods that should match the replicas count. This is same as the label selector but in the string format to avoid introspection by clients. The string will be in the same format as the query-param syntax. More info about label selectors: http://kubernetes.io/docs/user-guide/labels#label-selectors</value>
        [DataMember(Name="selector", EmitDefaultValue=false)]
        public string Selector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ScaleStatus {\n");
            sb.Append("  Replicas: ").Append(Replicas).Append("\n");
            sb.Append("  Selector: ").Append(Selector).Append("\n");
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
            return this.Equals(obj as V1ScaleStatus);
        }

        /// <summary>
        /// Returns true if V1ScaleStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ScaleStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ScaleStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Replicas == other.Replicas ||
                    this.Replicas != null &&
                    this.Replicas.Equals(other.Replicas)
                ) && 
                (
                    this.Selector == other.Selector ||
                    this.Selector != null &&
                    this.Selector.Equals(other.Selector)
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
                if (this.Replicas != null)
                    hash = hash * 59 + this.Replicas.GetHashCode();
                if (this.Selector != null)
                    hash = hash * 59 + this.Selector.GetHashCode();
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
