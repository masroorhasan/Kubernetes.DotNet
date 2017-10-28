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
    /// Info contains versioning information. how we&#39;ll want to distribute that information.
    /// </summary>
    [DataContract]
    public partial class VersionInfo :  IEquatable<VersionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VersionInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfo" /> class.
        /// </summary>
        /// <param name="BuildDate">BuildDate (required).</param>
        /// <param name="Compiler">Compiler (required).</param>
        /// <param name="GitCommit">GitCommit (required).</param>
        /// <param name="GitTreeState">GitTreeState (required).</param>
        /// <param name="GitVersion">GitVersion (required).</param>
        /// <param name="GoVersion">GoVersion (required).</param>
        /// <param name="Major">Major (required).</param>
        /// <param name="Minor">Minor (required).</param>
        /// <param name="Platform">Platform (required).</param>
        public VersionInfo(string BuildDate = default(string), string Compiler = default(string), string GitCommit = default(string), string GitTreeState = default(string), string GitVersion = default(string), string GoVersion = default(string), string Major = default(string), string Minor = default(string), string Platform = default(string))
        {
            // to ensure "BuildDate" is required (not null)
            if (BuildDate == null)
            {
                throw new InvalidDataException("BuildDate is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.BuildDate = BuildDate;
            }
            // to ensure "Compiler" is required (not null)
            if (Compiler == null)
            {
                throw new InvalidDataException("Compiler is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.Compiler = Compiler;
            }
            // to ensure "GitCommit" is required (not null)
            if (GitCommit == null)
            {
                throw new InvalidDataException("GitCommit is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.GitCommit = GitCommit;
            }
            // to ensure "GitTreeState" is required (not null)
            if (GitTreeState == null)
            {
                throw new InvalidDataException("GitTreeState is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.GitTreeState = GitTreeState;
            }
            // to ensure "GitVersion" is required (not null)
            if (GitVersion == null)
            {
                throw new InvalidDataException("GitVersion is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.GitVersion = GitVersion;
            }
            // to ensure "GoVersion" is required (not null)
            if (GoVersion == null)
            {
                throw new InvalidDataException("GoVersion is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.GoVersion = GoVersion;
            }
            // to ensure "Major" is required (not null)
            if (Major == null)
            {
                throw new InvalidDataException("Major is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.Major = Major;
            }
            // to ensure "Minor" is required (not null)
            if (Minor == null)
            {
                throw new InvalidDataException("Minor is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.Minor = Minor;
            }
            // to ensure "Platform" is required (not null)
            if (Platform == null)
            {
                throw new InvalidDataException("Platform is a required property for VersionInfo and cannot be null");
            }
            else
            {
                this.Platform = Platform;
            }
        }
        
        /// <summary>
        /// Gets or Sets BuildDate
        /// </summary>
        [DataMember(Name="buildDate", EmitDefaultValue=false)]
        public string BuildDate { get; set; }

        /// <summary>
        /// Gets or Sets Compiler
        /// </summary>
        [DataMember(Name="compiler", EmitDefaultValue=false)]
        public string Compiler { get; set; }

        /// <summary>
        /// Gets or Sets GitCommit
        /// </summary>
        [DataMember(Name="gitCommit", EmitDefaultValue=false)]
        public string GitCommit { get; set; }

        /// <summary>
        /// Gets or Sets GitTreeState
        /// </summary>
        [DataMember(Name="gitTreeState", EmitDefaultValue=false)]
        public string GitTreeState { get; set; }

        /// <summary>
        /// Gets or Sets GitVersion
        /// </summary>
        [DataMember(Name="gitVersion", EmitDefaultValue=false)]
        public string GitVersion { get; set; }

        /// <summary>
        /// Gets or Sets GoVersion
        /// </summary>
        [DataMember(Name="goVersion", EmitDefaultValue=false)]
        public string GoVersion { get; set; }

        /// <summary>
        /// Gets or Sets Major
        /// </summary>
        [DataMember(Name="major", EmitDefaultValue=false)]
        public string Major { get; set; }

        /// <summary>
        /// Gets or Sets Minor
        /// </summary>
        [DataMember(Name="minor", EmitDefaultValue=false)]
        public string Minor { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionInfo {\n");
            sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
            sb.Append("  Compiler: ").Append(Compiler).Append("\n");
            sb.Append("  GitCommit: ").Append(GitCommit).Append("\n");
            sb.Append("  GitTreeState: ").Append(GitTreeState).Append("\n");
            sb.Append("  GitVersion: ").Append(GitVersion).Append("\n");
            sb.Append("  GoVersion: ").Append(GoVersion).Append("\n");
            sb.Append("  Major: ").Append(Major).Append("\n");
            sb.Append("  Minor: ").Append(Minor).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            return this.Equals(obj as VersionInfo);
        }

        /// <summary>
        /// Returns true if VersionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of VersionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BuildDate == other.BuildDate ||
                    this.BuildDate != null &&
                    this.BuildDate.Equals(other.BuildDate)
                ) && 
                (
                    this.Compiler == other.Compiler ||
                    this.Compiler != null &&
                    this.Compiler.Equals(other.Compiler)
                ) && 
                (
                    this.GitCommit == other.GitCommit ||
                    this.GitCommit != null &&
                    this.GitCommit.Equals(other.GitCommit)
                ) && 
                (
                    this.GitTreeState == other.GitTreeState ||
                    this.GitTreeState != null &&
                    this.GitTreeState.Equals(other.GitTreeState)
                ) && 
                (
                    this.GitVersion == other.GitVersion ||
                    this.GitVersion != null &&
                    this.GitVersion.Equals(other.GitVersion)
                ) && 
                (
                    this.GoVersion == other.GoVersion ||
                    this.GoVersion != null &&
                    this.GoVersion.Equals(other.GoVersion)
                ) && 
                (
                    this.Major == other.Major ||
                    this.Major != null &&
                    this.Major.Equals(other.Major)
                ) && 
                (
                    this.Minor == other.Minor ||
                    this.Minor != null &&
                    this.Minor.Equals(other.Minor)
                ) && 
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
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
                if (this.BuildDate != null)
                    hash = hash * 59 + this.BuildDate.GetHashCode();
                if (this.Compiler != null)
                    hash = hash * 59 + this.Compiler.GetHashCode();
                if (this.GitCommit != null)
                    hash = hash * 59 + this.GitCommit.GetHashCode();
                if (this.GitTreeState != null)
                    hash = hash * 59 + this.GitTreeState.GetHashCode();
                if (this.GitVersion != null)
                    hash = hash * 59 + this.GitVersion.GetHashCode();
                if (this.GoVersion != null)
                    hash = hash * 59 + this.GoVersion.GetHashCode();
                if (this.Major != null)
                    hash = hash * 59 + this.Major.GetHashCode();
                if (this.Minor != null)
                    hash = hash * 59 + this.Minor.GetHashCode();
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
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
