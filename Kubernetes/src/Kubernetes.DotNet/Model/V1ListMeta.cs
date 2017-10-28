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
    /// ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.
    /// </summary>
    [DataContract]
    public partial class V1ListMeta :  IEquatable<V1ListMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListMeta" /> class.
        /// </summary>
        /// <param name="ResourceVersion">String that identifies the server&#39;s internal version of this object that can be used by clients to determine when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency.</param>
        /// <param name="SelfLink">SelfLink is a URL representing this object. Populated by the system. Read-only..</param>
        public V1ListMeta(string ResourceVersion = default(string), string SelfLink = default(string))
        {
            this.ResourceVersion = ResourceVersion;
            this.SelfLink = SelfLink;
        }
        
        /// <summary>
        /// String that identifies the server&#39;s internal version of this object that can be used by clients to determine when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        /// <value>String that identifies the server&#39;s internal version of this object that can be used by clients to determine when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency</value>
        [DataMember(Name="resourceVersion", EmitDefaultValue=false)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// SelfLink is a URL representing this object. Populated by the system. Read-only.
        /// </summary>
        /// <value>SelfLink is a URL representing this object. Populated by the system. Read-only.</value>
        [DataMember(Name="selfLink", EmitDefaultValue=false)]
        public string SelfLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ListMeta {\n");
            sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
            sb.Append("  SelfLink: ").Append(SelfLink).Append("\n");
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
            return this.Equals(obj as V1ListMeta);
        }

        /// <summary>
        /// Returns true if V1ListMeta instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ListMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ListMeta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResourceVersion == other.ResourceVersion ||
                    this.ResourceVersion != null &&
                    this.ResourceVersion.Equals(other.ResourceVersion)
                ) && 
                (
                    this.SelfLink == other.SelfLink ||
                    this.SelfLink != null &&
                    this.SelfLink.Equals(other.SelfLink)
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
                if (this.ResourceVersion != null)
                    hash = hash * 59 + this.ResourceVersion.GetHashCode();
                if (this.SelfLink != null)
                    hash = hash * 59 + this.SelfLink.GetHashCode();
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
