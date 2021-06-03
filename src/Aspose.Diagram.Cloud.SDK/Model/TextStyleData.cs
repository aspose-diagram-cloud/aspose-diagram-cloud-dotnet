// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextStyleData.cs">
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
  /// Text style
  /// </summary>  
  [DataContract]
  public class TextStyleData 
  {                       
        /// <summary>
        /// Specifies the character formatting applied to a range of text in the shape&#39;s text block.             
        /// </summary>
        /// <value>Specifies the character formatting applied to a range of text in the shape&#39;s text block.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleEnum
        {
            
            /// <summary>
            /// Enum Bold for "Bold"
            /// </summary>
            [EnumMember(Value = "Bold")]
            Bold,
            
            /// <summary>
            /// Enum Italic for "Italic"
            /// </summary>
            [EnumMember(Value = "Italic")]
            Italic,
            
            /// <summary>
            /// Enum Underline for "Underline"
            /// </summary>
            [EnumMember(Value = "Underline")]
            Underline,
            
            /// <summary>
            /// Enum SmallCaps for "SmallCaps"
            /// </summary>
            [EnumMember(Value = "SmallCaps")]
            SmallCaps,
            
            /// <summary>
            /// Enum Undefined for "Undefined"
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined
        }

        /// <summary>
        /// Specifies the character formatting applied to a range of text in the shape&#39;s text block.             
        /// </summary>
				
        public StyleEnum? Style { get; set; }

        /// <summary>
        /// Specifies the color of the text in the shape's text block.             
        /// </summary>  
		[DataMember(Name="Color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// It specified the font name of the font used to format the text             
        /// </summary>  
		[DataMember(Name="FontName", EmitDefaultValue=false)]
        public string FontName { get; set; }

        /// <summary>
        /// Specifies the size of the text in the shape's text block.             
        /// </summary>  
		[DataMember(Name="FontSize", EmitDefaultValue=false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TextStyleData {\n");
          sb.Append("  Color: ").Append(this.Color).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("  FontName: ").Append(this.FontName).Append("\n");
          sb.Append("  FontSize: ").Append(this.FontSize).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
