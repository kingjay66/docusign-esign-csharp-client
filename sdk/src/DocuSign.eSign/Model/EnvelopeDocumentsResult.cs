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
    /// EnvelopeDocumentsResult
    /// </summary>
    [DataContract]
    public partial class EnvelopeDocumentsResult :  IEquatable<EnvelopeDocumentsResult>, IValidatableObject
    {
        public EnvelopeDocumentsResult()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeDocumentsResult" /> class.
        /// </summary>
        /// <param name="EnvelopeDocuments">EnvelopeDocuments.</param>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        public EnvelopeDocumentsResult(List<EnvelopeDocument> EnvelopeDocuments = default(List<EnvelopeDocument>), string EnvelopeId = default(string))
        {
            this.EnvelopeDocuments = EnvelopeDocuments;
            this.EnvelopeId = EnvelopeId;
        }
        
        /// <summary>
        /// Gets or Sets EnvelopeDocuments
        /// </summary>
        [DataMember(Name="envelopeDocuments", EmitDefaultValue=false)]
        public List<EnvelopeDocument> EnvelopeDocuments { get; set; }
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeDocumentsResult {\n");
            sb.Append("  EnvelopeDocuments: ").Append(EnvelopeDocuments).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
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
            return this.Equals(obj as EnvelopeDocumentsResult);
        }

        /// <summary>
        /// Returns true if EnvelopeDocumentsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeDocumentsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeDocumentsResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnvelopeDocuments == other.EnvelopeDocuments ||
                    this.EnvelopeDocuments != null &&
                    this.EnvelopeDocuments.SequenceEqual(other.EnvelopeDocuments)
                ) && 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
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
                if (this.EnvelopeDocuments != null)
                    hash = hash * 59 + this.EnvelopeDocuments.GetHashCode();
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
