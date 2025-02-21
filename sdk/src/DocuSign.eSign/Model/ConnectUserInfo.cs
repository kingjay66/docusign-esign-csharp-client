/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// ConnectUserInfo
    /// </summary>
    [DataContract]
    public partial class ConnectUserInfo :  IEquatable<ConnectUserInfo>, IValidatableObject
    {
        public ConnectUserInfo()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectUserInfo" /> class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="IsIncluded">IsIncluded.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserName">UserName.</param>
        public ConnectUserInfo(string Email = default(string), string IsIncluded = default(string), string UserId = default(string), string UserName = default(string))
        {
            this.Email = Email;
            this.IsIncluded = IsIncluded;
            this.UserId = UserId;
            this.UserName = UserName;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets IsIncluded
        /// </summary>
        [DataMember(Name="isIncluded", EmitDefaultValue=false)]
        public string IsIncluded { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectUserInfo {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsIncluded: ").Append(IsIncluded).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(obj as ConnectUserInfo);
        }

        /// <summary>
        /// Returns true if ConnectUserInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectUserInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.IsIncluded == other.IsIncluded ||
                    this.IsIncluded != null &&
                    this.IsIncluded.Equals(other.IsIncluded)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.IsIncluded != null)
                    hash = hash * 59 + this.IsIncluded.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
