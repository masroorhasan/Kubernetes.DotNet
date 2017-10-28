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
    /// Represents a Persistent Disk resource in AWS.  An AWS EBS disk must exist before mounting to a container. The disk must also be in the same AWS zone as the kubelet. An AWS EBS disk can only be mounted as read/write once. AWS EBS volumes support ownership management and SELinux relabeling.
    /// </summary>
    [DataContract]
    public partial class V1AWSElasticBlockStoreVolumeSource :  IEquatable<V1AWSElasticBlockStoreVolumeSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AWSElasticBlockStoreVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1AWSElasticBlockStoreVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AWSElasticBlockStoreVolumeSource" /> class.
        /// </summary>
        /// <param name="FsType">Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore.</param>
        /// <param name="Partition">The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \&quot;1\&quot;. Similarly, the volume partition for /dev/sda is \&quot;0\&quot; (or you can leave the property empty)..</param>
        /// <param name="_ReadOnly">Specify \&quot;true\&quot; to force and set the ReadOnly property in VolumeMounts to \&quot;true\&quot;. If omitted, the default is \&quot;false\&quot;. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore.</param>
        /// <param name="VolumeID">Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore (required).</param>
        public V1AWSElasticBlockStoreVolumeSource(string FsType = default(string), int? Partition = default(int?), bool? _ReadOnly = default(bool?), string VolumeID = default(string))
        {
            // to ensure "VolumeID" is required (not null)
            if (VolumeID == null)
            {
                throw new InvalidDataException("VolumeID is a required property for V1AWSElasticBlockStoreVolumeSource and cannot be null");
            }
            else
            {
                this.VolumeID = VolumeID;
            }
            this.FsType = FsType;
            this.Partition = Partition;
            this._ReadOnly = _ReadOnly;
        }
        
        /// <summary>
        /// Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        /// <value>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</value>
        [DataMember(Name="fsType", EmitDefaultValue=false)]
        public string FsType { get; set; }

        /// <summary>
        /// The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \&quot;1\&quot;. Similarly, the volume partition for /dev/sda is \&quot;0\&quot; (or you can leave the property empty).
        /// </summary>
        /// <value>The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \&quot;1\&quot;. Similarly, the volume partition for /dev/sda is \&quot;0\&quot; (or you can leave the property empty).</value>
        [DataMember(Name="partition", EmitDefaultValue=false)]
        public int? Partition { get; set; }

        /// <summary>
        /// Specify \&quot;true\&quot; to force and set the ReadOnly property in VolumeMounts to \&quot;true\&quot;. If omitted, the default is \&quot;false\&quot;. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        /// <value>Specify \&quot;true\&quot; to force and set the ReadOnly property in VolumeMounts to \&quot;true\&quot;. If omitted, the default is \&quot;false\&quot;. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }

        /// <summary>
        /// Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        /// <value>Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</value>
        [DataMember(Name="volumeID", EmitDefaultValue=false)]
        public string VolumeID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1AWSElasticBlockStoreVolumeSource {\n");
            sb.Append("  FsType: ").Append(FsType).Append("\n");
            sb.Append("  Partition: ").Append(Partition).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  VolumeID: ").Append(VolumeID).Append("\n");
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
            return this.Equals(obj as V1AWSElasticBlockStoreVolumeSource);
        }

        /// <summary>
        /// Returns true if V1AWSElasticBlockStoreVolumeSource instances are equal
        /// </summary>
        /// <param name="other">Instance of V1AWSElasticBlockStoreVolumeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1AWSElasticBlockStoreVolumeSource other)
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
                    this.Partition == other.Partition ||
                    this.Partition != null &&
                    this.Partition.Equals(other.Partition)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.VolumeID == other.VolumeID ||
                    this.VolumeID != null &&
                    this.VolumeID.Equals(other.VolumeID)
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
                if (this.Partition != null)
                    hash = hash * 59 + this.Partition.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.VolumeID != null)
                    hash = hash * 59 + this.VolumeID.GetHashCode();
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
