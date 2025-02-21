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
    /// DocumentHtmlDefinitionOriginal
    /// </summary>
    [DataContract]
    public partial class DocumentHtmlDefinitionOriginal :  IEquatable<DocumentHtmlDefinitionOriginal>, IValidatableObject
    {
        public DocumentHtmlDefinitionOriginal()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentHtmlDefinitionOriginal" /> class.
        /// </summary>
        /// <param name="DocumentId">Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute..</param>
        /// <param name="DocumentIdGuid">DocumentIdGuid.</param>
        /// <param name="HtmlDefinition">Defines how to generate the responsive-formatted HTML for the document..</param>
        public DocumentHtmlDefinitionOriginal(string DocumentId = default(string), string DocumentIdGuid = default(string), DocumentHtmlDefinition HtmlDefinition = default(DocumentHtmlDefinition))
        {
            this.DocumentId = DocumentId;
            this.DocumentIdGuid = DocumentIdGuid;
            this.HtmlDefinition = HtmlDefinition;
        }
        
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
        /// <summary>
        /// Gets or Sets DocumentIdGuid
        /// </summary>
        [DataMember(Name="documentIdGuid", EmitDefaultValue=false)]
        public string DocumentIdGuid { get; set; }
        /// <summary>
        /// Defines how to generate the responsive-formatted HTML for the document.
        /// </summary>
        /// <value>Defines how to generate the responsive-formatted HTML for the document.</value>
        [DataMember(Name="htmlDefinition", EmitDefaultValue=false)]
        public DocumentHtmlDefinition HtmlDefinition { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentHtmlDefinitionOriginal {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentIdGuid: ").Append(DocumentIdGuid).Append("\n");
            sb.Append("  HtmlDefinition: ").Append(HtmlDefinition).Append("\n");
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
            return this.Equals(obj as DocumentHtmlDefinitionOriginal);
        }

        /// <summary>
        /// Returns true if DocumentHtmlDefinitionOriginal instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentHtmlDefinitionOriginal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentHtmlDefinitionOriginal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.DocumentIdGuid == other.DocumentIdGuid ||
                    this.DocumentIdGuid != null &&
                    this.DocumentIdGuid.Equals(other.DocumentIdGuid)
                ) && 
                (
                    this.HtmlDefinition == other.HtmlDefinition ||
                    this.HtmlDefinition != null &&
                    this.HtmlDefinition.Equals(other.HtmlDefinition)
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
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.DocumentIdGuid != null)
                    hash = hash * 59 + this.DocumentIdGuid.GetHashCode();
                if (this.HtmlDefinition != null)
                    hash = hash * 59 + this.HtmlDefinition.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
