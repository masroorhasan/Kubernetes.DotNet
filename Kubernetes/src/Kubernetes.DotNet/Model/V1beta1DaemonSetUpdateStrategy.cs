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
    /// V1beta1DaemonSetUpdateStrategy
    /// </summary>
    [DataContract]
    public partial class V1beta1DaemonSetUpdateStrategy :  IEquatable<V1beta1DaemonSetUpdateStrategy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1DaemonSetUpdateStrategy" /> class.
        /// </summary>
        /// <param name="RollingUpdate">Rolling update config params. Present only if type &#x3D; \&quot;RollingUpdate\&quot;..</param>
        /// <param name="Type">Type of daemon set update. Can be \&quot;RollingUpdate\&quot; or \&quot;OnDelete\&quot;. Default is OnDelete..</param>
        public V1beta1DaemonSetUpdateStrategy(V1beta1RollingUpdateDaemonSet RollingUpdate = default(V1beta1RollingUpdateDaemonSet), string Type = default(string))
        {
            this.RollingUpdate = RollingUpdate;
            this.Type = Type;
        }
        
        /// <summary>
        /// Rolling update config params. Present only if type &#x3D; \&quot;RollingUpdate\&quot;.
        /// </summary>
        /// <value>Rolling update config params. Present only if type &#x3D; \&quot;RollingUpdate\&quot;.</value>
        [DataMember(Name="rollingUpdate", EmitDefaultValue=false)]
        public V1beta1RollingUpdateDaemonSet RollingUpdate { get; set; }

        /// <summary>
        /// Type of daemon set update. Can be \&quot;RollingUpdate\&quot; or \&quot;OnDelete\&quot;. Default is OnDelete.
        /// </summary>
        /// <value>Type of daemon set update. Can be \&quot;RollingUpdate\&quot; or \&quot;OnDelete\&quot;. Default is OnDelete.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1DaemonSetUpdateStrategy {\n");
            sb.Append("  RollingUpdate: ").Append(RollingUpdate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as V1beta1DaemonSetUpdateStrategy);
        }

        /// <summary>
        /// Returns true if V1beta1DaemonSetUpdateStrategy instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1DaemonSetUpdateStrategy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1DaemonSetUpdateStrategy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RollingUpdate == other.RollingUpdate ||
                    this.RollingUpdate != null &&
                    this.RollingUpdate.Equals(other.RollingUpdate)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.RollingUpdate != null)
                    hash = hash * 59 + this.RollingUpdate.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
