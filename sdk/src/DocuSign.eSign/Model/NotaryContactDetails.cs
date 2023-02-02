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
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// NotaryContactDetails
    /// </summary>
    [DataContract]
    public partial class NotaryContactDetails :  IEquatable<NotaryContactDetails>, IValidatableObject
    {
        public NotaryContactDetails()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotaryContactDetails" /> class.
        /// </summary>
        /// <param name="HasDocusignCertificate">HasDocusignCertificate.</param>
        /// <param name="Jurisdictions">Jurisdictions.</param>
        public NotaryContactDetails(string HasDocusignCertificate = default(string), List<JurisdictionSummary> Jurisdictions = default(List<JurisdictionSummary>))
        {
            this.HasDocusignCertificate = HasDocusignCertificate;
            this.Jurisdictions = Jurisdictions;
        }
        
        /// <summary>
        /// Gets or Sets HasDocusignCertificate
        /// </summary>
        [DataMember(Name="hasDocusignCertificate", EmitDefaultValue=false)]
        public string HasDocusignCertificate { get; set; }
        /// <summary>
        /// Gets or Sets Jurisdictions
        /// </summary>
        [DataMember(Name="jurisdictions", EmitDefaultValue=false)]
        public List<JurisdictionSummary> Jurisdictions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotaryContactDetails {\n");
            sb.Append("  HasDocusignCertificate: ").Append(HasDocusignCertificate).Append("\n");
            sb.Append("  Jurisdictions: ").Append(Jurisdictions).Append("\n");
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
            return this.Equals(obj as NotaryContactDetails);
        }

        /// <summary>
        /// Returns true if NotaryContactDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of NotaryContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotaryContactDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HasDocusignCertificate == other.HasDocusignCertificate ||
                    this.HasDocusignCertificate != null &&
                    this.HasDocusignCertificate.Equals(other.HasDocusignCertificate)
                ) && 
                (
                    this.Jurisdictions == other.Jurisdictions ||
                    this.Jurisdictions != null &&
                    this.Jurisdictions.SequenceEqual(other.Jurisdictions)
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
                if (this.HasDocusignCertificate != null)
                    hash = hash * 59 + this.HasDocusignCertificate.GetHashCode();
                if (this.Jurisdictions != null)
                    hash = hash * 59 + this.Jurisdictions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
