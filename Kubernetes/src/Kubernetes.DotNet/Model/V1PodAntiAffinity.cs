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
    /// Pod anti affinity is a group of inter pod anti affinity scheduling rules.
    /// </summary>
    [DataContract]
    public partial class V1PodAntiAffinity :  IEquatable<V1PodAntiAffinity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PodAntiAffinity" /> class.
        /// </summary>
        /// <param name="PreferredDuringSchedulingIgnoredDuringExecution">The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \&quot;weight\&quot; to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred..</param>
        /// <param name="RequiredDuringSchedulingIgnoredDuringExecution">NOT YET IMPLEMENTED. TODO: Uncomment field once it is implemented. If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system will try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied. RequiredDuringSchedulingRequiredDuringExecution []PodAffinityTerm  &#x60;json:\&quot;requiredDuringSchedulingRequiredDuringExecution,omitempty\&quot;&#x60; If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied..</param>
        public V1PodAntiAffinity(List<V1WeightedPodAffinityTerm> PreferredDuringSchedulingIgnoredDuringExecution = default(List<V1WeightedPodAffinityTerm>), List<V1PodAffinityTerm> RequiredDuringSchedulingIgnoredDuringExecution = default(List<V1PodAffinityTerm>))
        {
            this.PreferredDuringSchedulingIgnoredDuringExecution = PreferredDuringSchedulingIgnoredDuringExecution;
            this.RequiredDuringSchedulingIgnoredDuringExecution = RequiredDuringSchedulingIgnoredDuringExecution;
        }
        
        /// <summary>
        /// The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \&quot;weight\&quot; to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
        /// </summary>
        /// <value>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \&quot;weight\&quot; to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</value>
        [DataMember(Name="preferredDuringSchedulingIgnoredDuringExecution", EmitDefaultValue=false)]
        public List<V1WeightedPodAffinityTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>
        /// NOT YET IMPLEMENTED. TODO: Uncomment field once it is implemented. If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system will try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied. RequiredDuringSchedulingRequiredDuringExecution []PodAffinityTerm  &#x60;json:\&quot;requiredDuringSchedulingRequiredDuringExecution,omitempty\&quot;&#x60; If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
        /// </summary>
        /// <value>NOT YET IMPLEMENTED. TODO: Uncomment field once it is implemented. If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system will try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied. RequiredDuringSchedulingRequiredDuringExecution []PodAffinityTerm  &#x60;json:\&quot;requiredDuringSchedulingRequiredDuringExecution,omitempty\&quot;&#x60; If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</value>
        [DataMember(Name="requiredDuringSchedulingIgnoredDuringExecution", EmitDefaultValue=false)]
        public List<V1PodAffinityTerm> RequiredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PodAntiAffinity {\n");
            sb.Append("  PreferredDuringSchedulingIgnoredDuringExecution: ").Append(PreferredDuringSchedulingIgnoredDuringExecution).Append("\n");
            sb.Append("  RequiredDuringSchedulingIgnoredDuringExecution: ").Append(RequiredDuringSchedulingIgnoredDuringExecution).Append("\n");
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
            return this.Equals(obj as V1PodAntiAffinity);
        }

        /// <summary>
        /// Returns true if V1PodAntiAffinity instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PodAntiAffinity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PodAntiAffinity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PreferredDuringSchedulingIgnoredDuringExecution == other.PreferredDuringSchedulingIgnoredDuringExecution ||
                    this.PreferredDuringSchedulingIgnoredDuringExecution != null &&
                    this.PreferredDuringSchedulingIgnoredDuringExecution.SequenceEqual(other.PreferredDuringSchedulingIgnoredDuringExecution)
                ) && 
                (
                    this.RequiredDuringSchedulingIgnoredDuringExecution == other.RequiredDuringSchedulingIgnoredDuringExecution ||
                    this.RequiredDuringSchedulingIgnoredDuringExecution != null &&
                    this.RequiredDuringSchedulingIgnoredDuringExecution.SequenceEqual(other.RequiredDuringSchedulingIgnoredDuringExecution)
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
                if (this.PreferredDuringSchedulingIgnoredDuringExecution != null)
                    hash = hash * 59 + this.PreferredDuringSchedulingIgnoredDuringExecution.GetHashCode();
                if (this.RequiredDuringSchedulingIgnoredDuringExecution != null)
                    hash = hash * 59 + this.RequiredDuringSchedulingIgnoredDuringExecution.GetHashCode();
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
