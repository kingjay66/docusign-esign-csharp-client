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
    /// Contact
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>, IValidatableObject
    {
        public Contact()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="CloudProvider">CloudProvider.</param>
        /// <param name="CloudProviderContainerId">CloudProviderContainerId.</param>
        /// <param name="ContactId">ContactId.</param>
        /// <param name="ContactPhoneNumbers">ContactPhoneNumbers.</param>
        /// <param name="ContactUri">ContactUri.</param>
        /// <param name="Emails">Emails.</param>
        /// <param name="ErrorDetails">This object describes errors that occur. It is only valid for responses and ignored in requests..</param>
        /// <param name="IsOwner">IsOwner.</param>
        /// <param name="Name">Name.</param>
        /// <param name="NotaryContactDetails">NotaryContactDetails.</param>
        /// <param name="Organization">Organization.</param>
        /// <param name="RoomContactType">RoomContactType.</param>
        /// <param name="Shared">When set to **true**, this custom tab is shared..</param>
        /// <param name="SigningGroup">SigningGroup.</param>
        /// <param name="SigningGroupName">The display name for the signing group.   Maximum Length: 100 characters. .</param>
        public Contact(string CloudProvider = default(string), string CloudProviderContainerId = default(string), string ContactId = default(string), List<ContactPhoneNumber> ContactPhoneNumbers = default(List<ContactPhoneNumber>), string ContactUri = default(string), List<string> Emails = default(List<string>), ErrorDetails ErrorDetails = default(ErrorDetails), bool? IsOwner = default(bool?), string Name = default(string), NotaryContactDetails NotaryContactDetails = default(NotaryContactDetails), string Organization = default(string), string RoomContactType = default(string), string Shared = default(string), string SigningGroup = default(string), string SigningGroupName = default(string))
        {
            this.CloudProvider = CloudProvider;
            this.CloudProviderContainerId = CloudProviderContainerId;
            this.ContactId = ContactId;
            this.ContactPhoneNumbers = ContactPhoneNumbers;
            this.ContactUri = ContactUri;
            this.Emails = Emails;
            this.ErrorDetails = ErrorDetails;
            this.IsOwner = IsOwner;
            this.Name = Name;
            this.NotaryContactDetails = NotaryContactDetails;
            this.Organization = Organization;
            this.RoomContactType = RoomContactType;
            this.Shared = Shared;
            this.SigningGroup = SigningGroup;
            this.SigningGroupName = SigningGroupName;
        }
        
        /// <summary>
        /// Gets or Sets CloudProvider
        /// </summary>
        [DataMember(Name="cloudProvider", EmitDefaultValue=false)]
        public string CloudProvider { get; set; }
        /// <summary>
        /// Gets or Sets CloudProviderContainerId
        /// </summary>
        [DataMember(Name="cloudProviderContainerId", EmitDefaultValue=false)]
        public string CloudProviderContainerId { get; set; }
        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public string ContactId { get; set; }
        /// <summary>
        /// Gets or Sets ContactPhoneNumbers
        /// </summary>
        [DataMember(Name="contactPhoneNumbers", EmitDefaultValue=false)]
        public List<ContactPhoneNumber> ContactPhoneNumbers { get; set; }
        /// <summary>
        /// Gets or Sets ContactUri
        /// </summary>
        [DataMember(Name="contactUri", EmitDefaultValue=false)]
        public string ContactUri { get; set; }
        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }
        /// <summary>
        /// This object describes errors that occur. It is only valid for responses and ignored in requests.
        /// </summary>
        /// <value>This object describes errors that occur. It is only valid for responses and ignored in requests.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets IsOwner
        /// </summary>
        [DataMember(Name="isOwner", EmitDefaultValue=false)]
        public bool? IsOwner { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets NotaryContactDetails
        /// </summary>
        [DataMember(Name="notaryContactDetails", EmitDefaultValue=false)]
        public NotaryContactDetails NotaryContactDetails { get; set; }
        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }
        /// <summary>
        /// Gets or Sets RoomContactType
        /// </summary>
        [DataMember(Name="roomContactType", EmitDefaultValue=false)]
        public string RoomContactType { get; set; }
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
        /// <summary>
        /// Gets or Sets SigningGroup
        /// </summary>
        [DataMember(Name="signingGroup", EmitDefaultValue=false)]
        public string SigningGroup { get; set; }
        /// <summary>
        /// The display name for the signing group.   Maximum Length: 100 characters. 
        /// </summary>
        /// <value>The display name for the signing group.   Maximum Length: 100 characters. </value>
        [DataMember(Name="signingGroupName", EmitDefaultValue=false)]
        public string SigningGroupName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  CloudProvider: ").Append(CloudProvider).Append("\n");
            sb.Append("  CloudProviderContainerId: ").Append(CloudProviderContainerId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  ContactPhoneNumbers: ").Append(ContactPhoneNumbers).Append("\n");
            sb.Append("  ContactUri: ").Append(ContactUri).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NotaryContactDetails: ").Append(NotaryContactDetails).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  RoomContactType: ").Append(RoomContactType).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  SigningGroup: ").Append(SigningGroup).Append("\n");
            sb.Append("  SigningGroupName: ").Append(SigningGroupName).Append("\n");
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
            return this.Equals(obj as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="other">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CloudProvider == other.CloudProvider ||
                    this.CloudProvider != null &&
                    this.CloudProvider.Equals(other.CloudProvider)
                ) && 
                (
                    this.CloudProviderContainerId == other.CloudProviderContainerId ||
                    this.CloudProviderContainerId != null &&
                    this.CloudProviderContainerId.Equals(other.CloudProviderContainerId)
                ) && 
                (
                    this.ContactId == other.ContactId ||
                    this.ContactId != null &&
                    this.ContactId.Equals(other.ContactId)
                ) && 
                (
                    this.ContactPhoneNumbers == other.ContactPhoneNumbers ||
                    this.ContactPhoneNumbers != null &&
                    this.ContactPhoneNumbers.SequenceEqual(other.ContactPhoneNumbers)
                ) && 
                (
                    this.ContactUri == other.ContactUri ||
                    this.ContactUri != null &&
                    this.ContactUri.Equals(other.ContactUri)
                ) && 
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(other.Emails)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.IsOwner == other.IsOwner ||
                    this.IsOwner != null &&
                    this.IsOwner.Equals(other.IsOwner)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NotaryContactDetails == other.NotaryContactDetails ||
                    this.NotaryContactDetails != null &&
                    this.NotaryContactDetails.Equals(other.NotaryContactDetails)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.RoomContactType == other.RoomContactType ||
                    this.RoomContactType != null &&
                    this.RoomContactType.Equals(other.RoomContactType)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.SigningGroup == other.SigningGroup ||
                    this.SigningGroup != null &&
                    this.SigningGroup.Equals(other.SigningGroup)
                ) && 
                (
                    this.SigningGroupName == other.SigningGroupName ||
                    this.SigningGroupName != null &&
                    this.SigningGroupName.Equals(other.SigningGroupName)
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
                if (this.CloudProvider != null)
                    hash = hash * 59 + this.CloudProvider.GetHashCode();
                if (this.CloudProviderContainerId != null)
                    hash = hash * 59 + this.CloudProviderContainerId.GetHashCode();
                if (this.ContactId != null)
                    hash = hash * 59 + this.ContactId.GetHashCode();
                if (this.ContactPhoneNumbers != null)
                    hash = hash * 59 + this.ContactPhoneNumbers.GetHashCode();
                if (this.ContactUri != null)
                    hash = hash * 59 + this.ContactUri.GetHashCode();
                if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.IsOwner != null)
                    hash = hash * 59 + this.IsOwner.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NotaryContactDetails != null)
                    hash = hash * 59 + this.NotaryContactDetails.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.RoomContactType != null)
                    hash = hash * 59 + this.RoomContactType.GetHashCode();
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                if (this.SigningGroup != null)
                    hash = hash * 59 + this.SigningGroup.GetHashCode();
                if (this.SigningGroupName != null)
                    hash = hash * 59 + this.SigningGroupName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
