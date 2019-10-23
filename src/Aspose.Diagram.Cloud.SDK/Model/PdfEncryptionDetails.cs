// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfEncryptionDetails.cs">
//   Copyright (c) 2016 Aspose.Diagram for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Diagram.Cloud.SDK.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// 
  /// </summary>  
  [DataContract]
  public class PdfEncryptionDetails 
  {                       
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionsEnum
        {
            
            /// <summary>
            /// Enum DisallowAll for "DisallowAll"
            /// </summary>
            [EnumMember(Value = "DisallowAll")]
            DisallowAll,
            
            /// <summary>
            /// Enum Printing for "Printing"
            /// </summary>
            [EnumMember(Value = "Printing")]
            Printing,
            
            /// <summary>
            /// Enum ModifyContents for "ModifyContents"
            /// </summary>
            [EnumMember(Value = "ModifyContents")]
            ModifyContents,
            
            /// <summary>
            /// Enum ContentCopy for "ContentCopy"
            /// </summary>
            [EnumMember(Value = "ContentCopy")]
            ContentCopy,
            
            /// <summary>
            /// Enum ModifyAnnotations for "ModifyAnnotations"
            /// </summary>
            [EnumMember(Value = "ModifyAnnotations")]
            ModifyAnnotations,
            
            /// <summary>
            /// Enum FillIn for "FillIn"
            /// </summary>
            [EnumMember(Value = "FillIn")]
            FillIn,
            
            /// <summary>
            /// Enum ContentCopyForAccessibility for "ContentCopyForAccessibility"
            /// </summary>
            [EnumMember(Value = "ContentCopyForAccessibility")]
            ContentCopyForAccessibility,
            
            /// <summary>
            /// Enum DocumentAssembly for "DocumentAssembly"
            /// </summary>
            [EnumMember(Value = "DocumentAssembly")]
            DocumentAssembly,
            
            /// <summary>
            /// Enum HighResolutionPrinting for "HighResolutionPrinting"
            /// </summary>
            [EnumMember(Value = "HighResolutionPrinting")]
            HighResolutionPrinting,
            
            /// <summary>
            /// Enum AllowAll for "AllowAll"
            /// </summary>
            [EnumMember(Value = "AllowAll")]
            AllowAll
        }

        /// <summary>
        /// Gets or Sets EncryptionAlgorithm
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionAlgorithmEnum
        {
            
            /// <summary>
            /// Enum _40 for "RC4_40"
            /// </summary>
            [EnumMember(Value = "RC4_40")]
            _40,
            
            /// <summary>
            /// Enum _128 for "RC4_128"
            /// </summary>
            [EnumMember(Value = "RC4_128")]
            _128
        }

        /// <summary>
        /// Gets or sets Permissions
        /// </summary>
				
        public PermissionsEnum? Permissions { get; set; }

        /// <summary>
        /// Gets or sets EncryptionAlgorithm
        /// </summary>
				
        public EncryptionAlgorithmEnum? EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets UserPassword
        /// </summary>  
		[DataMember(Name="UserPassword", EmitDefaultValue=false)]
        public string UserPassword { get; set; }

        /// <summary>
        /// Gets or sets OwnerPassword
        /// </summary>  
		[DataMember(Name="OwnerPassword", EmitDefaultValue=false)]
        public string OwnerPassword { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfEncryptionDetails {\n");
          sb.Append("  Permissions: ").Append(this.Permissions).Append("\n");
          sb.Append("  EncryptionAlgorithm: ").Append(this.EncryptionAlgorithm).Append("\n");
          sb.Append("  UserPassword: ").Append(this.UserPassword).Append("\n");
          sb.Append("  OwnerPassword: ").Append(this.OwnerPassword).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
