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
    public partial class SenderEmailNotifications :  IEquatable<SenderEmailNotifications>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderEmailNotifications" /> class.
        /// </summary>
        /// <param name="ChangedSigner">When set to **true**, the sender receives notification if the signer changes..</param>
        /// <param name="CommentsOnlyPrivateAndMention">.</param>
        /// <param name="CommentsReceiveAll">.</param>
        /// <param name="DeliveryFailed">When set to **true**, the sender receives notification if the delivery of the envelope fails..</param>
        /// <param name="EnvelopeComplete">When set to **true**, the user receives notification that the envelope has been completed..</param>
        /// <param name="OfflineSigningFailed">When set to **true**, the user receives notification if the offline signing failed..</param>
        /// <param name="RecipientViewed">When set to **true**, the sender receives notification that the recipient viewed the enveloper..</param>
        /// <param name="SenderEnvelopeDeclined">.</param>
        /// <param name="WithdrawnConsent">When set to **true**, the user receives notification if consent is withdrawn..</param>
        public SenderEmailNotifications(string ChangedSigner = null, string CommentsOnlyPrivateAndMention = null, string CommentsReceiveAll = null, string DeliveryFailed = null, string EnvelopeComplete = null, string OfflineSigningFailed = null, string RecipientViewed = null, string SenderEnvelopeDeclined = null, string WithdrawnConsent = null)
        {
            this.ChangedSigner = ChangedSigner;
            this.CommentsOnlyPrivateAndMention = CommentsOnlyPrivateAndMention;
            this.CommentsReceiveAll = CommentsReceiveAll;
            this.DeliveryFailed = DeliveryFailed;
            this.EnvelopeComplete = EnvelopeComplete;
            this.OfflineSigningFailed = OfflineSigningFailed;
            this.RecipientViewed = RecipientViewed;
            this.SenderEnvelopeDeclined = SenderEnvelopeDeclined;
            this.WithdrawnConsent = WithdrawnConsent;
        }
        
        /// <summary>
        /// When set to **true**, the sender receives notification if the signer changes.
        /// </summary>
        /// <value>When set to **true**, the sender receives notification if the signer changes.</value>
        [DataMember(Name="changedSigner", EmitDefaultValue=false)]
        public string ChangedSigner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="commentsOnlyPrivateAndMention", EmitDefaultValue=false)]
        public string CommentsOnlyPrivateAndMention { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="commentsReceiveAll", EmitDefaultValue=false)]
        public string CommentsReceiveAll { get; set; }
        /// <summary>
        /// When set to **true**, the sender receives notification if the delivery of the envelope fails.
        /// </summary>
        /// <value>When set to **true**, the sender receives notification if the delivery of the envelope fails.</value>
        [DataMember(Name="deliveryFailed", EmitDefaultValue=false)]
        public string DeliveryFailed { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been completed.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been completed.</value>
        [DataMember(Name="envelopeComplete", EmitDefaultValue=false)]
        public string EnvelopeComplete { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification if the offline signing failed.
        /// </summary>
        /// <value>When set to **true**, the user receives notification if the offline signing failed.</value>
        [DataMember(Name="offlineSigningFailed", EmitDefaultValue=false)]
        public string OfflineSigningFailed { get; set; }
        /// <summary>
        /// When set to **true**, the sender receives notification that the recipient viewed the enveloper.
        /// </summary>
        /// <value>When set to **true**, the sender receives notification that the recipient viewed the enveloper.</value>
        [DataMember(Name="recipientViewed", EmitDefaultValue=false)]
        public string RecipientViewed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="senderEnvelopeDeclined", EmitDefaultValue=false)]
        public string SenderEnvelopeDeclined { get; set; }
        /// <summary>
        /// When set to **true**, the user receives notification if consent is withdrawn.
        /// </summary>
        /// <value>When set to **true**, the user receives notification if consent is withdrawn.</value>
        [DataMember(Name="withdrawnConsent", EmitDefaultValue=false)]
        public string WithdrawnConsent { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SenderEmailNotifications {\n");
            sb.Append("  ChangedSigner: ").Append(ChangedSigner).Append("\n");
            sb.Append("  CommentsOnlyPrivateAndMention: ").Append(CommentsOnlyPrivateAndMention).Append("\n");
            sb.Append("  CommentsReceiveAll: ").Append(CommentsReceiveAll).Append("\n");
            sb.Append("  DeliveryFailed: ").Append(DeliveryFailed).Append("\n");
            sb.Append("  EnvelopeComplete: ").Append(EnvelopeComplete).Append("\n");
            sb.Append("  OfflineSigningFailed: ").Append(OfflineSigningFailed).Append("\n");
            sb.Append("  RecipientViewed: ").Append(RecipientViewed).Append("\n");
            sb.Append("  SenderEnvelopeDeclined: ").Append(SenderEnvelopeDeclined).Append("\n");
            sb.Append("  WithdrawnConsent: ").Append(WithdrawnConsent).Append("\n");
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
            return this.Equals(obj as SenderEmailNotifications);
        }

        /// <summary>
        /// Returns true if SenderEmailNotifications instances are equal
        /// </summary>
        /// <param name="other">Instance of SenderEmailNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SenderEmailNotifications other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChangedSigner == other.ChangedSigner ||
                    this.ChangedSigner != null &&
                    this.ChangedSigner.Equals(other.ChangedSigner)
                ) && 
                (
                    this.CommentsOnlyPrivateAndMention == other.CommentsOnlyPrivateAndMention ||
                    this.CommentsOnlyPrivateAndMention != null &&
                    this.CommentsOnlyPrivateAndMention.Equals(other.CommentsOnlyPrivateAndMention)
                ) && 
                (
                    this.CommentsReceiveAll == other.CommentsReceiveAll ||
                    this.CommentsReceiveAll != null &&
                    this.CommentsReceiveAll.Equals(other.CommentsReceiveAll)
                ) && 
                (
                    this.DeliveryFailed == other.DeliveryFailed ||
                    this.DeliveryFailed != null &&
                    this.DeliveryFailed.Equals(other.DeliveryFailed)
                ) && 
                (
                    this.EnvelopeComplete == other.EnvelopeComplete ||
                    this.EnvelopeComplete != null &&
                    this.EnvelopeComplete.Equals(other.EnvelopeComplete)
                ) && 
                (
                    this.OfflineSigningFailed == other.OfflineSigningFailed ||
                    this.OfflineSigningFailed != null &&
                    this.OfflineSigningFailed.Equals(other.OfflineSigningFailed)
                ) && 
                (
                    this.RecipientViewed == other.RecipientViewed ||
                    this.RecipientViewed != null &&
                    this.RecipientViewed.Equals(other.RecipientViewed)
                ) && 
                (
                    this.SenderEnvelopeDeclined == other.SenderEnvelopeDeclined ||
                    this.SenderEnvelopeDeclined != null &&
                    this.SenderEnvelopeDeclined.Equals(other.SenderEnvelopeDeclined)
                ) && 
                (
                    this.WithdrawnConsent == other.WithdrawnConsent ||
                    this.WithdrawnConsent != null &&
                    this.WithdrawnConsent.Equals(other.WithdrawnConsent)
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
                if (this.ChangedSigner != null)
                    hash = hash * 59 + this.ChangedSigner.GetHashCode();
                if (this.CommentsOnlyPrivateAndMention != null)
                    hash = hash * 59 + this.CommentsOnlyPrivateAndMention.GetHashCode();
                if (this.CommentsReceiveAll != null)
                    hash = hash * 59 + this.CommentsReceiveAll.GetHashCode();
                if (this.DeliveryFailed != null)
                    hash = hash * 59 + this.DeliveryFailed.GetHashCode();
                if (this.EnvelopeComplete != null)
                    hash = hash * 59 + this.EnvelopeComplete.GetHashCode();
                if (this.OfflineSigningFailed != null)
                    hash = hash * 59 + this.OfflineSigningFailed.GetHashCode();
                if (this.RecipientViewed != null)
                    hash = hash * 59 + this.RecipientViewed.GetHashCode();
                if (this.SenderEnvelopeDeclined != null)
                    hash = hash * 59 + this.SenderEnvelopeDeclined.GetHashCode();
                if (this.WithdrawnConsent != null)
                    hash = hash * 59 + this.WithdrawnConsent.GetHashCode();
                return hash;
            }
        }
    }

}
