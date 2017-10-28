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
    /// Represents a volume that is populated with the contents of a git repository. Git repo volumes do not support ownership management. Git repo volumes support SELinux relabeling.
    /// </summary>
    [DataContract]
    public partial class V1GitRepoVolumeSource :  IEquatable<V1GitRepoVolumeSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1GitRepoVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1GitRepoVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1GitRepoVolumeSource" /> class.
        /// </summary>
        /// <param name="Directory">Target directory name. Must not contain or start with &#39;..&#39;.  If &#39;.&#39; is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name..</param>
        /// <param name="Repository">Repository URL (required).</param>
        /// <param name="Revision">Commit hash for the specified revision..</param>
        public V1GitRepoVolumeSource(string Directory = default(string), string Repository = default(string), string Revision = default(string))
        {
            // to ensure "Repository" is required (not null)
            if (Repository == null)
            {
                throw new InvalidDataException("Repository is a required property for V1GitRepoVolumeSource and cannot be null");
            }
            else
            {
                this.Repository = Repository;
            }
            this.Directory = Directory;
            this.Revision = Revision;
        }
        
        /// <summary>
        /// Target directory name. Must not contain or start with &#39;..&#39;.  If &#39;.&#39; is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.
        /// </summary>
        /// <value>Target directory name. Must not contain or start with &#39;..&#39;.  If &#39;.&#39; is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.</value>
        [DataMember(Name="directory", EmitDefaultValue=false)]
        public string Directory { get; set; }

        /// <summary>
        /// Repository URL
        /// </summary>
        /// <value>Repository URL</value>
        [DataMember(Name="repository", EmitDefaultValue=false)]
        public string Repository { get; set; }

        /// <summary>
        /// Commit hash for the specified revision.
        /// </summary>
        /// <value>Commit hash for the specified revision.</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public string Revision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1GitRepoVolumeSource {\n");
            sb.Append("  Directory: ").Append(Directory).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
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
            return this.Equals(obj as V1GitRepoVolumeSource);
        }

        /// <summary>
        /// Returns true if V1GitRepoVolumeSource instances are equal
        /// </summary>
        /// <param name="other">Instance of V1GitRepoVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1GitRepoVolumeSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Directory == other.Directory ||
                    this.Directory != null &&
                    this.Directory.Equals(other.Directory)
                ) && 
                (
                    this.Repository == other.Repository ||
                    this.Repository != null &&
                    this.Repository.Equals(other.Repository)
                ) && 
                (
                    this.Revision == other.Revision ||
                    this.Revision != null &&
                    this.Revision.Equals(other.Revision)
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
                if (this.Directory != null)
                    hash = hash * 59 + this.Directory.GetHashCode();
                if (this.Repository != null)
                    hash = hash * 59 + this.Repository.GetHashCode();
                if (this.Revision != null)
                    hash = hash * 59 + this.Revision.GetHashCode();
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
