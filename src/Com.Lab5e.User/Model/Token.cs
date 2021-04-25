/*
 * The User API
 *
 * API to manage teams, members and tokens
 *
 * The version of the OpenAPI document: 1.3.8 indivisible-esau
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
    /// Token
    /// </summary>
    [DataContract(Name = "Token")]
    public partial class Token : IEquatable<Token>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="resource">The resource of the token.  The token applies to the specified resource and any resources below this so the resource &#x60;/&#x60; applies to the root resource and any resource below the root resource. In the same manner &#x60;/collections&#x60; will apply to all collectins while &#x60;/collections/{id}&#x60; will apply to that particular collection..</param>
        /// <param name="write">Write flag for token.  If this is set to &#x60;true&#x60; the token can be used for write operations in the API such as POST, DELETE and PATCH..</param>
        /// <param name="token">Use this in the &#x60;X-API-Token&#x60; header when using the API..</param>
        /// <param name="tags">Tags for the token..</param>
        /// <param name="lastUse">The last time the token was used. Time in ms since epoch..</param>
        /// <param name="uses">uses.</param>
        public Token(string resource = default(string), bool write = default(bool), string token = default(string), Dictionary<string, string> tags = default(Dictionary<string, string>), string lastUse = default(string), string uses = default(string))
        {
            this.Resource = resource;
            this.Write = write;
            this._Token = token;
            this.Tags = tags;
            this.LastUse = lastUse;
            this.Uses = uses;
        }

        /// <summary>
        /// The resource of the token.  The token applies to the specified resource and any resources below this so the resource &#x60;/&#x60; applies to the root resource and any resource below the root resource. In the same manner &#x60;/collections&#x60; will apply to all collectins while &#x60;/collections/{id}&#x60; will apply to that particular collection.
        /// </summary>
        /// <value>The resource of the token.  The token applies to the specified resource and any resources below this so the resource &#x60;/&#x60; applies to the root resource and any resource below the root resource. In the same manner &#x60;/collections&#x60; will apply to all collectins while &#x60;/collections/{id}&#x60; will apply to that particular collection.</value>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public string Resource { get; set; }

        /// <summary>
        /// Write flag for token.  If this is set to &#x60;true&#x60; the token can be used for write operations in the API such as POST, DELETE and PATCH.
        /// </summary>
        /// <value>Write flag for token.  If this is set to &#x60;true&#x60; the token can be used for write operations in the API such as POST, DELETE and PATCH.</value>
        [DataMember(Name = "write", EmitDefaultValue = false)]
        public bool Write { get; set; }

        /// <summary>
        /// Use this in the &#x60;X-API-Token&#x60; header when using the API.
        /// </summary>
        /// <value>Use this in the &#x60;X-API-Token&#x60; header when using the API.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string _Token { get; set; }

        /// <summary>
        /// Tags for the token.
        /// </summary>
        /// <value>Tags for the token.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The last time the token was used. Time in ms since epoch.
        /// </summary>
        /// <value>The last time the token was used. Time in ms since epoch.</value>
        [DataMember(Name = "lastUse", EmitDefaultValue = false)]
        public string LastUse { get; set; }

        /// <summary>
        /// Gets or Sets Uses
        /// </summary>
        [DataMember(Name = "uses", EmitDefaultValue = false)]
        public string Uses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Token {\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Write: ").Append(Write).Append("\n");
            sb.Append("  _Token: ").Append(_Token).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  LastUse: ").Append(LastUse).Append("\n");
            sb.Append("  Uses: ").Append(Uses).Append("\n");
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
            return this.Equals(input as Token);
        }

        /// <summary>
        /// Returns true if Token instances are equal
        /// </summary>
        /// <param name="input">Instance of Token to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Token input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.Write == input.Write ||
                    this.Write.Equals(input.Write)
                ) && 
                (
                    this._Token == input._Token ||
                    (this._Token != null &&
                    this._Token.Equals(input._Token))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.LastUse == input.LastUse ||
                    (this.LastUse != null &&
                    this.LastUse.Equals(input.LastUse))
                ) && 
                (
                    this.Uses == input.Uses ||
                    (this.Uses != null &&
                    this.Uses.Equals(input.Uses))
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
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                hashCode = hashCode * 59 + this.Write.GetHashCode();
                if (this._Token != null)
                    hashCode = hashCode * 59 + this._Token.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.LastUse != null)
                    hashCode = hashCode * 59 + this.LastUse.GetHashCode();
                if (this.Uses != null)
                    hashCode = hashCode * 59 + this.Uses.GetHashCode();
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
