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
    /// ID Range provides a min/max of an allowed range of IDs.
    /// </summary>
    [DataContract]
    public partial class V1beta1IDRange :  IEquatable<V1beta1IDRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1IDRange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1beta1IDRange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1IDRange" /> class.
        /// </summary>
        /// <param name="Max">Max is the end of the range, inclusive. (required).</param>
        /// <param name="Min">Min is the start of the range, inclusive. (required).</param>
        public V1beta1IDRange(long? Max = default(long?), long? Min = default(long?))
        {
            // to ensure "Max" is required (not null)
            if (Max == null)
            {
                throw new InvalidDataException("Max is a required property for V1beta1IDRange and cannot be null");
            }
            else
            {
                this.Max = Max;
            }
            // to ensure "Min" is required (not null)
            if (Min == null)
            {
                throw new InvalidDataException("Min is a required property for V1beta1IDRange and cannot be null");
            }
            else
            {
                this.Min = Min;
            }
        }
        
        /// <summary>
        /// Max is the end of the range, inclusive.
        /// </summary>
        /// <value>Max is the end of the range, inclusive.</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public long? Max { get; set; }

        /// <summary>
        /// Min is the start of the range, inclusive.
        /// </summary>
        /// <value>Min is the start of the range, inclusive.</value>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public long? Min { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1IDRange {\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
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
            return this.Equals(obj as V1beta1IDRange);
        }

        /// <summary>
        /// Returns true if V1beta1IDRange instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1IDRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1IDRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
                ) && 
                (
                    this.Min == other.Min ||
                    this.Min != null &&
                    this.Min.Equals(other.Min)
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
                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();
                if (this.Min != null)
                    hash = hash * 59 + this.Min.GetHashCode();
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
