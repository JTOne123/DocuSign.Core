/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DocuSign.Core.Model
{
    /// <summary>
    /// Users&#39; profiles
    /// </summary>
    [DataContract]
    public partial class UserProfiles :  IEquatable<UserProfiles>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfiles" /> class.
        /// </summary>
        /// <param name="Address">.</param>
        /// <param name="AuthenticationMethods">These properties cannot be modified in the PUT.   Indicates the authentication methods used by the user..</param>
        /// <param name="CompanyName">The name of the user&#39;s Company..</param>
        /// <param name="DisplayOrganizationInfo"> When set to **true**, the user&#39;s company and title information are shown on the ID card. .</param>
        /// <param name="DisplayPersonalInfo">When set to **true**, the user&#39;s Address and Phone number are shown on the ID card..</param>
        /// <param name="DisplayProfile">When set to **true**, the user&#39;s ID card can be viewed from signed documents and envelope history..</param>
        /// <param name="DisplayUsageHistory">When set to **true**, the user&#39;s usage information is shown on the ID card..</param>
        /// <param name="ProfileImageUri">.</param>
        /// <param name="Title">The title of the user..</param>
        /// <param name="UsageHistory">A complex element consisting of:   * lastSentDateTime - the date and time the user last sent an envelope.  * lastSignedDateTime - the date and time the user last signed an envelope. * sentCount - the number of envelopes the user has sent. * signedCount - the number of envelopes the user has signed.  .</param>
        /// <param name="UserDetails">.</param>
        /// <param name="UserProfileLastModifiedDate">.</param>
        public UserProfiles(AddressInformationV2 Address = null, List<AuthenticationMethod> AuthenticationMethods = null, string CompanyName = null, string DisplayOrganizationInfo = null, string DisplayPersonalInfo = null, string DisplayProfile = null, string DisplayUsageHistory = null, string ProfileImageUri = null, string Title = null, UsageHistory UsageHistory = null, Users UserDetails = null, string UserProfileLastModifiedDate = null)
        {
            this.Address = Address;
            this.AuthenticationMethods = AuthenticationMethods;
            this.CompanyName = CompanyName;
            this.DisplayOrganizationInfo = DisplayOrganizationInfo;
            this.DisplayPersonalInfo = DisplayPersonalInfo;
            this.DisplayProfile = DisplayProfile;
            this.DisplayUsageHistory = DisplayUsageHistory;
            this.ProfileImageUri = ProfileImageUri;
            this.Title = Title;
            this.UsageHistory = UsageHistory;
            this.UserDetails = UserDetails;
            this.UserProfileLastModifiedDate = UserProfileLastModifiedDate;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AddressInformationV2 Address { get; set; }
        /// <summary>
        /// These properties cannot be modified in the PUT.   Indicates the authentication methods used by the user.
        /// </summary>
        /// <value>These properties cannot be modified in the PUT.   Indicates the authentication methods used by the user.</value>
        [DataMember(Name="authenticationMethods", EmitDefaultValue=false)]
        public List<AuthenticationMethod> AuthenticationMethods { get; set; }
        /// <summary>
        /// The name of the user&#39;s Company.
        /// </summary>
        /// <value>The name of the user&#39;s Company.</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        ///  When set to **true**, the user&#39;s company and title information are shown on the ID card. 
        /// </summary>
        /// <value> When set to **true**, the user&#39;s company and title information are shown on the ID card. </value>
        [DataMember(Name="displayOrganizationInfo", EmitDefaultValue=false)]
        public string DisplayOrganizationInfo { get; set; }
        /// <summary>
        /// When set to **true**, the user&#39;s Address and Phone number are shown on the ID card.
        /// </summary>
        /// <value>When set to **true**, the user&#39;s Address and Phone number are shown on the ID card.</value>
        [DataMember(Name="displayPersonalInfo", EmitDefaultValue=false)]
        public string DisplayPersonalInfo { get; set; }
        /// <summary>
        /// When set to **true**, the user&#39;s ID card can be viewed from signed documents and envelope history.
        /// </summary>
        /// <value>When set to **true**, the user&#39;s ID card can be viewed from signed documents and envelope history.</value>
        [DataMember(Name="displayProfile", EmitDefaultValue=false)]
        public string DisplayProfile { get; set; }
        /// <summary>
        /// When set to **true**, the user&#39;s usage information is shown on the ID card.
        /// </summary>
        /// <value>When set to **true**, the user&#39;s usage information is shown on the ID card.</value>
        [DataMember(Name="displayUsageHistory", EmitDefaultValue=false)]
        public string DisplayUsageHistory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="profileImageUri", EmitDefaultValue=false)]
        public string ProfileImageUri { get; set; }
        /// <summary>
        /// The title of the user.
        /// </summary>
        /// <value>The title of the user.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// A complex element consisting of:   * lastSentDateTime - the date and time the user last sent an envelope.  * lastSignedDateTime - the date and time the user last signed an envelope. * sentCount - the number of envelopes the user has sent. * signedCount - the number of envelopes the user has signed.  
        /// </summary>
        /// <value>A complex element consisting of:   * lastSentDateTime - the date and time the user last sent an envelope.  * lastSignedDateTime - the date and time the user last signed an envelope. * sentCount - the number of envelopes the user has sent. * signedCount - the number of envelopes the user has signed.  </value>
        [DataMember(Name="usageHistory", EmitDefaultValue=false)]
        public UsageHistory UsageHistory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userDetails", EmitDefaultValue=false)]
        public Users UserDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userProfileLastModifiedDate", EmitDefaultValue=false)]
        public string UserProfileLastModifiedDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfiles {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AuthenticationMethods: ").Append(AuthenticationMethods).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  DisplayOrganizationInfo: ").Append(DisplayOrganizationInfo).Append("\n");
            sb.Append("  DisplayPersonalInfo: ").Append(DisplayPersonalInfo).Append("\n");
            sb.Append("  DisplayProfile: ").Append(DisplayProfile).Append("\n");
            sb.Append("  DisplayUsageHistory: ").Append(DisplayUsageHistory).Append("\n");
            sb.Append("  ProfileImageUri: ").Append(ProfileImageUri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UsageHistory: ").Append(UsageHistory).Append("\n");
            sb.Append("  UserDetails: ").Append(UserDetails).Append("\n");
            sb.Append("  UserProfileLastModifiedDate: ").Append(UserProfileLastModifiedDate).Append("\n");
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
            return this.Equals(obj as UserProfiles);
        }

        /// <summary>
        /// Returns true if UserProfiles instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProfiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfiles other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.AuthenticationMethods == other.AuthenticationMethods ||
                    this.AuthenticationMethods != null &&
                    this.AuthenticationMethods.SequenceEqual(other.AuthenticationMethods)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.DisplayOrganizationInfo == other.DisplayOrganizationInfo ||
                    this.DisplayOrganizationInfo != null &&
                    this.DisplayOrganizationInfo.Equals(other.DisplayOrganizationInfo)
                ) && 
                (
                    this.DisplayPersonalInfo == other.DisplayPersonalInfo ||
                    this.DisplayPersonalInfo != null &&
                    this.DisplayPersonalInfo.Equals(other.DisplayPersonalInfo)
                ) && 
                (
                    this.DisplayProfile == other.DisplayProfile ||
                    this.DisplayProfile != null &&
                    this.DisplayProfile.Equals(other.DisplayProfile)
                ) && 
                (
                    this.DisplayUsageHistory == other.DisplayUsageHistory ||
                    this.DisplayUsageHistory != null &&
                    this.DisplayUsageHistory.Equals(other.DisplayUsageHistory)
                ) && 
                (
                    this.ProfileImageUri == other.ProfileImageUri ||
                    this.ProfileImageUri != null &&
                    this.ProfileImageUri.Equals(other.ProfileImageUri)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.UsageHistory == other.UsageHistory ||
                    this.UsageHistory != null &&
                    this.UsageHistory.Equals(other.UsageHistory)
                ) && 
                (
                    this.UserDetails == other.UserDetails ||
                    this.UserDetails != null &&
                    this.UserDetails.Equals(other.UserDetails)
                ) && 
                (
                    this.UserProfileLastModifiedDate == other.UserProfileLastModifiedDate ||
                    this.UserProfileLastModifiedDate != null &&
                    this.UserProfileLastModifiedDate.Equals(other.UserProfileLastModifiedDate)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.AuthenticationMethods != null)
                    hash = hash * 59 + this.AuthenticationMethods.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.DisplayOrganizationInfo != null)
                    hash = hash * 59 + this.DisplayOrganizationInfo.GetHashCode();
                if (this.DisplayPersonalInfo != null)
                    hash = hash * 59 + this.DisplayPersonalInfo.GetHashCode();
                if (this.DisplayProfile != null)
                    hash = hash * 59 + this.DisplayProfile.GetHashCode();
                if (this.DisplayUsageHistory != null)
                    hash = hash * 59 + this.DisplayUsageHistory.GetHashCode();
                if (this.ProfileImageUri != null)
                    hash = hash * 59 + this.ProfileImageUri.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.UsageHistory != null)
                    hash = hash * 59 + this.UsageHistory.GetHashCode();
                if (this.UserDetails != null)
                    hash = hash * 59 + this.UserDetails.GetHashCode();
                if (this.UserProfileLastModifiedDate != null)
                    hash = hash * 59 + this.UserProfileLastModifiedDate.GetHashCode();
                return hash;
            }
        }
    }

}