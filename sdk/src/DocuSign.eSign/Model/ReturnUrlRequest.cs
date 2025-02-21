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
    /// The request body for the [EnvelopeViews: createSender](/docs/esign-rest-api/reference/envelopes/envelopeviews/createsender/) method.
    /// </summary>
    [DataContract]
    public partial class ReturnUrlRequest :  IEquatable<ReturnUrlRequest>, IValidatableObject
    {
        public ReturnUrlRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnUrlRequest" /> class.
        /// </summary>
        /// <param name="ReturnUrl">Identifies the return point after sending the envelope. DocuSign returns to the URL and includes an event parameter that can be used to redirect the recipient to another location. The possible event parameters returned are:   * send (user sends the envelope) * save (user saves the envelope) * cancel (user cancels the sending transaction. No envelopeId is returned in this case.) * error (there is an error when performing the send) * sessionEnd (the sending session ends before the user completes another action)..</param>
        public ReturnUrlRequest(string ReturnUrl = default(string))
        {
            this.ReturnUrl = ReturnUrl;
        }
        
        /// <summary>
        /// Identifies the return point after sending the envelope. DocuSign returns to the URL and includes an event parameter that can be used to redirect the recipient to another location. The possible event parameters returned are:   * send (user sends the envelope) * save (user saves the envelope) * cancel (user cancels the sending transaction. No envelopeId is returned in this case.) * error (there is an error when performing the send) * sessionEnd (the sending session ends before the user completes another action).
        /// </summary>
        /// <value>Identifies the return point after sending the envelope. DocuSign returns to the URL and includes an event parameter that can be used to redirect the recipient to another location. The possible event parameters returned are:   * send (user sends the envelope) * save (user saves the envelope) * cancel (user cancels the sending transaction. No envelopeId is returned in this case.) * error (there is an error when performing the send) * sessionEnd (the sending session ends before the user completes another action).</value>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturnUrlRequest {\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
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
            return this.Equals(obj as ReturnUrlRequest);
        }

        /// <summary>
        /// Returns true if ReturnUrlRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReturnUrlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturnUrlRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
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
                if (this.ReturnUrl != null)
                    hash = hash * 59 + this.ReturnUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
