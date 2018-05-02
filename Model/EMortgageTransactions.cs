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
    public partial class EMortgageTransactions :  IEquatable<EMortgageTransactions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EMortgageTransactions" /> class.
        /// </summary>
        /// <param name="DocumentData">.</param>
        /// <param name="DptName">.</param>
        /// <param name="TransactionName">.</param>
        /// <param name="TransactionTypeName">.</param>
        public EMortgageTransactions(string DocumentData = null, string DptName = null, string TransactionName = null, string TransactionTypeName = null)
        {
            this.DocumentData = DocumentData;
            this.DptName = DptName;
            this.TransactionName = TransactionName;
            this.TransactionTypeName = TransactionTypeName;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentData", EmitDefaultValue=false)]
        public string DocumentData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dptName", EmitDefaultValue=false)]
        public string DptName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="transactionName", EmitDefaultValue=false)]
        public string TransactionName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="transactionTypeName", EmitDefaultValue=false)]
        public string TransactionTypeName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EMortgageTransactions {\n");
            sb.Append("  DocumentData: ").Append(DocumentData).Append("\n");
            sb.Append("  DptName: ").Append(DptName).Append("\n");
            sb.Append("  TransactionName: ").Append(TransactionName).Append("\n");
            sb.Append("  TransactionTypeName: ").Append(TransactionTypeName).Append("\n");
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
            return this.Equals(obj as EMortgageTransactions);
        }

        /// <summary>
        /// Returns true if EMortgageTransactions instances are equal
        /// </summary>
        /// <param name="other">Instance of EMortgageTransactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EMortgageTransactions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentData == other.DocumentData ||
                    this.DocumentData != null &&
                    this.DocumentData.Equals(other.DocumentData)
                ) && 
                (
                    this.DptName == other.DptName ||
                    this.DptName != null &&
                    this.DptName.Equals(other.DptName)
                ) && 
                (
                    this.TransactionName == other.TransactionName ||
                    this.TransactionName != null &&
                    this.TransactionName.Equals(other.TransactionName)
                ) && 
                (
                    this.TransactionTypeName == other.TransactionTypeName ||
                    this.TransactionTypeName != null &&
                    this.TransactionTypeName.Equals(other.TransactionTypeName)
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
                if (this.DocumentData != null)
                    hash = hash * 59 + this.DocumentData.GetHashCode();
                if (this.DptName != null)
                    hash = hash * 59 + this.DptName.GetHashCode();
                if (this.TransactionName != null)
                    hash = hash * 59 + this.TransactionName.GetHashCode();
                if (this.TransactionTypeName != null)
                    hash = hash * 59 + this.TransactionTypeName.GetHashCode();
                return hash;
            }
        }
    }

}