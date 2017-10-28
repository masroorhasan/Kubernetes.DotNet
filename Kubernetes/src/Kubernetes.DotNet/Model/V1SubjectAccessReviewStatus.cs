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
    /// SubjectAccessReviewStatus
    /// </summary>
    [DataContract]
    public partial class V1SubjectAccessReviewStatus :  IEquatable<V1SubjectAccessReviewStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1SubjectAccessReviewStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1SubjectAccessReviewStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1SubjectAccessReviewStatus" /> class.
        /// </summary>
        /// <param name="Allowed">Allowed is required.  True if the action would be allowed, false otherwise. (required).</param>
        /// <param name="EvaluationError">EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request..</param>
        /// <param name="Reason">Reason is optional.  It indicates why a request was allowed or denied..</param>
        public V1SubjectAccessReviewStatus(bool? Allowed = default(bool?), string EvaluationError = default(string), string Reason = default(string))
        {
            // to ensure "Allowed" is required (not null)
            if (Allowed == null)
            {
                throw new InvalidDataException("Allowed is a required property for V1SubjectAccessReviewStatus and cannot be null");
            }
            else
            {
                this.Allowed = Allowed;
            }
            this.EvaluationError = EvaluationError;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// Allowed is required.  True if the action would be allowed, false otherwise.
        /// </summary>
        /// <value>Allowed is required.  True if the action would be allowed, false otherwise.</value>
        [DataMember(Name="allowed", EmitDefaultValue=false)]
        public bool? Allowed { get; set; }

        /// <summary>
        /// EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request.
        /// </summary>
        /// <value>EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request.</value>
        [DataMember(Name="evaluationError", EmitDefaultValue=false)]
        public string EvaluationError { get; set; }

        /// <summary>
        /// Reason is optional.  It indicates why a request was allowed or denied.
        /// </summary>
        /// <value>Reason is optional.  It indicates why a request was allowed or denied.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1SubjectAccessReviewStatus {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  EvaluationError: ").Append(EvaluationError).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as V1SubjectAccessReviewStatus);
        }

        /// <summary>
        /// Returns true if V1SubjectAccessReviewStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1SubjectAccessReviewStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1SubjectAccessReviewStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Allowed == other.Allowed ||
                    this.Allowed != null &&
                    this.Allowed.Equals(other.Allowed)
                ) && 
                (
                    this.EvaluationError == other.EvaluationError ||
                    this.EvaluationError != null &&
                    this.EvaluationError.Equals(other.EvaluationError)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.Allowed != null)
                    hash = hash * 59 + this.Allowed.GetHashCode();
                if (this.EvaluationError != null)
                    hash = hash * 59 + this.EvaluationError.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
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
