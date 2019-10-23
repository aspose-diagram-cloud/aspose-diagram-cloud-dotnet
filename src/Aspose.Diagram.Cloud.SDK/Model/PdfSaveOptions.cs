// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfSaveOptions.cs">
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
  public class PdfSaveOptions : RenderingSaveOptions 
  {                       
        /// <summary>
        /// Gets or Sets Compliance
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplianceEnum
        {
            
            /// <summary>
            /// Enum Pdf15 for "Pdf15"
            /// </summary>
            [EnumMember(Value = "Pdf15")]
            Pdf15,
            
            /// <summary>
            /// Enum PdfA1a for "PdfA1a"
            /// </summary>
            [EnumMember(Value = "PdfA1a")]
            PdfA1a,
            
            /// <summary>
            /// Enum PdfA1b for "PdfA1b"
            /// </summary>
            [EnumMember(Value = "PdfA1b")]
            PdfA1b
        }

        /// <summary>
        /// Gets or Sets TextCompression
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextCompressionEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Flate for "Flate"
            /// </summary>
            [EnumMember(Value = "Flate")]
            Flate
        }

        /// <summary>
        /// Gets or sets Compliance
        /// </summary>
				
        public ComplianceEnum? Compliance { get; set; }

        /// <summary>
        /// Gets or sets TextCompression
        /// </summary>
				
        public TextCompressionEnum? TextCompression { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution
        /// </summary>  
		[DataMember(Name="HorizontalResolution", EmitDefaultValue=false)]
        public int? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets VerticalResolution
        /// </summary>  
		[DataMember(Name="VerticalResolution", EmitDefaultValue=false)]
        public int? VerticalResolution { get; set; }

        /// <summary>
        /// Gets or sets PageCount
        /// </summary>  
		[DataMember(Name="PageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets JpegQuality
        /// </summary>  
		[DataMember(Name="JpegQuality", EmitDefaultValue=false)]
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or sets ExportHiddenPage
        /// </summary>  
		[DataMember(Name="ExportHiddenPage", EmitDefaultValue=false)]
        public bool? ExportHiddenPage { get; set; }

        /// <summary>
        /// Gets or sets PageIndex
        /// </summary>  
		[DataMember(Name="PageIndex", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets SaveForegroundPagesOnly
        /// </summary>  
		[DataMember(Name="SaveForegroundPagesOnly", EmitDefaultValue=false)]
        public bool? SaveForegroundPagesOnly { get; set; }

        /// <summary>
        /// Gets or sets EncryptionDetails
        /// </summary>  
		[DataMember(Name="EncryptionDetails", EmitDefaultValue=false)]
        public PdfEncryptionDetails EncryptionDetails { get; set; }

        /// <summary>
        /// Gets or sets SplitMultiPages
        /// </summary>  
		[DataMember(Name="SplitMultiPages", EmitDefaultValue=false)]
        public bool? SplitMultiPages { get; set; }

        /// <summary>
        /// Gets or sets DigitalSignatureDetails
        /// </summary>  
		[DataMember(Name="DigitalSignatureDetails", EmitDefaultValue=false)]
        public PdfDigitalSignatureDetails DigitalSignatureDetails { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfSaveOptions {\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
          sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
          sb.Append("  ExportHiddenPage: ").Append(this.ExportHiddenPage).Append("\n");
          sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
          sb.Append("  SaveForegroundPagesOnly: ").Append(this.SaveForegroundPagesOnly).Append("\n");
          sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
          sb.Append("  EncryptionDetails: ").Append(this.EncryptionDetails).Append("\n");
          sb.Append("  TextCompression: ").Append(this.TextCompression).Append("\n");
          sb.Append("  SplitMultiPages: ").Append(this.SplitMultiPages).Append("\n");
          sb.Append("  DigitalSignatureDetails: ").Append(this.DigitalSignatureDetails).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
