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
    /// Contains information for transfering values between Salesforce data fields and DocuSign Tabs.
    /// </summary>
    [DataContract]
    public partial class MergeField :  IEquatable<MergeField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeField" /> class.
        /// </summary>
        /// <param name="AllowSenderToEdit">When set to **true**, the sender can modify the value of the custom tab during the sending process..</param>
        /// <param name="ConfigurationType">If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**..</param>
        /// <param name="Path">Sets the object associated with the custom tab. Currently this is the Salesforce Object..</param>
        /// <param name="Row">Specifies the row number in a Salesforce table that the merge field value corresponds to..</param>
        /// <param name="WriteBack">When wet to true, the information entered in the tab automatically updates the related Salesforce data when an envelope is completed..</param>
        public MergeField(string AllowSenderToEdit = null, string ConfigurationType = null, string Path = null, string Row = null, string WriteBack = null)
        {
            this.AllowSenderToEdit = AllowSenderToEdit;
            this.ConfigurationType = ConfigurationType;
            this.Path = Path;
            this.Row = Row;
            this.WriteBack = WriteBack;
        }
        
        /// <summary>
        /// When set to **true**, the sender can modify the value of the custom tab during the sending process.
        /// </summary>
        /// <value>When set to **true**, the sender can modify the value of the custom tab during the sending process.</value>
        [DataMember(Name="allowSenderToEdit", EmitDefaultValue=false)]
        public string AllowSenderToEdit { get; set; }
        /// <summary>
        /// If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**.
        /// </summary>
        /// <value>If merge field&#39;s are being used, specifies the type of the merge field. The only  supported value is **salesforce**.</value>
        [DataMember(Name="configurationType", EmitDefaultValue=false)]
        public string ConfigurationType { get; set; }
        /// <summary>
        /// Sets the object associated with the custom tab. Currently this is the Salesforce Object.
        /// </summary>
        /// <value>Sets the object associated with the custom tab. Currently this is the Salesforce Object.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
        /// <summary>
        /// Specifies the row number in a Salesforce table that the merge field value corresponds to.
        /// </summary>
        /// <value>Specifies the row number in a Salesforce table that the merge field value corresponds to.</value>
        [DataMember(Name="row", EmitDefaultValue=false)]
        public string Row { get; set; }
        /// <summary>
        /// When wet to true, the information entered in the tab automatically updates the related Salesforce data when an envelope is completed.
        /// </summary>
        /// <value>When wet to true, the information entered in the tab automatically updates the related Salesforce data when an envelope is completed.</value>
        [DataMember(Name="writeBack", EmitDefaultValue=false)]
        public string WriteBack { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeField {\n");
            sb.Append("  AllowSenderToEdit: ").Append(AllowSenderToEdit).Append("\n");
            sb.Append("  ConfigurationType: ").Append(ConfigurationType).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Row: ").Append(Row).Append("\n");
            sb.Append("  WriteBack: ").Append(WriteBack).Append("\n");
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
            return this.Equals(obj as MergeField);
        }

        /// <summary>
        /// Returns true if MergeField instances are equal
        /// </summary>
        /// <param name="other">Instance of MergeField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowSenderToEdit == other.AllowSenderToEdit ||
                    this.AllowSenderToEdit != null &&
                    this.AllowSenderToEdit.Equals(other.AllowSenderToEdit)
                ) && 
                (
                    this.ConfigurationType == other.ConfigurationType ||
                    this.ConfigurationType != null &&
                    this.ConfigurationType.Equals(other.ConfigurationType)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Row == other.Row ||
                    this.Row != null &&
                    this.Row.Equals(other.Row)
                ) && 
                (
                    this.WriteBack == other.WriteBack ||
                    this.WriteBack != null &&
                    this.WriteBack.Equals(other.WriteBack)
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
                if (this.AllowSenderToEdit != null)
                    hash = hash * 59 + this.AllowSenderToEdit.GetHashCode();
                if (this.ConfigurationType != null)
                    hash = hash * 59 + this.ConfigurationType.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Row != null)
                    hash = hash * 59 + this.Row.GetHashCode();
                if (this.WriteBack != null)
                    hash = hash * 59 + this.WriteBack.GetHashCode();
                return hash;
            }
        }
    }

}
