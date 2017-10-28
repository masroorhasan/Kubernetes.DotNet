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
    /// ScaleIOVolumeSource represents a persistent ScaleIO volume
    /// </summary>
    [DataContract]
    public partial class V1ScaleIOVolumeSource :  IEquatable<V1ScaleIOVolumeSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ScaleIOVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1ScaleIOVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ScaleIOVolumeSource" /> class.
        /// </summary>
        /// <param name="FsType">Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified..</param>
        /// <param name="Gateway">The host address of the ScaleIO API Gateway. (required).</param>
        /// <param name="ProtectionDomain">The name of the Protection Domain for the configured storage (defaults to \&quot;default\&quot;)..</param>
        /// <param name="_ReadOnly">Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts..</param>
        /// <param name="SecretRef">SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail. (required).</param>
        /// <param name="SslEnabled">Flag to enable/disable SSL communication with Gateway, default false.</param>
        /// <param name="StorageMode">Indicates whether the storage for a volume should be thick or thin (defaults to \&quot;thin\&quot;)..</param>
        /// <param name="StoragePool">The Storage Pool associated with the protection domain (defaults to \&quot;default\&quot;)..</param>
        /// <param name="System">The name of the storage system as configured in ScaleIO. (required).</param>
        /// <param name="VolumeName">The name of a volume already created in the ScaleIO system that is associated with this volume source..</param>
        public V1ScaleIOVolumeSource(string FsType = default(string), string Gateway = default(string), string ProtectionDomain = default(string), bool? _ReadOnly = default(bool?), V1LocalObjectReference SecretRef = default(V1LocalObjectReference), bool? SslEnabled = default(bool?), string StorageMode = default(string), string StoragePool = default(string), string System = default(string), string VolumeName = default(string))
        {
            // to ensure "Gateway" is required (not null)
            if (Gateway == null)
            {
                throw new InvalidDataException("Gateway is a required property for V1ScaleIOVolumeSource and cannot be null");
            }
            else
            {
                this.Gateway = Gateway;
            }
            // to ensure "SecretRef" is required (not null)
            if (SecretRef == null)
            {
                throw new InvalidDataException("SecretRef is a required property for V1ScaleIOVolumeSource and cannot be null");
            }
            else
            {
                this.SecretRef = SecretRef;
            }
            // to ensure "System" is required (not null)
            if (System == null)
            {
                throw new InvalidDataException("System is a required property for V1ScaleIOVolumeSource and cannot be null");
            }
            else
            {
                this.System = System;
            }
            this.FsType = FsType;
            this.ProtectionDomain = ProtectionDomain;
            this._ReadOnly = _ReadOnly;
            this.SslEnabled = SslEnabled;
            this.StorageMode = StorageMode;
            this.StoragePool = StoragePool;
            this.VolumeName = VolumeName;
        }
        
        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.
        /// </summary>
        /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.</value>
        [DataMember(Name="fsType", EmitDefaultValue=false)]
        public string FsType { get; set; }

        /// <summary>
        /// The host address of the ScaleIO API Gateway.
        /// </summary>
        /// <value>The host address of the ScaleIO API Gateway.</value>
        [DataMember(Name="gateway", EmitDefaultValue=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// The name of the Protection Domain for the configured storage (defaults to \&quot;default\&quot;).
        /// </summary>
        /// <value>The name of the Protection Domain for the configured storage (defaults to \&quot;default\&quot;).</value>
        [DataMember(Name="protectionDomain", EmitDefaultValue=false)]
        public string ProtectionDomain { get; set; }

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }

        /// <summary>
        /// SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.
        /// </summary>
        /// <value>SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.</value>
        [DataMember(Name="secretRef", EmitDefaultValue=false)]
        public V1LocalObjectReference SecretRef { get; set; }

        /// <summary>
        /// Flag to enable/disable SSL communication with Gateway, default false
        /// </summary>
        /// <value>Flag to enable/disable SSL communication with Gateway, default false</value>
        [DataMember(Name="sslEnabled", EmitDefaultValue=false)]
        public bool? SslEnabled { get; set; }

        /// <summary>
        /// Indicates whether the storage for a volume should be thick or thin (defaults to \&quot;thin\&quot;).
        /// </summary>
        /// <value>Indicates whether the storage for a volume should be thick or thin (defaults to \&quot;thin\&quot;).</value>
        [DataMember(Name="storageMode", EmitDefaultValue=false)]
        public string StorageMode { get; set; }

        /// <summary>
        /// The Storage Pool associated with the protection domain (defaults to \&quot;default\&quot;).
        /// </summary>
        /// <value>The Storage Pool associated with the protection domain (defaults to \&quot;default\&quot;).</value>
        [DataMember(Name="storagePool", EmitDefaultValue=false)]
        public string StoragePool { get; set; }

        /// <summary>
        /// The name of the storage system as configured in ScaleIO.
        /// </summary>
        /// <value>The name of the storage system as configured in ScaleIO.</value>
        [DataMember(Name="system", EmitDefaultValue=false)]
        public string System { get; set; }

        /// <summary>
        /// The name of a volume already created in the ScaleIO system that is associated with this volume source.
        /// </summary>
        /// <value>The name of a volume already created in the ScaleIO system that is associated with this volume source.</value>
        [DataMember(Name="volumeName", EmitDefaultValue=false)]
        public string VolumeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ScaleIOVolumeSource {\n");
            sb.Append("  FsType: ").Append(FsType).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  ProtectionDomain: ").Append(ProtectionDomain).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
            sb.Append("  SslEnabled: ").Append(SslEnabled).Append("\n");
            sb.Append("  StorageMode: ").Append(StorageMode).Append("\n");
            sb.Append("  StoragePool: ").Append(StoragePool).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  VolumeName: ").Append(VolumeName).Append("\n");
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
            return this.Equals(obj as V1ScaleIOVolumeSource);
        }

        /// <summary>
        /// Returns true if V1ScaleIOVolumeSource instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ScaleIOVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ScaleIOVolumeSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FsType == other.FsType ||
                    this.FsType != null &&
                    this.FsType.Equals(other.FsType)
                ) && 
                (
                    this.Gateway == other.Gateway ||
                    this.Gateway != null &&
                    this.Gateway.Equals(other.Gateway)
                ) && 
                (
                    this.ProtectionDomain == other.ProtectionDomain ||
                    this.ProtectionDomain != null &&
                    this.ProtectionDomain.Equals(other.ProtectionDomain)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.SecretRef == other.SecretRef ||
                    this.SecretRef != null &&
                    this.SecretRef.Equals(other.SecretRef)
                ) && 
                (
                    this.SslEnabled == other.SslEnabled ||
                    this.SslEnabled != null &&
                    this.SslEnabled.Equals(other.SslEnabled)
                ) && 
                (
                    this.StorageMode == other.StorageMode ||
                    this.StorageMode != null &&
                    this.StorageMode.Equals(other.StorageMode)
                ) && 
                (
                    this.StoragePool == other.StoragePool ||
                    this.StoragePool != null &&
                    this.StoragePool.Equals(other.StoragePool)
                ) && 
                (
                    this.System == other.System ||
                    this.System != null &&
                    this.System.Equals(other.System)
                ) && 
                (
                    this.VolumeName == other.VolumeName ||
                    this.VolumeName != null &&
                    this.VolumeName.Equals(other.VolumeName)
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
                if (this.FsType != null)
                    hash = hash * 59 + this.FsType.GetHashCode();
                if (this.Gateway != null)
                    hash = hash * 59 + this.Gateway.GetHashCode();
                if (this.ProtectionDomain != null)
                    hash = hash * 59 + this.ProtectionDomain.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.SecretRef != null)
                    hash = hash * 59 + this.SecretRef.GetHashCode();
                if (this.SslEnabled != null)
                    hash = hash * 59 + this.SslEnabled.GetHashCode();
                if (this.StorageMode != null)
                    hash = hash * 59 + this.StorageMode.GetHashCode();
                if (this.StoragePool != null)
                    hash = hash * 59 + this.StoragePool.GetHashCode();
                if (this.System != null)
                    hash = hash * 59 + this.System.GetHashCode();
                if (this.VolumeName != null)
                    hash = hash * 59 + this.VolumeName.GetHashCode();
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
