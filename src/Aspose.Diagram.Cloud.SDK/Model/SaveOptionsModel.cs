// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveOptionsModel.cs">
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
  public class SaveOptionsModel 
  {                       
        /// <summary>
        /// Gets or Sets SaveFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SaveFormatEnum
        {
            
            /// <summary>
            /// Enum VDX for "VDX"
            /// </summary>
            [EnumMember(Value = "VDX")]
            VDX,
            
            /// <summary>
            /// Enum VSX for "VSX"
            /// </summary>
            [EnumMember(Value = "VSX")]
            VSX,
            
            /// <summary>
            /// Enum VTX for "VTX"
            /// </summary>
            [EnumMember(Value = "VTX")]
            VTX,
            
            /// <summary>
            /// Enum TIFF for "TIFF"
            /// </summary>
            [EnumMember(Value = "TIFF")]
            TIFF,
            
            /// <summary>
            /// Enum PNG for "PNG"
            /// </summary>
            [EnumMember(Value = "PNG")]
            PNG,
            
            /// <summary>
            /// Enum BMP for "BMP"
            /// </summary>
            [EnumMember(Value = "BMP")]
            BMP,
            
            /// <summary>
            /// Enum EMF for "EMF"
            /// </summary>
            [EnumMember(Value = "EMF")]
            EMF,
            
            /// <summary>
            /// Enum JPEG for "JPEG"
            /// </summary>
            [EnumMember(Value = "JPEG")]
            JPEG,
            
            /// <summary>
            /// Enum PDF for "PDF"
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF,
            
            /// <summary>
            /// Enum XPS for "XPS"
            /// </summary>
            [EnumMember(Value = "XPS")]
            XPS,
            
            /// <summary>
            /// Enum GIF for "GIF"
            /// </summary>
            [EnumMember(Value = "GIF")]
            GIF,
            
            /// <summary>
            /// Enum HTML for "HTML"
            /// </summary>
            [EnumMember(Value = "HTML")]
            HTML,
            
            /// <summary>
            /// Enum SVG for "SVG"
            /// </summary>
            [EnumMember(Value = "SVG")]
            SVG,
            
            /// <summary>
            /// Enum SWF for "SWF"
            /// </summary>
            [EnumMember(Value = "SWF")]
            SWF,
            
            /// <summary>
            /// Enum XAML for "XAML"
            /// </summary>
            [EnumMember(Value = "XAML")]
            XAML,
            
            /// <summary>
            /// Enum VSDX for "VSDX"
            /// </summary>
            [EnumMember(Value = "VSDX")]
            VSDX,
            
            /// <summary>
            /// Enum VSTX for "VSTX"
            /// </summary>
            [EnumMember(Value = "VSTX")]
            VSTX,
            
            /// <summary>
            /// Enum VSSX for "VSSX"
            /// </summary>
            [EnumMember(Value = "VSSX")]
            VSSX,
            
            /// <summary>
            /// Enum VSDM for "VSDM"
            /// </summary>
            [EnumMember(Value = "VSDM")]
            VSDM,
            
            /// <summary>
            /// Enum VSSM for "VSSM"
            /// </summary>
            [EnumMember(Value = "VSSM")]
            VSSM,
            
            /// <summary>
            /// Enum VSTM for "VSTM"
            /// </summary>
            [EnumMember(Value = "VSTM")]
            VSTM
        }

        /// <summary>
        /// Gets or sets SaveFormat
        /// </summary>
				
        public SaveFormatEnum? SaveFormat { get; set; }

        /// <summary>
        /// Gets or sets DefaultFont
        /// </summary>  
		[DataMember(Name="DefaultFont", EmitDefaultValue=false)]
        public string DefaultFont { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveOptionsModel {\n");
          sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
          sb.Append("  DefaultFont: ").Append(this.DefaultFont).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
