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
    /// SubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
    /// </summary>
    [DataContract]
    public partial class V1beta1SubjectAccessReviewSpec :  IEquatable<V1beta1SubjectAccessReviewSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1SubjectAccessReviewSpec" /> class.
        /// </summary>
        /// <param name="Extra">Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here..</param>
        /// <param name="Group">Groups is the groups you&#39;re testing for..</param>
        /// <param name="NonResourceAttributes">NonResourceAttributes describes information for a non-resource access request.</param>
        /// <param name="ResourceAttributes">ResourceAuthorizationAttributes describes information for a resource access request.</param>
        /// <param name="User">User is the user you&#39;re testing for. If you specify \&quot;User\&quot; but not \&quot;Group\&quot;, then is it interpreted as \&quot;What if User were not a member of any groups.</param>
        public V1beta1SubjectAccessReviewSpec(Dictionary<string, List<string>> Extra = default(Dictionary<string, List<string>>), List<string> Group = default(List<string>), V1beta1NonResourceAttributes NonResourceAttributes = default(V1beta1NonResourceAttributes), V1beta1ResourceAttributes ResourceAttributes = default(V1beta1ResourceAttributes), string User = default(string))
        {
            this.Extra = Extra;
            this.Group = Group;
            this.NonResourceAttributes = NonResourceAttributes;
            this.ResourceAttributes = ResourceAttributes;
            this.User = User;
        }
        
        /// <summary>
        /// Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.
        /// </summary>
        /// <value>Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.</value>
        [DataMember(Name="extra", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Extra { get; set; }

        /// <summary>
        /// Groups is the groups you&#39;re testing for.
        /// </summary>
        /// <value>Groups is the groups you&#39;re testing for.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public List<string> Group { get; set; }

        /// <summary>
        /// NonResourceAttributes describes information for a non-resource access request
        /// </summary>
        /// <value>NonResourceAttributes describes information for a non-resource access request</value>
        [DataMember(Name="nonResourceAttributes", EmitDefaultValue=false)]
        public V1beta1NonResourceAttributes NonResourceAttributes { get; set; }

        /// <summary>
        /// ResourceAuthorizationAttributes describes information for a resource access request
        /// </summary>
        /// <value>ResourceAuthorizationAttributes describes information for a resource access request</value>
        [DataMember(Name="resourceAttributes", EmitDefaultValue=false)]
        public V1beta1ResourceAttributes ResourceAttributes { get; set; }

        /// <summary>
        /// User is the user you&#39;re testing for. If you specify \&quot;User\&quot; but not \&quot;Group\&quot;, then is it interpreted as \&quot;What if User were not a member of any groups
        /// </summary>
        /// <value>User is the user you&#39;re testing for. If you specify \&quot;User\&quot; but not \&quot;Group\&quot;, then is it interpreted as \&quot;What if User were not a member of any groups</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1SubjectAccessReviewSpec {\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  NonResourceAttributes: ").Append(NonResourceAttributes).Append("\n");
            sb.Append("  ResourceAttributes: ").Append(ResourceAttributes).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as V1beta1SubjectAccessReviewSpec);
        }

        /// <summary>
        /// Returns true if V1beta1SubjectAccessReviewSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1SubjectAccessReviewSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1SubjectAccessReviewSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Extra == other.Extra ||
                    this.Extra != null &&
                    this.Extra.SequenceEqual(other.Extra)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(other.Group)
                ) && 
                (
                    this.NonResourceAttributes == other.NonResourceAttributes ||
                    this.NonResourceAttributes != null &&
                    this.NonResourceAttributes.Equals(other.NonResourceAttributes)
                ) && 
                (
                    this.ResourceAttributes == other.ResourceAttributes ||
                    this.ResourceAttributes != null &&
                    this.ResourceAttributes.Equals(other.ResourceAttributes)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Extra != null)
                    hash = hash * 59 + this.Extra.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.NonResourceAttributes != null)
                    hash = hash * 59 + this.NonResourceAttributes.GetHashCode();
                if (this.ResourceAttributes != null)
                    hash = hash * 59 + this.ResourceAttributes.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
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
