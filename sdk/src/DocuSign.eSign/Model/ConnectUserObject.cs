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
    /// ConnectUserObject
    /// </summary>
    [DataContract]
    public partial class ConnectUserObject :  IEquatable<ConnectUserObject>, IValidatableObject
    {
        public ConnectUserObject()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectUserObject" /> class.
        /// </summary>
        /// <param name="Configurationtype">If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**..</param>
        /// <param name="ConnectId">ConnectId.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="HasAccess">HasAccess.</param>
        /// <param name="SenderSearchableItems">SenderSearchableItems.</param>
        public ConnectUserObject(string Configurationtype = default(string), string ConnectId = default(string), string Enabled = default(string), string HasAccess = default(string), List<string> SenderSearchableItems = default(List<string>))
        {
            this.Configurationtype = Configurationtype;
            this.ConnectId = ConnectId;
            this.Enabled = Enabled;
            this.HasAccess = HasAccess;
            this.SenderSearchableItems = SenderSearchableItems;
        }
        
        /// <summary>
        /// If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**.
        /// </summary>
        /// <value>If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**.</value>
        [DataMember(Name="configurationtype", EmitDefaultValue=false)]
        public string Configurationtype { get; set; }
        /// <summary>
        /// Gets or Sets ConnectId
        /// </summary>
        [DataMember(Name="connectId", EmitDefaultValue=false)]
        public string ConnectId { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public string Enabled { get; set; }
        /// <summary>
        /// Gets or Sets HasAccess
        /// </summary>
        [DataMember(Name="hasAccess", EmitDefaultValue=false)]
        public string HasAccess { get; set; }
        /// <summary>
        /// Gets or Sets SenderSearchableItems
        /// </summary>
        [DataMember(Name="senderSearchableItems", EmitDefaultValue=false)]
        public List<string> SenderSearchableItems { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectUserObject {\n");
            sb.Append("  Configurationtype: ").Append(Configurationtype).Append("\n");
            sb.Append("  ConnectId: ").Append(ConnectId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  HasAccess: ").Append(HasAccess).Append("\n");
            sb.Append("  SenderSearchableItems: ").Append(SenderSearchableItems).Append("\n");
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
            return this.Equals(obj as ConnectUserObject);
        }

        /// <summary>
        /// Returns true if ConnectUserObject instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectUserObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectUserObject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Configurationtype == other.Configurationtype ||
                    this.Configurationtype != null &&
                    this.Configurationtype.Equals(other.Configurationtype)
                ) && 
                (
                    this.ConnectId == other.ConnectId ||
                    this.ConnectId != null &&
                    this.ConnectId.Equals(other.ConnectId)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.HasAccess == other.HasAccess ||
                    this.HasAccess != null &&
                    this.HasAccess.Equals(other.HasAccess)
                ) && 
                (
                    this.SenderSearchableItems == other.SenderSearchableItems ||
                    this.SenderSearchableItems != null &&
                    this.SenderSearchableItems.SequenceEqual(other.SenderSearchableItems)
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
                if (this.Configurationtype != null)
                    hash = hash * 59 + this.Configurationtype.GetHashCode();
                if (this.ConnectId != null)
                    hash = hash * 59 + this.ConnectId.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.HasAccess != null)
                    hash = hash * 59 + this.HasAccess.GetHashCode();
                if (this.SenderSearchableItems != null)
                    hash = hash * 59 + this.SenderSearchableItems.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
