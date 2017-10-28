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
    /// Maps a string key to a path within a volume.
    /// </summary>
    [DataContract]
    public partial class V1KeyToPath :  IEquatable<V1KeyToPath>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1KeyToPath" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1KeyToPath() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1KeyToPath" /> class.
        /// </summary>
        /// <param name="Key">The key to project. (required).</param>
        /// <param name="Mode">Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set..</param>
        /// <param name="Path">The relative path of the file to map the key to. May not be an absolute path. May not contain the path element &#39;..&#39;. May not start with the string &#39;..&#39;. (required).</param>
        public V1KeyToPath(string Key = default(string), int? Mode = default(int?), string Path = default(string))
        {
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for V1KeyToPath and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "Path" is required (not null)
            if (Path == null)
            {
                throw new InvalidDataException("Path is a required property for V1KeyToPath and cannot be null");
            }
            else
            {
                this.Path = Path;
            }
            this.Mode = Mode;
        }
        
        /// <summary>
        /// The key to project.
        /// </summary>
        /// <value>The key to project.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        /// <value>Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// The relative path of the file to map the key to. May not be an absolute path. May not contain the path element &#39;..&#39;. May not start with the string &#39;..&#39;.
        /// </summary>
        /// <value>The relative path of the file to map the key to. May not be an absolute path. May not contain the path element &#39;..&#39;. May not start with the string &#39;..&#39;.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1KeyToPath {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(obj as V1KeyToPath);
        }

        /// <summary>
        /// Returns true if V1KeyToPath instances are equal
        /// </summary>
        /// <param name="other">Instance of V1KeyToPath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1KeyToPath other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
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
