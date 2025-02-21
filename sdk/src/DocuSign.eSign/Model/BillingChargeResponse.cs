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
    /// Defines a billing charge response object.
    /// </summary>
    [DataContract]
    public partial class BillingChargeResponse :  IEquatable<BillingChargeResponse>, IValidatableObject
    {
        public BillingChargeResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingChargeResponse" /> class.
        /// </summary>
        /// <param name="BillingChargeItems">Reserved: TBD.</param>
        public BillingChargeResponse(List<BillingCharge> BillingChargeItems = default(List<BillingCharge>))
        {
            this.BillingChargeItems = BillingChargeItems;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingChargeItems", EmitDefaultValue=false)]
        public List<BillingCharge> BillingChargeItems { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingChargeResponse {\n");
            sb.Append("  BillingChargeItems: ").Append(BillingChargeItems).Append("\n");
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
            return this.Equals(obj as BillingChargeResponse);
        }

        /// <summary>
        /// Returns true if BillingChargeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingChargeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingChargeResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillingChargeItems == other.BillingChargeItems ||
                    this.BillingChargeItems != null &&
                    this.BillingChargeItems.SequenceEqual(other.BillingChargeItems)
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
                if (this.BillingChargeItems != null)
                    hash = hash * 59 + this.BillingChargeItems.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
