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
    /// PageRequest
    /// </summary>
    [DataContract]
    public partial class PageRequest :  IEquatable<PageRequest>, IValidatableObject
    {
        public PageRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageRequest" /> class.
        /// </summary>
        /// <param name="Password">Password.</param>
        /// <param name="Rotate">Sets the direction the page image is rotated. The possible settings are: left or right.</param>
        public PageRequest(string Password = default(string), string Rotate = default(string))
        {
            this.Password = Password;
            this.Rotate = Rotate;
        }
        
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Sets the direction the page image is rotated. The possible settings are: left or right
        /// </summary>
        /// <value>Sets the direction the page image is rotated. The possible settings are: left or right</value>
        [DataMember(Name="rotate", EmitDefaultValue=false)]
        public string Rotate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageRequest {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
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
            return this.Equals(obj as PageRequest);
        }

        /// <summary>
        /// Returns true if PageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Rotate == other.Rotate ||
                    this.Rotate != null &&
                    this.Rotate.Equals(other.Rotate)
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
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Rotate != null)
                    hash = hash * 59 + this.Rotate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
