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
    /// **Note:** For a self-service PowerForm on a website, you can specify the intended recipients generically (for example, use &#x60;Member&#x60; as the &#x60;Name&#x60;), and omit personal details such as &#x60;email&#x60;.
    /// </summary>
    [DataContract]
    public partial class PowerFormRecipient :  IEquatable<PowerFormRecipient>, IValidatableObject
    {
        public PowerFormRecipient()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerFormRecipient" /> class.
        /// </summary>
        /// <param name="AccessCode">If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required..</param>
        /// <param name="AccessCodeLocked">AccessCodeLocked.</param>
        /// <param name="AccessCodeRequired">AccessCodeRequired.</param>
        /// <param name="Email">Email.</param>
        /// <param name="EmailLocked">EmailLocked.</param>
        /// <param name="IdCheckConfigurationName">Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.  *Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as &#39;ID Check $&#39; and &#39;SMS Auth $&#39;. To use ID check in an envelope, the idCheckConfigurationName should be &#39;ID Check &#39;. If you wanted to use SMS, it would be &#39;SMS Auth $&#39; and you would need to add you would need to add phone number information to the &#x60;smsAuthentication&#x60; node..</param>
        /// <param name="IdCheckRequired">IdCheckRequired.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RecipientType">RecipientType.</param>
        /// <param name="RoleName">Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients..</param>
        /// <param name="RoutingOrder">Specifies the routing order of the recipient in the envelope. .</param>
        /// <param name="TemplateRequiresIdLookup">TemplateRequiresIdLookup.</param>
        /// <param name="UserNameLocked">UserNameLocked.</param>
        public PowerFormRecipient(string AccessCode = default(string), string AccessCodeLocked = default(string), string AccessCodeRequired = default(string), string Email = default(string), string EmailLocked = default(string), string IdCheckConfigurationName = default(string), string IdCheckRequired = default(string), string Name = default(string), string RecipientType = default(string), string RoleName = default(string), string RoutingOrder = default(string), string TemplateRequiresIdLookup = default(string), string UserNameLocked = default(string))
        {
            this.AccessCode = AccessCode;
            this.AccessCodeLocked = AccessCodeLocked;
            this.AccessCodeRequired = AccessCodeRequired;
            this.Email = Email;
            this.EmailLocked = EmailLocked;
            this.IdCheckConfigurationName = IdCheckConfigurationName;
            this.IdCheckRequired = IdCheckRequired;
            this.Name = Name;
            this.RecipientType = RecipientType;
            this.RoleName = RoleName;
            this.RoutingOrder = RoutingOrder;
            this.TemplateRequiresIdLookup = TemplateRequiresIdLookup;
            this.UserNameLocked = UserNameLocked;
        }
        
        /// <summary>
        /// If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required.
        /// </summary>
        /// <value>If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required.</value>
        [DataMember(Name="accessCode", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
        /// <summary>
        /// Gets or Sets AccessCodeLocked
        /// </summary>
        [DataMember(Name="accessCodeLocked", EmitDefaultValue=false)]
        public string AccessCodeLocked { get; set; }
        /// <summary>
        /// Gets or Sets AccessCodeRequired
        /// </summary>
        [DataMember(Name="accessCodeRequired", EmitDefaultValue=false)]
        public string AccessCodeRequired { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets EmailLocked
        /// </summary>
        [DataMember(Name="emailLocked", EmitDefaultValue=false)]
        public string EmailLocked { get; set; }
        /// <summary>
        /// Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.  *Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as &#39;ID Check $&#39; and &#39;SMS Auth $&#39;. To use ID check in an envelope, the idCheckConfigurationName should be &#39;ID Check &#39;. If you wanted to use SMS, it would be &#39;SMS Auth $&#39; and you would need to add you would need to add phone number information to the &#x60;smsAuthentication&#x60; node.
        /// </summary>
        /// <value>Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.  *Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as &#39;ID Check $&#39; and &#39;SMS Auth $&#39;. To use ID check in an envelope, the idCheckConfigurationName should be &#39;ID Check &#39;. If you wanted to use SMS, it would be &#39;SMS Auth $&#39; and you would need to add you would need to add phone number information to the &#x60;smsAuthentication&#x60; node.</value>
        [DataMember(Name="idCheckConfigurationName", EmitDefaultValue=false)]
        public string IdCheckConfigurationName { get; set; }
        /// <summary>
        /// Gets or Sets IdCheckRequired
        /// </summary>
        [DataMember(Name="idCheckRequired", EmitDefaultValue=false)]
        public string IdCheckRequired { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets RecipientType
        /// </summary>
        [DataMember(Name="recipientType", EmitDefaultValue=false)]
        public string RecipientType { get; set; }
        /// <summary>
        /// Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients.
        /// </summary>
        /// <value>Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients.</value>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; set; }
        /// <summary>
        /// Specifies the routing order of the recipient in the envelope. 
        /// </summary>
        /// <value>Specifies the routing order of the recipient in the envelope. </value>
        [DataMember(Name="routingOrder", EmitDefaultValue=false)]
        public string RoutingOrder { get; set; }
        /// <summary>
        /// Gets or Sets TemplateRequiresIdLookup
        /// </summary>
        [DataMember(Name="templateRequiresIdLookup", EmitDefaultValue=false)]
        public string TemplateRequiresIdLookup { get; set; }
        /// <summary>
        /// Gets or Sets UserNameLocked
        /// </summary>
        [DataMember(Name="userNameLocked", EmitDefaultValue=false)]
        public string UserNameLocked { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PowerFormRecipient {\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  AccessCodeLocked: ").Append(AccessCodeLocked).Append("\n");
            sb.Append("  AccessCodeRequired: ").Append(AccessCodeRequired).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailLocked: ").Append(EmailLocked).Append("\n");
            sb.Append("  IdCheckConfigurationName: ").Append(IdCheckConfigurationName).Append("\n");
            sb.Append("  IdCheckRequired: ").Append(IdCheckRequired).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  RoutingOrder: ").Append(RoutingOrder).Append("\n");
            sb.Append("  TemplateRequiresIdLookup: ").Append(TemplateRequiresIdLookup).Append("\n");
            sb.Append("  UserNameLocked: ").Append(UserNameLocked).Append("\n");
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
            return this.Equals(obj as PowerFormRecipient);
        }

        /// <summary>
        /// Returns true if PowerFormRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of PowerFormRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerFormRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
                ) && 
                (
                    this.AccessCodeLocked == other.AccessCodeLocked ||
                    this.AccessCodeLocked != null &&
                    this.AccessCodeLocked.Equals(other.AccessCodeLocked)
                ) && 
                (
                    this.AccessCodeRequired == other.AccessCodeRequired ||
                    this.AccessCodeRequired != null &&
                    this.AccessCodeRequired.Equals(other.AccessCodeRequired)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailLocked == other.EmailLocked ||
                    this.EmailLocked != null &&
                    this.EmailLocked.Equals(other.EmailLocked)
                ) && 
                (
                    this.IdCheckConfigurationName == other.IdCheckConfigurationName ||
                    this.IdCheckConfigurationName != null &&
                    this.IdCheckConfigurationName.Equals(other.IdCheckConfigurationName)
                ) && 
                (
                    this.IdCheckRequired == other.IdCheckRequired ||
                    this.IdCheckRequired != null &&
                    this.IdCheckRequired.Equals(other.IdCheckRequired)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RecipientType == other.RecipientType ||
                    this.RecipientType != null &&
                    this.RecipientType.Equals(other.RecipientType)
                ) && 
                (
                    this.RoleName == other.RoleName ||
                    this.RoleName != null &&
                    this.RoleName.Equals(other.RoleName)
                ) && 
                (
                    this.RoutingOrder == other.RoutingOrder ||
                    this.RoutingOrder != null &&
                    this.RoutingOrder.Equals(other.RoutingOrder)
                ) && 
                (
                    this.TemplateRequiresIdLookup == other.TemplateRequiresIdLookup ||
                    this.TemplateRequiresIdLookup != null &&
                    this.TemplateRequiresIdLookup.Equals(other.TemplateRequiresIdLookup)
                ) && 
                (
                    this.UserNameLocked == other.UserNameLocked ||
                    this.UserNameLocked != null &&
                    this.UserNameLocked.Equals(other.UserNameLocked)
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
                if (this.AccessCode != null)
                    hash = hash * 59 + this.AccessCode.GetHashCode();
                if (this.AccessCodeLocked != null)
                    hash = hash * 59 + this.AccessCodeLocked.GetHashCode();
                if (this.AccessCodeRequired != null)
                    hash = hash * 59 + this.AccessCodeRequired.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EmailLocked != null)
                    hash = hash * 59 + this.EmailLocked.GetHashCode();
                if (this.IdCheckConfigurationName != null)
                    hash = hash * 59 + this.IdCheckConfigurationName.GetHashCode();
                if (this.IdCheckRequired != null)
                    hash = hash * 59 + this.IdCheckRequired.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RecipientType != null)
                    hash = hash * 59 + this.RecipientType.GetHashCode();
                if (this.RoleName != null)
                    hash = hash * 59 + this.RoleName.GetHashCode();
                if (this.RoutingOrder != null)
                    hash = hash * 59 + this.RoutingOrder.GetHashCode();
                if (this.TemplateRequiresIdLookup != null)
                    hash = hash * 59 + this.TemplateRequiresIdLookup.GetHashCode();
                if (this.UserNameLocked != null)
                    hash = hash * 59 + this.UserNameLocked.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
