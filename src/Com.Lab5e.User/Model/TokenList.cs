/*
 * The User API
 *
 * API to manage teams, members and tokens
 *
 * The version of the OpenAPI document: 1.3.9 cumulative-hardin
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
    /// TokenList
    /// </summary>
    [DataContract(Name = "TokenList")]
    public partial class TokenList : IEquatable<TokenList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenList" /> class.
        /// </summary>
        /// <param name="tokens">tokens.</param>
        public TokenList(List<Token> tokens = default(List<Token>))
        {
            this.Tokens = tokens;
        }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name = "tokens", EmitDefaultValue = false)]
        public List<Token> Tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenList {\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
            return this.Equals(input as TokenList);
        }

        /// <summary>
        /// Returns true if TokenList instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    input.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
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
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
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
