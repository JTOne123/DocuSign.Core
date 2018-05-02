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
    public partial class Radio :  IEquatable<Radio>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Radio" /> class.
        /// </summary>
        /// <param name="AnchorCaseSensitive">Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**. - -&gt;.</param>
        /// <param name="AnchorHorizontalAlignment">Reserved for DocuSign. &lt;!- - Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**. - -&gt; .</param>
        /// <param name="AnchorIgnoreIfNotPresent">When set to **true**, this tab is ignored if anchorString is not found in the document..</param>
        /// <param name="AnchorMatchWholeWord">Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**. - -&gt; .</param>
        /// <param name="AnchorString">Anchor text information for a radio button..</param>
        /// <param name="AnchorUnits">Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches..</param>
        /// <param name="AnchorXOffset">Specifies the X axis location of the tab, in achorUnits, relative to the anchorString..</param>
        /// <param name="AnchorYOffset">Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString..</param>
        /// <param name="ErrorDetails">.</param>
        /// <param name="Locked">When set to **true**, the signer cannot change the data of the custom tab..</param>
        /// <param name="PageNumber">Specifies the page number on which the tab is located. Must be 1 for [supplemental documents][supdocs].  [supdocs]: /esign/guide/appendix/glossary.html#supplemental-documents .</param>
        /// <param name="Required">When set to **true**, the signer is required to fill out this tab.</param>
        /// <param name="Selected">When set to **true**, the radio button is selected..</param>
        /// <param name="TabId">The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     .</param>
        /// <param name="TabOrder">.</param>
        /// <param name="Value">Specifies the value of the tab. .</param>
        /// <param name="XPosition">This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position. Required. May be zero. .</param>
        /// <param name="YPosition">This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position..</param>
        public Radio(string AnchorCaseSensitive = null, string AnchorHorizontalAlignment = null, string AnchorIgnoreIfNotPresent = null, string AnchorMatchWholeWord = null, string AnchorString = null, string AnchorUnits = null, string AnchorXOffset = null, string AnchorYOffset = null, ErrorDetails ErrorDetails = null, string Locked = null, string PageNumber = null, string Required = null, string Selected = null, string TabId = null, string TabOrder = null, string Value = null, string XPosition = null, string YPosition = null)
        {
            this.AnchorCaseSensitive = AnchorCaseSensitive;
            this.AnchorHorizontalAlignment = AnchorHorizontalAlignment;
            this.AnchorIgnoreIfNotPresent = AnchorIgnoreIfNotPresent;
            this.AnchorMatchWholeWord = AnchorMatchWholeWord;
            this.AnchorString = AnchorString;
            this.AnchorUnits = AnchorUnits;
            this.AnchorXOffset = AnchorXOffset;
            this.AnchorYOffset = AnchorYOffset;
            this.ErrorDetails = ErrorDetails;
            this.Locked = Locked;
            this.PageNumber = PageNumber;
            this.Required = Required;
            this.Selected = Selected;
            this.TabId = TabId;
            this.TabOrder = TabOrder;
            this.Value = Value;
            this.XPosition = XPosition;
            this.YPosition = YPosition;
        }
        
        /// <summary>
        /// Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**. - -&gt;
        /// </summary>
        /// <value>Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**. - -&gt;</value>
        [DataMember(Name="anchorCaseSensitive", EmitDefaultValue=false)]
        public string AnchorCaseSensitive { get; set; }
        /// <summary>
        /// Reserved for DocuSign. &lt;!- - Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**. - -&gt; 
        /// </summary>
        /// <value>Reserved for DocuSign. &lt;!- - Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**. - -&gt; </value>
        [DataMember(Name="anchorHorizontalAlignment", EmitDefaultValue=false)]
        public string AnchorHorizontalAlignment { get; set; }
        /// <summary>
        /// When set to **true**, this tab is ignored if anchorString is not found in the document.
        /// </summary>
        /// <value>When set to **true**, this tab is ignored if anchorString is not found in the document.</value>
        [DataMember(Name="anchorIgnoreIfNotPresent", EmitDefaultValue=false)]
        public string AnchorIgnoreIfNotPresent { get; set; }
        /// <summary>
        /// Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**. - -&gt; 
        /// </summary>
        /// <value>Reserved for DocuSign. &lt;!- - When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**. - -&gt; </value>
        [DataMember(Name="anchorMatchWholeWord", EmitDefaultValue=false)]
        public string AnchorMatchWholeWord { get; set; }
        /// <summary>
        /// Anchor text information for a radio button.
        /// </summary>
        /// <value>Anchor text information for a radio button.</value>
        [DataMember(Name="anchorString", EmitDefaultValue=false)]
        public string AnchorString { get; set; }
        /// <summary>
        /// Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches.
        /// </summary>
        /// <value>Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches.</value>
        [DataMember(Name="anchorUnits", EmitDefaultValue=false)]
        public string AnchorUnits { get; set; }
        /// <summary>
        /// Specifies the X axis location of the tab, in achorUnits, relative to the anchorString.
        /// </summary>
        /// <value>Specifies the X axis location of the tab, in achorUnits, relative to the anchorString.</value>
        [DataMember(Name="anchorXOffset", EmitDefaultValue=false)]
        public string AnchorXOffset { get; set; }
        /// <summary>
        /// Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString.
        /// </summary>
        /// <value>Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString.</value>
        [DataMember(Name="anchorYOffset", EmitDefaultValue=false)]
        public string AnchorYOffset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// When set to **true**, the signer cannot change the data of the custom tab.
        /// </summary>
        /// <value>When set to **true**, the signer cannot change the data of the custom tab.</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public string Locked { get; set; }
        /// <summary>
        /// Specifies the page number on which the tab is located. Must be 1 for [supplemental documents][supdocs].  [supdocs]: /esign/guide/appendix/glossary.html#supplemental-documents 
        /// </summary>
        /// <value>Specifies the page number on which the tab is located. Must be 1 for [supplemental documents][supdocs].  [supdocs]: /esign/guide/appendix/glossary.html#supplemental-documents </value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public string PageNumber { get; set; }
        /// <summary>
        /// When set to **true**, the signer is required to fill out this tab
        /// </summary>
        /// <value>When set to **true**, the signer is required to fill out this tab</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public string Required { get; set; }
        /// <summary>
        /// When set to **true**, the radio button is selected.
        /// </summary>
        /// <value>When set to **true**, the radio button is selected.</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public string Selected { get; set; }
        /// <summary>
        /// The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     
        /// </summary>
        /// <value>The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     </value>
        [DataMember(Name="tabId", EmitDefaultValue=false)]
        public string TabId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="tabOrder", EmitDefaultValue=false)]
        public string TabOrder { get; set; }
        /// <summary>
        /// Specifies the value of the tab. 
        /// </summary>
        /// <value>Specifies the value of the tab. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position. Required. May be zero. 
        /// </summary>
        /// <value>This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position. Required. May be zero. </value>
        [DataMember(Name="xPosition", EmitDefaultValue=false)]
        public string XPosition { get; set; }
        /// <summary>
        /// This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position.
        /// </summary>
        /// <value>This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position.</value>
        [DataMember(Name="yPosition", EmitDefaultValue=false)]
        public string YPosition { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Radio {\n");
            sb.Append("  AnchorCaseSensitive: ").Append(AnchorCaseSensitive).Append("\n");
            sb.Append("  AnchorHorizontalAlignment: ").Append(AnchorHorizontalAlignment).Append("\n");
            sb.Append("  AnchorIgnoreIfNotPresent: ").Append(AnchorIgnoreIfNotPresent).Append("\n");
            sb.Append("  AnchorMatchWholeWord: ").Append(AnchorMatchWholeWord).Append("\n");
            sb.Append("  AnchorString: ").Append(AnchorString).Append("\n");
            sb.Append("  AnchorUnits: ").Append(AnchorUnits).Append("\n");
            sb.Append("  AnchorXOffset: ").Append(AnchorXOffset).Append("\n");
            sb.Append("  AnchorYOffset: ").Append(AnchorYOffset).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  TabId: ").Append(TabId).Append("\n");
            sb.Append("  TabOrder: ").Append(TabOrder).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  XPosition: ").Append(XPosition).Append("\n");
            sb.Append("  YPosition: ").Append(YPosition).Append("\n");
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
            return this.Equals(obj as Radio);
        }

        /// <summary>
        /// Returns true if Radio instances are equal
        /// </summary>
        /// <param name="other">Instance of Radio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Radio other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AnchorCaseSensitive == other.AnchorCaseSensitive ||
                    this.AnchorCaseSensitive != null &&
                    this.AnchorCaseSensitive.Equals(other.AnchorCaseSensitive)
                ) && 
                (
                    this.AnchorHorizontalAlignment == other.AnchorHorizontalAlignment ||
                    this.AnchorHorizontalAlignment != null &&
                    this.AnchorHorizontalAlignment.Equals(other.AnchorHorizontalAlignment)
                ) && 
                (
                    this.AnchorIgnoreIfNotPresent == other.AnchorIgnoreIfNotPresent ||
                    this.AnchorIgnoreIfNotPresent != null &&
                    this.AnchorIgnoreIfNotPresent.Equals(other.AnchorIgnoreIfNotPresent)
                ) && 
                (
                    this.AnchorMatchWholeWord == other.AnchorMatchWholeWord ||
                    this.AnchorMatchWholeWord != null &&
                    this.AnchorMatchWholeWord.Equals(other.AnchorMatchWholeWord)
                ) && 
                (
                    this.AnchorString == other.AnchorString ||
                    this.AnchorString != null &&
                    this.AnchorString.Equals(other.AnchorString)
                ) && 
                (
                    this.AnchorUnits == other.AnchorUnits ||
                    this.AnchorUnits != null &&
                    this.AnchorUnits.Equals(other.AnchorUnits)
                ) && 
                (
                    this.AnchorXOffset == other.AnchorXOffset ||
                    this.AnchorXOffset != null &&
                    this.AnchorXOffset.Equals(other.AnchorXOffset)
                ) && 
                (
                    this.AnchorYOffset == other.AnchorYOffset ||
                    this.AnchorYOffset != null &&
                    this.AnchorYOffset.Equals(other.AnchorYOffset)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Selected == other.Selected ||
                    this.Selected != null &&
                    this.Selected.Equals(other.Selected)
                ) && 
                (
                    this.TabId == other.TabId ||
                    this.TabId != null &&
                    this.TabId.Equals(other.TabId)
                ) && 
                (
                    this.TabOrder == other.TabOrder ||
                    this.TabOrder != null &&
                    this.TabOrder.Equals(other.TabOrder)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.XPosition == other.XPosition ||
                    this.XPosition != null &&
                    this.XPosition.Equals(other.XPosition)
                ) && 
                (
                    this.YPosition == other.YPosition ||
                    this.YPosition != null &&
                    this.YPosition.Equals(other.YPosition)
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
                if (this.AnchorCaseSensitive != null)
                    hash = hash * 59 + this.AnchorCaseSensitive.GetHashCode();
                if (this.AnchorHorizontalAlignment != null)
                    hash = hash * 59 + this.AnchorHorizontalAlignment.GetHashCode();
                if (this.AnchorIgnoreIfNotPresent != null)
                    hash = hash * 59 + this.AnchorIgnoreIfNotPresent.GetHashCode();
                if (this.AnchorMatchWholeWord != null)
                    hash = hash * 59 + this.AnchorMatchWholeWord.GetHashCode();
                if (this.AnchorString != null)
                    hash = hash * 59 + this.AnchorString.GetHashCode();
                if (this.AnchorUnits != null)
                    hash = hash * 59 + this.AnchorUnits.GetHashCode();
                if (this.AnchorXOffset != null)
                    hash = hash * 59 + this.AnchorXOffset.GetHashCode();
                if (this.AnchorYOffset != null)
                    hash = hash * 59 + this.AnchorYOffset.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.Selected != null)
                    hash = hash * 59 + this.Selected.GetHashCode();
                if (this.TabId != null)
                    hash = hash * 59 + this.TabId.GetHashCode();
                if (this.TabOrder != null)
                    hash = hash * 59 + this.TabOrder.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.XPosition != null)
                    hash = hash * 59 + this.XPosition.GetHashCode();
                if (this.YPosition != null)
                    hash = hash * 59 + this.YPosition.GetHashCode();
                return hash;
            }
        }
    }

}