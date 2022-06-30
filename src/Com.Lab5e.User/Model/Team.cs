/*
 * The User API
 *
 * API to manage teams, members and tokens
 *
 * The version of the OpenAPI document: 1.3.13 bordering-jerilyn
 * Contact: dev@lab5e.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Lab5e.User.Client.OpenAPIDateConverter;

namespace Com.Lab5e.User.Model
{
    /// <summary>
    /// Team
    /// </summary>
    [DataContract(Name = "Team")]
    public partial class Team : IEquatable<Team>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="teamId">teamId.</param>
        /// <param name="isPrivate">isPrivate.</param>
        /// <param name="tags">tags.</param>
        /// <param name="members">members.</param>
        public Team(string teamId = default(string), bool isPrivate = default(bool), Dictionary<string, string> tags = default(Dictionary<string, string>), List<Member> members = default(List<Member>))
        {
            this.TeamId = teamId;
            this.IsPrivate = isPrivate;
            this.Tags = tags;
            this.Members = members;
        }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name = "isPrivate", EmitDefaultValue = false)]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = false)]
        public List<Member> Members { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Team {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Team);
        }

        /// <summary>
        /// Returns true if Team instances are equal
        /// </summary>
        /// <param name="input">Instance of Team to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Team input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.IsPrivate == input.IsPrivate ||
                    this.IsPrivate.Equals(input.IsPrivate)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                return hashCode;
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
