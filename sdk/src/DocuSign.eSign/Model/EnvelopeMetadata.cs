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
    /// EnvelopeMetadata
    /// </summary>
    [DataContract]
    public partial class EnvelopeMetadata :  IEquatable<EnvelopeMetadata>, IValidatableObject
    {
        public EnvelopeMetadata()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeMetadata" /> class.
        /// </summary>
        /// <param name="AllowAdvancedCorrect">AllowAdvancedCorrect.</param>
        /// <param name="AllowCorrect">AllowCorrect.</param>
        /// <param name="EnableSignWithNotary">EnableSignWithNotary.</param>
        public EnvelopeMetadata(string AllowAdvancedCorrect = default(string), string AllowCorrect = default(string), string EnableSignWithNotary = default(string))
        {
            this.AllowAdvancedCorrect = AllowAdvancedCorrect;
            this.AllowCorrect = AllowCorrect;
            this.EnableSignWithNotary = EnableSignWithNotary;
        }
        
        /// <summary>
        /// Gets or Sets AllowAdvancedCorrect
        /// </summary>
        [DataMember(Name="allowAdvancedCorrect", EmitDefaultValue=false)]
        public string AllowAdvancedCorrect { get; set; }
        /// <summary>
        /// Gets or Sets AllowCorrect
        /// </summary>
        [DataMember(Name="allowCorrect", EmitDefaultValue=false)]
        public string AllowCorrect { get; set; }
        /// <summary>
        /// Gets or Sets EnableSignWithNotary
        /// </summary>
        [DataMember(Name="enableSignWithNotary", EmitDefaultValue=false)]
        public string EnableSignWithNotary { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeMetadata {\n");
            sb.Append("  AllowAdvancedCorrect: ").Append(AllowAdvancedCorrect).Append("\n");
            sb.Append("  AllowCorrect: ").Append(AllowCorrect).Append("\n");
            sb.Append("  EnableSignWithNotary: ").Append(EnableSignWithNotary).Append("\n");
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
            return this.Equals(obj as EnvelopeMetadata);
        }

        /// <summary>
        /// Returns true if EnvelopeMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowAdvancedCorrect == other.AllowAdvancedCorrect ||
                    this.AllowAdvancedCorrect != null &&
                    this.AllowAdvancedCorrect.Equals(other.AllowAdvancedCorrect)
                ) && 
                (
                    this.AllowCorrect == other.AllowCorrect ||
                    this.AllowCorrect != null &&
                    this.AllowCorrect.Equals(other.AllowCorrect)
                ) && 
                (
                    this.EnableSignWithNotary == other.EnableSignWithNotary ||
                    this.EnableSignWithNotary != null &&
                    this.EnableSignWithNotary.Equals(other.EnableSignWithNotary)
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
                if (this.AllowAdvancedCorrect != null)
                    hash = hash * 59 + this.AllowAdvancedCorrect.GetHashCode();
                if (this.AllowCorrect != null)
                    hash = hash * 59 + this.AllowCorrect.GetHashCode();
                if (this.EnableSignWithNotary != null)
                    hash = hash * 59 + this.EnableSignWithNotary.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
