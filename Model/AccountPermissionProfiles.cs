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
    /// 
    /// </summary>
    [DataContract]
    public partial class AccountPermissionProfiles :  IEquatable<AccountPermissionProfiles>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPermissionProfiles" /> class.
        /// </summary>
        /// <param name="ModifiedByUsername">.</param>
        /// <param name="ModifiedDateTime">.</param>
        /// <param name="PermissionProfileId">.</param>
        /// <param name="PermissionProfileName">.</param>
        /// <param name="Settings">.</param>
        /// <param name="UserCount">.</param>
        /// <param name="Users">.</param>
        public AccountPermissionProfiles(string ModifiedByUsername = null, string ModifiedDateTime = null, string PermissionProfileId = null, string PermissionProfileName = null, AccountRoleSettings Settings = null, string UserCount = null, List<Users> Users = null)
        {
            this.ModifiedByUsername = ModifiedByUsername;
            this.ModifiedDateTime = ModifiedDateTime;
            this.PermissionProfileId = PermissionProfileId;
            this.PermissionProfileName = PermissionProfileName;
            this.Settings = Settings;
            this.UserCount = UserCount;
            this.Users = Users;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modifiedByUsername", EmitDefaultValue=false)]
        public string ModifiedByUsername { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modifiedDateTime", EmitDefaultValue=false)]
        public string ModifiedDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="permissionProfileId", EmitDefaultValue=false)]
        public string PermissionProfileId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="permissionProfileName", EmitDefaultValue=false)]
        public string PermissionProfileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public AccountRoleSettings Settings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userCount", EmitDefaultValue=false)]
        public string UserCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<Users> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPermissionProfiles {\n");
            sb.Append("  ModifiedByUsername: ").Append(ModifiedByUsername).Append("\n");
            sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
            sb.Append("  PermissionProfileId: ").Append(PermissionProfileId).Append("\n");
            sb.Append("  PermissionProfileName: ").Append(PermissionProfileName).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as AccountPermissionProfiles);
        }

        /// <summary>
        /// Returns true if AccountPermissionProfiles instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountPermissionProfiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPermissionProfiles other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ModifiedByUsername == other.ModifiedByUsername ||
                    this.ModifiedByUsername != null &&
                    this.ModifiedByUsername.Equals(other.ModifiedByUsername)
                ) && 
                (
                    this.ModifiedDateTime == other.ModifiedDateTime ||
                    this.ModifiedDateTime != null &&
                    this.ModifiedDateTime.Equals(other.ModifiedDateTime)
                ) && 
                (
                    this.PermissionProfileId == other.PermissionProfileId ||
                    this.PermissionProfileId != null &&
                    this.PermissionProfileId.Equals(other.PermissionProfileId)
                ) && 
                (
                    this.PermissionProfileName == other.PermissionProfileName ||
                    this.PermissionProfileName != null &&
                    this.PermissionProfileName.Equals(other.PermissionProfileName)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.UserCount == other.UserCount ||
                    this.UserCount != null &&
                    this.UserCount.Equals(other.UserCount)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.ModifiedByUsername != null)
                    hash = hash * 59 + this.ModifiedByUsername.GetHashCode();
                if (this.ModifiedDateTime != null)
                    hash = hash * 59 + this.ModifiedDateTime.GetHashCode();
                if (this.PermissionProfileId != null)
                    hash = hash * 59 + this.PermissionProfileId.GetHashCode();
                if (this.PermissionProfileName != null)
                    hash = hash * 59 + this.PermissionProfileName.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.UserCount != null)
                    hash = hash * 59 + this.UserCount.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }
    }

}
