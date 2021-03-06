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
    /// Defines a billing invoice response object.
    /// </summary>
    [DataContract]
    public partial class BillingInvoicesResponse :  IEquatable<BillingInvoicesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoicesResponse" /> class.
        /// </summary>
        /// <param name="BillingInvoices">Reserved: TBD.</param>
        /// <param name="NextUri">The URI for the next chunk of records based on the search request. It is &#x60;null&#x60; if this is the last set of results for the search. .</param>
        /// <param name="PreviousUri">The URI for the prior chunk of records based on the search request. It is &#x60;null&#x60; if this is the first set of results for the search. .</param>
        public BillingInvoicesResponse(List<Invoices> BillingInvoices = null, string NextUri = null, string PreviousUri = null)
        {
            this.BillingInvoices = BillingInvoices;
            this.NextUri = NextUri;
            this.PreviousUri = PreviousUri;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingInvoices", EmitDefaultValue=false)]
        public List<Invoices> BillingInvoices { get; set; }
        /// <summary>
        /// The URI for the next chunk of records based on the search request. It is &#x60;null&#x60; if this is the last set of results for the search. 
        /// </summary>
        /// <value>The URI for the next chunk of records based on the search request. It is &#x60;null&#x60; if this is the last set of results for the search. </value>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
        /// <summary>
        /// The URI for the prior chunk of records based on the search request. It is &#x60;null&#x60; if this is the first set of results for the search. 
        /// </summary>
        /// <value>The URI for the prior chunk of records based on the search request. It is &#x60;null&#x60; if this is the first set of results for the search. </value>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingInvoicesResponse {\n");
            sb.Append("  BillingInvoices: ").Append(BillingInvoices).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
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
            return this.Equals(obj as BillingInvoicesResponse);
        }

        /// <summary>
        /// Returns true if BillingInvoicesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingInvoicesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingInvoicesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillingInvoices == other.BillingInvoices ||
                    this.BillingInvoices != null &&
                    this.BillingInvoices.SequenceEqual(other.BillingInvoices)
                ) && 
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) && 
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
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
                if (this.BillingInvoices != null)
                    hash = hash * 59 + this.BillingInvoices.GetHashCode();
                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();
                if (this.PreviousUri != null)
                    hash = hash * 59 + this.PreviousUri.GetHashCode();
                return hash;
            }
        }
    }

}
