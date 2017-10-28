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
    /// StatusDetails is a set of additional properties that MAY be set by the server to provide additional information about a response. The Reason field of a Status object defines what attributes will be set. Clients must ignore fields that do not match the defined type of each attribute, and should assume that any attribute may be empty, invalid, or under defined.
    /// </summary>
    [DataContract]
    public partial class V1StatusDetails :  IEquatable<V1StatusDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1StatusDetails" /> class.
        /// </summary>
        /// <param name="Causes">The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes..</param>
        /// <param name="Group">The group attribute of the resource associated with the status StatusReason..</param>
        /// <param name="Kind">The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds.</param>
        /// <param name="Name">The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described)..</param>
        /// <param name="RetryAfterSeconds">If specified, the time in seconds before the operation should be retried..</param>
        /// <param name="Uid">UID of the resource. (when there is a single resource which can be described). More info: http://kubernetes.io/docs/user-guide/identifiers#uids.</param>
        public V1StatusDetails(List<V1StatusCause> Causes = default(List<V1StatusCause>), string Group = default(string), string Kind = default(string), string Name = default(string), int? RetryAfterSeconds = default(int?), string Uid = default(string))
        {
            this.Causes = Causes;
            this.Group = Group;
            this.Kind = Kind;
            this.Name = Name;
            this.RetryAfterSeconds = RetryAfterSeconds;
            this.Uid = Uid;
        }
        
        /// <summary>
        /// The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.
        /// </summary>
        /// <value>The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.</value>
        [DataMember(Name="causes", EmitDefaultValue=false)]
        public List<V1StatusCause> Causes { get; set; }

        /// <summary>
        /// The group attribute of the resource associated with the status StatusReason.
        /// </summary>
        /// <value>The group attribute of the resource associated with the status StatusReason.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        /// <value>The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }

        /// <summary>
        /// The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).
        /// </summary>
        /// <value>The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// If specified, the time in seconds before the operation should be retried.
        /// </summary>
        /// <value>If specified, the time in seconds before the operation should be retried.</value>
        [DataMember(Name="retryAfterSeconds", EmitDefaultValue=false)]
        public int? RetryAfterSeconds { get; set; }

        /// <summary>
        /// UID of the resource. (when there is a single resource which can be described). More info: http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        /// <value>UID of the resource. (when there is a single resource which can be described). More info: http://kubernetes.io/docs/user-guide/identifiers#uids</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1StatusDetails {\n");
            sb.Append("  Causes: ").Append(Causes).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RetryAfterSeconds: ").Append(RetryAfterSeconds).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
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
            return this.Equals(obj as V1StatusDetails);
        }

        /// <summary>
        /// Returns true if V1StatusDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of V1StatusDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1StatusDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Causes == other.Causes ||
                    this.Causes != null &&
                    this.Causes.SequenceEqual(other.Causes)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RetryAfterSeconds == other.RetryAfterSeconds ||
                    this.RetryAfterSeconds != null &&
                    this.RetryAfterSeconds.Equals(other.RetryAfterSeconds)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
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
                if (this.Causes != null)
                    hash = hash * 59 + this.Causes.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RetryAfterSeconds != null)
                    hash = hash * 59 + this.RetryAfterSeconds.GetHashCode();
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
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
