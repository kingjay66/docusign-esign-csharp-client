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
    /// Contains information about the authentication status.
    /// </summary>
    [DataContract]
    public partial class AuthenticationStatus :  IEquatable<AuthenticationStatus>, IValidatableObject
    {
        public AuthenticationStatus()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationStatus" /> class.
        /// </summary>
        /// <param name="AccessCodeResult">The result of a user&#39;s attempt to authenticate by using an access code. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. .</param>
        /// <param name="AgeVerifyResult">The result of an age verification check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. .</param>
        /// <param name="AnySocialIDResult">Deprecated..</param>
        /// <param name="FacebookResult">Deprecated..</param>
        /// <param name="GoogleResult">Deprecated..</param>
        /// <param name="IdentityVerificationResult">The result of an [Identity Verification][IDV] workflow.  [IDV]: /docs/esign-rest-api/reference/accounts/identityverifications/.</param>
        /// <param name="IdLookupResult">The result of an ID lookup authentication check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. .</param>
        /// <param name="IdQuestionsResult">The result of the user&#39;s answers to ID challenge questions. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. .</param>
        /// <param name="LinkedinResult">Deprecated..</param>
        /// <param name="LiveIDResult">Deprecated..</param>
        /// <param name="OfacResult">The result of an Office of Foreign Asset Control (OFAC) check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. .</param>
        /// <param name="OpenIDResult">Deprecated..</param>
        /// <param name="PhoneAuthResult">The result of the user&#39;s attempt to authenticate by using two-factor authentication (2FA) through phone messaging. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. .</param>
        /// <param name="SalesforceResult">Success/failure result of authentication using sign-in with a Salesforce account. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. .</param>
        /// <param name="SignatureProviderResult">The result of the user&#39;s attempt to authenticate by using a signature provider..</param>
        /// <param name="SmsAuthResult">The result of the user&#39;s attempt to authenticate by using two-factor authentication (2FA) through SMS messaging on a mobile phone..</param>
        /// <param name="STANPinResult">The result of a Student Authentication Network (STAN) authentication check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. .</param>
        /// <param name="TwitterResult">Deprecated..</param>
        /// <param name="YahooResult">Deprecated..</param>
        public AuthenticationStatus(EventResult AccessCodeResult = default(EventResult), EventResult AgeVerifyResult = default(EventResult), EventResult AnySocialIDResult = default(EventResult), EventResult FacebookResult = default(EventResult), EventResult GoogleResult = default(EventResult), EventResult IdentityVerificationResult = default(EventResult), EventResult IdLookupResult = default(EventResult), EventResult IdQuestionsResult = default(EventResult), EventResult LinkedinResult = default(EventResult), EventResult LiveIDResult = default(EventResult), EventResult OfacResult = default(EventResult), EventResult OpenIDResult = default(EventResult), EventResult PhoneAuthResult = default(EventResult), EventResult SalesforceResult = default(EventResult), EventResult SignatureProviderResult = default(EventResult), EventResult SmsAuthResult = default(EventResult), EventResult STANPinResult = default(EventResult), EventResult TwitterResult = default(EventResult), EventResult YahooResult = default(EventResult))
        {
            this.AccessCodeResult = AccessCodeResult;
            this.AgeVerifyResult = AgeVerifyResult;
            this.AnySocialIDResult = AnySocialIDResult;
            this.FacebookResult = FacebookResult;
            this.GoogleResult = GoogleResult;
            this.IdentityVerificationResult = IdentityVerificationResult;
            this.IdLookupResult = IdLookupResult;
            this.IdQuestionsResult = IdQuestionsResult;
            this.LinkedinResult = LinkedinResult;
            this.LiveIDResult = LiveIDResult;
            this.OfacResult = OfacResult;
            this.OpenIDResult = OpenIDResult;
            this.PhoneAuthResult = PhoneAuthResult;
            this.SalesforceResult = SalesforceResult;
            this.SignatureProviderResult = SignatureProviderResult;
            this.SmsAuthResult = SmsAuthResult;
            this.STANPinResult = STANPinResult;
            this.TwitterResult = TwitterResult;
            this.YahooResult = YahooResult;
        }
        
        /// <summary>
        /// The result of a user&#39;s attempt to authenticate by using an access code. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. 
        /// </summary>
        /// <value>The result of a user&#39;s attempt to authenticate by using an access code. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. </value>
        [DataMember(Name="accessCodeResult", EmitDefaultValue=false)]
        public EventResult AccessCodeResult { get; set; }
        /// <summary>
        /// The result of an age verification check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. 
        /// </summary>
        /// <value>The result of an age verification check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. </value>
        [DataMember(Name="ageVerifyResult", EmitDefaultValue=false)]
        public EventResult AgeVerifyResult { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        /// <value>Deprecated.</value>
        [DataMember(Name="anySocialIDResult", EmitDefaultValue=false)]
        public EventResult AnySocialIDResult { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        /// <value>Deprecated.</value>
        [DataMember(Name="facebookResult", EmitDefaultValue=false)]
        public EventResult FacebookResult { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        /// <value>Deprecated.</value>
        [DataMember(Name="googleResult", EmitDefaultValue=false)]
        public EventResult GoogleResult { get; set; }
        /// <summary>
        /// The result of an [Identity Verification][IDV] workflow.  [IDV]: /docs/esign-rest-api/reference/accounts/identityverifications/
        /// </summary>
        /// <value>The result of an [Identity Verification][IDV] workflow.  [IDV]: /docs/esign-rest-api/reference/accounts/identityverifications/</value>
        [DataMember(Name="identityVerificationResult", EmitDefaultValue=false)]
        public EventResult IdentityVerificationResult { get; set; }
        /// <summary>
        /// The result of an ID lookup authentication check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. 
        /// </summary>
        /// <value>The result of an ID lookup authentication check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. </value>
        [DataMember(Name="idLookupResult", EmitDefaultValue=false)]
        public EventResult IdLookupResult { get; set; }
        /// <summary>
        /// The result of the user&#39;s answers to ID challenge questions. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. 
        /// </summary>
        /// <value>The result of the user&#39;s answers to ID challenge questions. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. </value>
        [DataMember(Name="idQuestionsResult", EmitDefaultValue=false)]
        public EventResult IdQuestionsResult { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        /// <value>Deprecated.</value>
        [DataMember(Name="linkedinResult", EmitDefaultValue=false)]
        public EventResult LinkedinResult { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        /// <value>Deprecated.</value>
        [DataMember(Name="liveIDResult", EmitDefaultValue=false)]
        public EventResult LiveIDResult { get; set; }
        /// <summary>
        /// The result of an Office of Foreign Asset Control (OFAC) check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. 
        /// </summary>
        /// <value>The result of an Office of Foreign Asset Control (OFAC) check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. </value>
        [DataMember(Name="ofacResult", EmitDefaultValue=false)]
        public EventResult OfacResult { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        /// <value>Deprecated.</value>
        [DataMember(Name="openIDResult", EmitDefaultValue=false)]
        public EventResult OpenIDResult { get; set; }
        /// <summary>
        /// The result of the user&#39;s attempt to authenticate by using two-factor authentication (2FA) through phone messaging. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. 
        /// </summary>
        /// <value>The result of the user&#39;s attempt to authenticate by using two-factor authentication (2FA) through phone messaging. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. </value>
        [DataMember(Name="phoneAuthResult", EmitDefaultValue=false)]
        public EventResult PhoneAuthResult { get; set; }
        /// <summary>
        /// Success/failure result of authentication using sign-in with a Salesforce account. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. 
        /// </summary>
        /// <value>Success/failure result of authentication using sign-in with a Salesforce account. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. </value>
        [DataMember(Name="salesforceResult", EmitDefaultValue=false)]
        public EventResult SalesforceResult { get; set; }
        /// <summary>
        /// The result of the user&#39;s attempt to authenticate by using a signature provider.
        /// </summary>
        /// <value>The result of the user&#39;s attempt to authenticate by using a signature provider.</value>
        [DataMember(Name="signatureProviderResult", EmitDefaultValue=false)]
        public EventResult SignatureProviderResult { get; set; }
        /// <summary>
        /// The result of the user&#39;s attempt to authenticate by using two-factor authentication (2FA) through SMS messaging on a mobile phone.
        /// </summary>
        /// <value>The result of the user&#39;s attempt to authenticate by using two-factor authentication (2FA) through SMS messaging on a mobile phone.</value>
        [DataMember(Name="smsAuthResult", EmitDefaultValue=false)]
        public EventResult SmsAuthResult { get; set; }
        /// <summary>
        /// The result of a Student Authentication Network (STAN) authentication check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. 
        /// </summary>
        /// <value>The result of a Student Authentication Network (STAN) authentication check. It returns:  - &#x60;Status&#x60;: &#x60;Pass&#x60; or &#x60;Fail&#x60;. - &#x60;dateTime&#x60;: The date and time that the event occurred. - &#x60;FailureDescription&#x60;: A string containing the details about a failed authentication. - &#x60;VendorFailureStatusCode&#x60;: A string containing the vendor&#39;s status code for a failed authentication. </value>
        [DataMember(Name="sTANPinResult", EmitDefaultValue=false)]
        public EventResult STANPinResult { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        /// <value>Deprecated.</value>
        [DataMember(Name="twitterResult", EmitDefaultValue=false)]
        public EventResult TwitterResult { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        /// <value>Deprecated.</value>
        [DataMember(Name="yahooResult", EmitDefaultValue=false)]
        public EventResult YahooResult { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationStatus {\n");
            sb.Append("  AccessCodeResult: ").Append(AccessCodeResult).Append("\n");
            sb.Append("  AgeVerifyResult: ").Append(AgeVerifyResult).Append("\n");
            sb.Append("  AnySocialIDResult: ").Append(AnySocialIDResult).Append("\n");
            sb.Append("  FacebookResult: ").Append(FacebookResult).Append("\n");
            sb.Append("  GoogleResult: ").Append(GoogleResult).Append("\n");
            sb.Append("  IdentityVerificationResult: ").Append(IdentityVerificationResult).Append("\n");
            sb.Append("  IdLookupResult: ").Append(IdLookupResult).Append("\n");
            sb.Append("  IdQuestionsResult: ").Append(IdQuestionsResult).Append("\n");
            sb.Append("  LinkedinResult: ").Append(LinkedinResult).Append("\n");
            sb.Append("  LiveIDResult: ").Append(LiveIDResult).Append("\n");
            sb.Append("  OfacResult: ").Append(OfacResult).Append("\n");
            sb.Append("  OpenIDResult: ").Append(OpenIDResult).Append("\n");
            sb.Append("  PhoneAuthResult: ").Append(PhoneAuthResult).Append("\n");
            sb.Append("  SalesforceResult: ").Append(SalesforceResult).Append("\n");
            sb.Append("  SignatureProviderResult: ").Append(SignatureProviderResult).Append("\n");
            sb.Append("  SmsAuthResult: ").Append(SmsAuthResult).Append("\n");
            sb.Append("  STANPinResult: ").Append(STANPinResult).Append("\n");
            sb.Append("  TwitterResult: ").Append(TwitterResult).Append("\n");
            sb.Append("  YahooResult: ").Append(YahooResult).Append("\n");
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
            return this.Equals(obj as AuthenticationStatus);
        }

        /// <summary>
        /// Returns true if AuthenticationStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessCodeResult == other.AccessCodeResult ||
                    this.AccessCodeResult != null &&
                    this.AccessCodeResult.Equals(other.AccessCodeResult)
                ) && 
                (
                    this.AgeVerifyResult == other.AgeVerifyResult ||
                    this.AgeVerifyResult != null &&
                    this.AgeVerifyResult.Equals(other.AgeVerifyResult)
                ) && 
                (
                    this.AnySocialIDResult == other.AnySocialIDResult ||
                    this.AnySocialIDResult != null &&
                    this.AnySocialIDResult.Equals(other.AnySocialIDResult)
                ) && 
                (
                    this.FacebookResult == other.FacebookResult ||
                    this.FacebookResult != null &&
                    this.FacebookResult.Equals(other.FacebookResult)
                ) && 
                (
                    this.GoogleResult == other.GoogleResult ||
                    this.GoogleResult != null &&
                    this.GoogleResult.Equals(other.GoogleResult)
                ) && 
                (
                    this.IdentityVerificationResult == other.IdentityVerificationResult ||
                    this.IdentityVerificationResult != null &&
                    this.IdentityVerificationResult.Equals(other.IdentityVerificationResult)
                ) && 
                (
                    this.IdLookupResult == other.IdLookupResult ||
                    this.IdLookupResult != null &&
                    this.IdLookupResult.Equals(other.IdLookupResult)
                ) && 
                (
                    this.IdQuestionsResult == other.IdQuestionsResult ||
                    this.IdQuestionsResult != null &&
                    this.IdQuestionsResult.Equals(other.IdQuestionsResult)
                ) && 
                (
                    this.LinkedinResult == other.LinkedinResult ||
                    this.LinkedinResult != null &&
                    this.LinkedinResult.Equals(other.LinkedinResult)
                ) && 
                (
                    this.LiveIDResult == other.LiveIDResult ||
                    this.LiveIDResult != null &&
                    this.LiveIDResult.Equals(other.LiveIDResult)
                ) && 
                (
                    this.OfacResult == other.OfacResult ||
                    this.OfacResult != null &&
                    this.OfacResult.Equals(other.OfacResult)
                ) && 
                (
                    this.OpenIDResult == other.OpenIDResult ||
                    this.OpenIDResult != null &&
                    this.OpenIDResult.Equals(other.OpenIDResult)
                ) && 
                (
                    this.PhoneAuthResult == other.PhoneAuthResult ||
                    this.PhoneAuthResult != null &&
                    this.PhoneAuthResult.Equals(other.PhoneAuthResult)
                ) && 
                (
                    this.SalesforceResult == other.SalesforceResult ||
                    this.SalesforceResult != null &&
                    this.SalesforceResult.Equals(other.SalesforceResult)
                ) && 
                (
                    this.SignatureProviderResult == other.SignatureProviderResult ||
                    this.SignatureProviderResult != null &&
                    this.SignatureProviderResult.Equals(other.SignatureProviderResult)
                ) && 
                (
                    this.SmsAuthResult == other.SmsAuthResult ||
                    this.SmsAuthResult != null &&
                    this.SmsAuthResult.Equals(other.SmsAuthResult)
                ) && 
                (
                    this.STANPinResult == other.STANPinResult ||
                    this.STANPinResult != null &&
                    this.STANPinResult.Equals(other.STANPinResult)
                ) && 
                (
                    this.TwitterResult == other.TwitterResult ||
                    this.TwitterResult != null &&
                    this.TwitterResult.Equals(other.TwitterResult)
                ) && 
                (
                    this.YahooResult == other.YahooResult ||
                    this.YahooResult != null &&
                    this.YahooResult.Equals(other.YahooResult)
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
                if (this.AccessCodeResult != null)
                    hash = hash * 59 + this.AccessCodeResult.GetHashCode();
                if (this.AgeVerifyResult != null)
                    hash = hash * 59 + this.AgeVerifyResult.GetHashCode();
                if (this.AnySocialIDResult != null)
                    hash = hash * 59 + this.AnySocialIDResult.GetHashCode();
                if (this.FacebookResult != null)
                    hash = hash * 59 + this.FacebookResult.GetHashCode();
                if (this.GoogleResult != null)
                    hash = hash * 59 + this.GoogleResult.GetHashCode();
                if (this.IdentityVerificationResult != null)
                    hash = hash * 59 + this.IdentityVerificationResult.GetHashCode();
                if (this.IdLookupResult != null)
                    hash = hash * 59 + this.IdLookupResult.GetHashCode();
                if (this.IdQuestionsResult != null)
                    hash = hash * 59 + this.IdQuestionsResult.GetHashCode();
                if (this.LinkedinResult != null)
                    hash = hash * 59 + this.LinkedinResult.GetHashCode();
                if (this.LiveIDResult != null)
                    hash = hash * 59 + this.LiveIDResult.GetHashCode();
                if (this.OfacResult != null)
                    hash = hash * 59 + this.OfacResult.GetHashCode();
                if (this.OpenIDResult != null)
                    hash = hash * 59 + this.OpenIDResult.GetHashCode();
                if (this.PhoneAuthResult != null)
                    hash = hash * 59 + this.PhoneAuthResult.GetHashCode();
                if (this.SalesforceResult != null)
                    hash = hash * 59 + this.SalesforceResult.GetHashCode();
                if (this.SignatureProviderResult != null)
                    hash = hash * 59 + this.SignatureProviderResult.GetHashCode();
                if (this.SmsAuthResult != null)
                    hash = hash * 59 + this.SmsAuthResult.GetHashCode();
                if (this.STANPinResult != null)
                    hash = hash * 59 + this.STANPinResult.GetHashCode();
                if (this.TwitterResult != null)
                    hash = hash * 59 + this.TwitterResult.GetHashCode();
                if (this.YahooResult != null)
                    hash = hash * 59 + this.YahooResult.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
