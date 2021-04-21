/*
 * The User API
 *
 * API to manage teams, members and tokens
 *
 * The version of the OpenAPI document: 1.3.7 frequent-amara
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
    /// DeleteInviteResponse
    /// </summary>
    [DataContract(Name = "DeleteInviteResponse")]
    public partial class DeleteInviteResponse : IEquatable<DeleteInviteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInviteResponse" /> class.
        /// </summary>
        /// <param name="invite">invite.</param>
        public DeleteInviteResponse(Invite invite = default(Invite))
        {
            this.Invite = invite;
        }

        /// <summary>
        /// Gets or Sets Invite
        /// </summary>
        [DataMember(Name = "invite", EmitDefaultValue = false)]
        public Invite Invite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInviteResponse {\n");
            sb.Append("  Invite: ").Append(Invite).Append("\n");
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
            return this.Equals(input as DeleteInviteResponse);
        }

        /// <summary>
        /// Returns true if DeleteInviteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteInviteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteInviteResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invite == input.Invite ||
                    (this.Invite != null &&
                    this.Invite.Equals(input.Invite))
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
                if (this.Invite != null)
                    hashCode = hashCode * 59 + this.Invite.GetHashCode();
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
