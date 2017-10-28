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
    /// Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte volumes do not support ownership management or SELinux relabeling.
    /// </summary>
    [DataContract]
    public partial class V1QuobyteVolumeSource :  IEquatable<V1QuobyteVolumeSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1QuobyteVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1QuobyteVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1QuobyteVolumeSource" /> class.
        /// </summary>
        /// <param name="Group">Group to map volume access to Default is no group.</param>
        /// <param name="_ReadOnly">ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false..</param>
        /// <param name="Registry">Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes (required).</param>
        /// <param name="User">User to map volume access to Defaults to serivceaccount user.</param>
        /// <param name="Volume">Volume is a string that references an already created Quobyte volume by name. (required).</param>
        public V1QuobyteVolumeSource(string Group = default(string), bool? _ReadOnly = default(bool?), string Registry = default(string), string User = default(string), string Volume = default(string))
        {
            // to ensure "Registry" is required (not null)
            if (Registry == null)
            {
                throw new InvalidDataException("Registry is a required property for V1QuobyteVolumeSource and cannot be null");
            }
            else
            {
                this.Registry = Registry;
            }
            // to ensure "Volume" is required (not null)
            if (Volume == null)
            {
                throw new InvalidDataException("Volume is a required property for V1QuobyteVolumeSource and cannot be null");
            }
            else
            {
                this.Volume = Volume;
            }
            this.Group = Group;
            this._ReadOnly = _ReadOnly;
            this.User = User;
        }
        
        /// <summary>
        /// Group to map volume access to Default is no group
        /// </summary>
        /// <value>Group to map volume access to Default is no group</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.
        /// </summary>
        /// <value>ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }

        /// <summary>
        /// Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes
        /// </summary>
        /// <value>Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes</value>
        [DataMember(Name="registry", EmitDefaultValue=false)]
        public string Registry { get; set; }

        /// <summary>
        /// User to map volume access to Defaults to serivceaccount user
        /// </summary>
        /// <value>User to map volume access to Defaults to serivceaccount user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Volume is a string that references an already created Quobyte volume by name.
        /// </summary>
        /// <value>Volume is a string that references an already created Quobyte volume by name.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public string Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1QuobyteVolumeSource {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  Registry: ").Append(Registry).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
            return this.Equals(obj as V1QuobyteVolumeSource);
        }

        /// <summary>
        /// Returns true if V1QuobyteVolumeSource instances are equal
        /// </summary>
        /// <param name="other">Instance of V1QuobyteVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1QuobyteVolumeSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.Registry == other.Registry ||
                    this.Registry != null &&
                    this.Registry.Equals(other.Registry)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Volume == other.Volume ||
                    this.Volume != null &&
                    this.Volume.Equals(other.Volume)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.Registry != null)
                    hash = hash * 59 + this.Registry.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Volume != null)
                    hash = hash * 59 + this.Volume.GetHashCode();
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
