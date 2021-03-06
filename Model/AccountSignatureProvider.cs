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
    public partial class AccountSignatureProvider :  IEquatable<AccountSignatureProvider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSignatureProvider" /> class.
        /// </summary>
        /// <param name="IsRequired">.</param>
        /// <param name="Priority">.</param>
        /// <param name="SignatureProviderDisplayName">.</param>
        /// <param name="SignatureProviderId">.</param>
        /// <param name="SignatureProviderName">The name of an Electronic or Standards Based Signature (digital signature) provider for the signer to use. [The current provider list.](../../../../guide/appendix/standards_based_signatures.html#signature-provider-options).</param>
        /// <param name="SignatureProviderOptionsMetadata">.</param>
        /// <param name="SignatureProviderRequiredOptions">.</param>
        public AccountSignatureProvider(string IsRequired = null, string Priority = null, string SignatureProviderDisplayName = null, string SignatureProviderId = null, string SignatureProviderName = null, List<AccountSignatureProviderOption> SignatureProviderOptionsMetadata = null, List<SignatureProviderRequiredOption> SignatureProviderRequiredOptions = null)
        {
            this.IsRequired = IsRequired;
            this.Priority = Priority;
            this.SignatureProviderDisplayName = SignatureProviderDisplayName;
            this.SignatureProviderId = SignatureProviderId;
            this.SignatureProviderName = SignatureProviderName;
            this.SignatureProviderOptionsMetadata = SignatureProviderOptionsMetadata;
            this.SignatureProviderRequiredOptions = SignatureProviderRequiredOptions;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public string IsRequired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public string Priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureProviderDisplayName", EmitDefaultValue=false)]
        public string SignatureProviderDisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureProviderId", EmitDefaultValue=false)]
        public string SignatureProviderId { get; set; }
        /// <summary>
        /// The name of an Electronic or Standards Based Signature (digital signature) provider for the signer to use. [The current provider list.](../../../../guide/appendix/standards_based_signatures.html#signature-provider-options)
        /// </summary>
        /// <value>The name of an Electronic or Standards Based Signature (digital signature) provider for the signer to use. [The current provider list.](../../../../guide/appendix/standards_based_signatures.html#signature-provider-options)</value>
        [DataMember(Name="signatureProviderName", EmitDefaultValue=false)]
        public string SignatureProviderName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureProviderOptionsMetadata", EmitDefaultValue=false)]
        public List<AccountSignatureProviderOption> SignatureProviderOptionsMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureProviderRequiredOptions", EmitDefaultValue=false)]
        public List<SignatureProviderRequiredOption> SignatureProviderRequiredOptions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSignatureProvider {\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  SignatureProviderDisplayName: ").Append(SignatureProviderDisplayName).Append("\n");
            sb.Append("  SignatureProviderId: ").Append(SignatureProviderId).Append("\n");
            sb.Append("  SignatureProviderName: ").Append(SignatureProviderName).Append("\n");
            sb.Append("  SignatureProviderOptionsMetadata: ").Append(SignatureProviderOptionsMetadata).Append("\n");
            sb.Append("  SignatureProviderRequiredOptions: ").Append(SignatureProviderRequiredOptions).Append("\n");
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
            return this.Equals(obj as AccountSignatureProvider);
        }

        /// <summary>
        /// Returns true if AccountSignatureProvider instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSignatureProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSignatureProvider other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsRequired == other.IsRequired ||
                    this.IsRequired != null &&
                    this.IsRequired.Equals(other.IsRequired)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.SignatureProviderDisplayName == other.SignatureProviderDisplayName ||
                    this.SignatureProviderDisplayName != null &&
                    this.SignatureProviderDisplayName.Equals(other.SignatureProviderDisplayName)
                ) && 
                (
                    this.SignatureProviderId == other.SignatureProviderId ||
                    this.SignatureProviderId != null &&
                    this.SignatureProviderId.Equals(other.SignatureProviderId)
                ) && 
                (
                    this.SignatureProviderName == other.SignatureProviderName ||
                    this.SignatureProviderName != null &&
                    this.SignatureProviderName.Equals(other.SignatureProviderName)
                ) && 
                (
                    this.SignatureProviderOptionsMetadata == other.SignatureProviderOptionsMetadata ||
                    this.SignatureProviderOptionsMetadata != null &&
                    this.SignatureProviderOptionsMetadata.SequenceEqual(other.SignatureProviderOptionsMetadata)
                ) && 
                (
                    this.SignatureProviderRequiredOptions == other.SignatureProviderRequiredOptions ||
                    this.SignatureProviderRequiredOptions != null &&
                    this.SignatureProviderRequiredOptions.SequenceEqual(other.SignatureProviderRequiredOptions)
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
                if (this.IsRequired != null)
                    hash = hash * 59 + this.IsRequired.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.SignatureProviderDisplayName != null)
                    hash = hash * 59 + this.SignatureProviderDisplayName.GetHashCode();
                if (this.SignatureProviderId != null)
                    hash = hash * 59 + this.SignatureProviderId.GetHashCode();
                if (this.SignatureProviderName != null)
                    hash = hash * 59 + this.SignatureProviderName.GetHashCode();
                if (this.SignatureProviderOptionsMetadata != null)
                    hash = hash * 59 + this.SignatureProviderOptionsMetadata.GetHashCode();
                if (this.SignatureProviderRequiredOptions != null)
                    hash = hash * 59 + this.SignatureProviderRequiredOptions.GetHashCode();
                return hash;
            }
        }
    }

}
