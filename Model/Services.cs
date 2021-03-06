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
    /// API service information
    /// </summary>
    [DataContract]
    public partial class Services :  IEquatable<Services>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Services" /> class.
        /// </summary>
        /// <param name="BuildBranch">Reserved: TBD.</param>
        /// <param name="BuildBranchDeployedDateTime">Reserved: TBD.</param>
        /// <param name="BuildSHA">Reserved: TBD.</param>
        /// <param name="BuildVersion">Reserved: TBD.</param>
        /// <param name="LinkedSites">.</param>
        /// <param name="ServiceVersions">.</param>
        public Services(string BuildBranch = null, string BuildBranchDeployedDateTime = null, string BuildSHA = null, string BuildVersion = null, List<string> LinkedSites = null, List<ServiceVersion> ServiceVersions = null)
        {
            this.BuildBranch = BuildBranch;
            this.BuildBranchDeployedDateTime = BuildBranchDeployedDateTime;
            this.BuildSHA = BuildSHA;
            this.BuildVersion = BuildVersion;
            this.LinkedSites = LinkedSites;
            this.ServiceVersions = ServiceVersions;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="buildBranch", EmitDefaultValue=false)]
        public string BuildBranch { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="buildBranchDeployedDateTime", EmitDefaultValue=false)]
        public string BuildBranchDeployedDateTime { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="buildSHA", EmitDefaultValue=false)]
        public string BuildSHA { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="buildVersion", EmitDefaultValue=false)]
        public string BuildVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="linkedSites", EmitDefaultValue=false)]
        public List<string> LinkedSites { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="serviceVersions", EmitDefaultValue=false)]
        public List<ServiceVersion> ServiceVersions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Services {\n");
            sb.Append("  BuildBranch: ").Append(BuildBranch).Append("\n");
            sb.Append("  BuildBranchDeployedDateTime: ").Append(BuildBranchDeployedDateTime).Append("\n");
            sb.Append("  BuildSHA: ").Append(BuildSHA).Append("\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
            sb.Append("  LinkedSites: ").Append(LinkedSites).Append("\n");
            sb.Append("  ServiceVersions: ").Append(ServiceVersions).Append("\n");
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
            return this.Equals(obj as Services);
        }

        /// <summary>
        /// Returns true if Services instances are equal
        /// </summary>
        /// <param name="other">Instance of Services to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Services other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BuildBranch == other.BuildBranch ||
                    this.BuildBranch != null &&
                    this.BuildBranch.Equals(other.BuildBranch)
                ) && 
                (
                    this.BuildBranchDeployedDateTime == other.BuildBranchDeployedDateTime ||
                    this.BuildBranchDeployedDateTime != null &&
                    this.BuildBranchDeployedDateTime.Equals(other.BuildBranchDeployedDateTime)
                ) && 
                (
                    this.BuildSHA == other.BuildSHA ||
                    this.BuildSHA != null &&
                    this.BuildSHA.Equals(other.BuildSHA)
                ) && 
                (
                    this.BuildVersion == other.BuildVersion ||
                    this.BuildVersion != null &&
                    this.BuildVersion.Equals(other.BuildVersion)
                ) && 
                (
                    this.LinkedSites == other.LinkedSites ||
                    this.LinkedSites != null &&
                    this.LinkedSites.SequenceEqual(other.LinkedSites)
                ) && 
                (
                    this.ServiceVersions == other.ServiceVersions ||
                    this.ServiceVersions != null &&
                    this.ServiceVersions.SequenceEqual(other.ServiceVersions)
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
                if (this.BuildBranch != null)
                    hash = hash * 59 + this.BuildBranch.GetHashCode();
                if (this.BuildBranchDeployedDateTime != null)
                    hash = hash * 59 + this.BuildBranchDeployedDateTime.GetHashCode();
                if (this.BuildSHA != null)
                    hash = hash * 59 + this.BuildSHA.GetHashCode();
                if (this.BuildVersion != null)
                    hash = hash * 59 + this.BuildVersion.GetHashCode();
                if (this.LinkedSites != null)
                    hash = hash * 59 + this.LinkedSites.GetHashCode();
                if (this.ServiceVersions != null)
                    hash = hash * 59 + this.ServiceVersions.GetHashCode();
                return hash;
            }
        }
    }

}
