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
    /// An object used to identify the features and attributes of the account being created.
    /// </summary>
    [DataContract]
    public partial class PlanInformation :  IEquatable<PlanInformation>, IValidatableObject
    {
        public PlanInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanInformation" /> class.
        /// </summary>
        /// <param name="AddOns">Reserved:.</param>
        /// <param name="CurrencyCode">Specifies the ISO currency code for the account..</param>
        /// <param name="FreeTrialDaysOverride">Reserved for DocuSign use only..</param>
        /// <param name="PlanFeatureSets">A complex type that sets the feature sets for the account..</param>
        /// <param name="PlanId">The DocuSign Plan ID for the account..</param>
        /// <param name="RecipientDomains">RecipientDomains.</param>
        public PlanInformation(List<AddOn> AddOns = default(List<AddOn>), string CurrencyCode = default(string), string FreeTrialDaysOverride = default(string), List<FeatureSet> PlanFeatureSets = default(List<FeatureSet>), string PlanId = default(string), List<RecipientDomain> RecipientDomains = default(List<RecipientDomain>))
        {
            this.AddOns = AddOns;
            this.CurrencyCode = CurrencyCode;
            this.FreeTrialDaysOverride = FreeTrialDaysOverride;
            this.PlanFeatureSets = PlanFeatureSets;
            this.PlanId = PlanId;
            this.RecipientDomains = RecipientDomains;
        }
        
        /// <summary>
        /// Reserved:
        /// </summary>
        /// <value>Reserved:</value>
        [DataMember(Name="addOns", EmitDefaultValue=false)]
        public List<AddOn> AddOns { get; set; }
        /// <summary>
        /// Specifies the ISO currency code for the account.
        /// </summary>
        /// <value>Specifies the ISO currency code for the account.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Reserved for DocuSign use only.
        /// </summary>
        /// <value>Reserved for DocuSign use only.</value>
        [DataMember(Name="freeTrialDaysOverride", EmitDefaultValue=false)]
        public string FreeTrialDaysOverride { get; set; }
        /// <summary>
        /// A complex type that sets the feature sets for the account.
        /// </summary>
        /// <value>A complex type that sets the feature sets for the account.</value>
        [DataMember(Name="planFeatureSets", EmitDefaultValue=false)]
        public List<FeatureSet> PlanFeatureSets { get; set; }
        /// <summary>
        /// The DocuSign Plan ID for the account.
        /// </summary>
        /// <value>The DocuSign Plan ID for the account.</value>
        [DataMember(Name="planId", EmitDefaultValue=false)]
        public string PlanId { get; set; }
        /// <summary>
        /// Gets or Sets RecipientDomains
        /// </summary>
        [DataMember(Name="recipientDomains", EmitDefaultValue=false)]
        public List<RecipientDomain> RecipientDomains { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanInformation {\n");
            sb.Append("  AddOns: ").Append(AddOns).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  FreeTrialDaysOverride: ").Append(FreeTrialDaysOverride).Append("\n");
            sb.Append("  PlanFeatureSets: ").Append(PlanFeatureSets).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  RecipientDomains: ").Append(RecipientDomains).Append("\n");
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
            return this.Equals(obj as PlanInformation);
        }

        /// <summary>
        /// Returns true if PlanInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddOns == other.AddOns ||
                    this.AddOns != null &&
                    this.AddOns.SequenceEqual(other.AddOns)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.FreeTrialDaysOverride == other.FreeTrialDaysOverride ||
                    this.FreeTrialDaysOverride != null &&
                    this.FreeTrialDaysOverride.Equals(other.FreeTrialDaysOverride)
                ) && 
                (
                    this.PlanFeatureSets == other.PlanFeatureSets ||
                    this.PlanFeatureSets != null &&
                    this.PlanFeatureSets.SequenceEqual(other.PlanFeatureSets)
                ) && 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.RecipientDomains == other.RecipientDomains ||
                    this.RecipientDomains != null &&
                    this.RecipientDomains.SequenceEqual(other.RecipientDomains)
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
                if (this.AddOns != null)
                    hash = hash * 59 + this.AddOns.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.FreeTrialDaysOverride != null)
                    hash = hash * 59 + this.FreeTrialDaysOverride.GetHashCode();
                if (this.PlanFeatureSets != null)
                    hash = hash * 59 + this.PlanFeatureSets.GetHashCode();
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.RecipientDomains != null)
                    hash = hash * 59 + this.RecipientDomains.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
