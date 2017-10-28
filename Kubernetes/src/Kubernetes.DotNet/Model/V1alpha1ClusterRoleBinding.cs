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
    /// ClusterRoleBinding references a ClusterRole, but not contain it.  It can reference a ClusterRole in the global namespace, and adds who information via Subject.
    /// </summary>
    [DataContract]
    public partial class V1alpha1ClusterRoleBinding :  IEquatable<V1alpha1ClusterRoleBinding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1alpha1ClusterRoleBinding" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1alpha1ClusterRoleBinding() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1alpha1ClusterRoleBinding" /> class.
        /// </summary>
        /// <param name="ApiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources.</param>
        /// <param name="Kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds.</param>
        /// <param name="Metadata">Standard object&#39;s metadata..</param>
        /// <param name="RoleRef">RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error. (required).</param>
        /// <param name="Subjects">Subjects holds references to the objects the role applies to. (required).</param>
        public V1alpha1ClusterRoleBinding(string ApiVersion = default(string), string Kind = default(string), V1ObjectMeta Metadata = default(V1ObjectMeta), V1alpha1RoleRef RoleRef = default(V1alpha1RoleRef), List<V1alpha1Subject> Subjects = default(List<V1alpha1Subject>))
        {
            // to ensure "RoleRef" is required (not null)
            if (RoleRef == null)
            {
                throw new InvalidDataException("RoleRef is a required property for V1alpha1ClusterRoleBinding and cannot be null");
            }
            else
            {
                this.RoleRef = RoleRef;
            }
            // to ensure "Subjects" is required (not null)
            if (Subjects == null)
            {
                throw new InvalidDataException("Subjects is a required property for V1alpha1ClusterRoleBinding and cannot be null");
            }
            else
            {
                this.Subjects = Subjects;
            }
            this.ApiVersion = ApiVersion;
            this.Kind = Kind;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object&#39;s metadata.
        /// </summary>
        /// <value>Standard object&#39;s metadata.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.
        /// </summary>
        /// <value>RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.</value>
        [DataMember(Name="roleRef", EmitDefaultValue=false)]
        public V1alpha1RoleRef RoleRef { get; set; }

        /// <summary>
        /// Subjects holds references to the objects the role applies to.
        /// </summary>
        /// <value>Subjects holds references to the objects the role applies to.</value>
        [DataMember(Name="subjects", EmitDefaultValue=false)]
        public List<V1alpha1Subject> Subjects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1alpha1ClusterRoleBinding {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  RoleRef: ").Append(RoleRef).Append("\n");
            sb.Append("  Subjects: ").Append(Subjects).Append("\n");
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
            return this.Equals(obj as V1alpha1ClusterRoleBinding);
        }

        /// <summary>
        /// Returns true if V1alpha1ClusterRoleBinding instances are equal
        /// </summary>
        /// <param name="other">Instance of V1alpha1ClusterRoleBinding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1alpha1ClusterRoleBinding other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiVersion == other.ApiVersion ||
                    this.ApiVersion != null &&
                    this.ApiVersion.Equals(other.ApiVersion)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.RoleRef == other.RoleRef ||
                    this.RoleRef != null &&
                    this.RoleRef.Equals(other.RoleRef)
                ) && 
                (
                    this.Subjects == other.Subjects ||
                    this.Subjects != null &&
                    this.Subjects.SequenceEqual(other.Subjects)
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
                if (this.ApiVersion != null)
                    hash = hash * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.RoleRef != null)
                    hash = hash * 59 + this.RoleRef.GetHashCode();
                if (this.Subjects != null)
                    hash = hash * 59 + this.Subjects.GetHashCode();
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
