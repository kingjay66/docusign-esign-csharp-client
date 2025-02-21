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
    /// PaymentGatewayAccountSetting
    /// </summary>
    [DataContract]
    public partial class PaymentGatewayAccountSetting :  IEquatable<PaymentGatewayAccountSetting>, IValidatableObject
    {
        public PaymentGatewayAccountSetting()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentGatewayAccountSetting" /> class.
        /// </summary>
        /// <param name="ApiFields">ApiFields.</param>
        /// <param name="AuthorizationCode">AuthorizationCode.</param>
        /// <param name="CredentialStatus">CredentialStatus.</param>
        /// <param name="MerchantId">MerchantId.</param>
        public PaymentGatewayAccountSetting(string ApiFields = default(string), string AuthorizationCode = default(string), string CredentialStatus = default(string), string MerchantId = default(string))
        {
            this.ApiFields = ApiFields;
            this.AuthorizationCode = AuthorizationCode;
            this.CredentialStatus = CredentialStatus;
            this.MerchantId = MerchantId;
        }
        
        /// <summary>
        /// Gets or Sets ApiFields
        /// </summary>
        [DataMember(Name="apiFields", EmitDefaultValue=false)]
        public string ApiFields { get; set; }
        /// <summary>
        /// Gets or Sets AuthorizationCode
        /// </summary>
        [DataMember(Name="authorizationCode", EmitDefaultValue=false)]
        public string AuthorizationCode { get; set; }
        /// <summary>
        /// Gets or Sets CredentialStatus
        /// </summary>
        [DataMember(Name="credentialStatus", EmitDefaultValue=false)]
        public string CredentialStatus { get; set; }
        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name="merchantId", EmitDefaultValue=false)]
        public string MerchantId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentGatewayAccountSetting {\n");
            sb.Append("  ApiFields: ").Append(ApiFields).Append("\n");
            sb.Append("  AuthorizationCode: ").Append(AuthorizationCode).Append("\n");
            sb.Append("  CredentialStatus: ").Append(CredentialStatus).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
            return this.Equals(obj as PaymentGatewayAccountSetting);
        }

        /// <summary>
        /// Returns true if PaymentGatewayAccountSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentGatewayAccountSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentGatewayAccountSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiFields == other.ApiFields ||
                    this.ApiFields != null &&
                    this.ApiFields.Equals(other.ApiFields)
                ) && 
                (
                    this.AuthorizationCode == other.AuthorizationCode ||
                    this.AuthorizationCode != null &&
                    this.AuthorizationCode.Equals(other.AuthorizationCode)
                ) && 
                (
                    this.CredentialStatus == other.CredentialStatus ||
                    this.CredentialStatus != null &&
                    this.CredentialStatus.Equals(other.CredentialStatus)
                ) && 
                (
                    this.MerchantId == other.MerchantId ||
                    this.MerchantId != null &&
                    this.MerchantId.Equals(other.MerchantId)
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
                if (this.ApiFields != null)
                    hash = hash * 59 + this.ApiFields.GetHashCode();
                if (this.AuthorizationCode != null)
                    hash = hash * 59 + this.AuthorizationCode.GetHashCode();
                if (this.CredentialStatus != null)
                    hash = hash * 59 + this.CredentialStatus.GetHashCode();
                if (this.MerchantId != null)
                    hash = hash * 59 + this.MerchantId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
