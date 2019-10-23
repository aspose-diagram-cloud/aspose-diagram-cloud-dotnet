// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSize.cs">
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
  public class PageSize 
  {                       
        /// <summary>
        /// Gets or Sets PaperSizeFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaperSizeFormatEnum
        {
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom,
            
            /// <summary>
            /// Enum A0 for "A0"
            /// </summary>
            [EnumMember(Value = "A0")]
            A0,
            
            /// <summary>
            /// Enum A1 for "A1"
            /// </summary>
            [EnumMember(Value = "A1")]
            A1,
            
            /// <summary>
            /// Enum A2 for "A2"
            /// </summary>
            [EnumMember(Value = "A2")]
            A2,
            
            /// <summary>
            /// Enum A3 for "A3"
            /// </summary>
            [EnumMember(Value = "A3")]
            A3,
            
            /// <summary>
            /// Enum A4 for "A4"
            /// </summary>
            [EnumMember(Value = "A4")]
            A4,
            
            /// <summary>
            /// Enum A5 for "A5"
            /// </summary>
            [EnumMember(Value = "A5")]
            A5,
            
            /// <summary>
            /// Enum A6 for "A6"
            /// </summary>
            [EnumMember(Value = "A6")]
            A6,
            
            /// <summary>
            /// Enum A7 for "A7"
            /// </summary>
            [EnumMember(Value = "A7")]
            A7,
            
            /// <summary>
            /// Enum B0 for "B0"
            /// </summary>
            [EnumMember(Value = "B0")]
            B0,
            
            /// <summary>
            /// Enum B1 for "B1"
            /// </summary>
            [EnumMember(Value = "B1")]
            B1,
            
            /// <summary>
            /// Enum B2 for "B2"
            /// </summary>
            [EnumMember(Value = "B2")]
            B2,
            
            /// <summary>
            /// Enum B3 for "B3"
            /// </summary>
            [EnumMember(Value = "B3")]
            B3,
            
            /// <summary>
            /// Enum B4 for "B4"
            /// </summary>
            [EnumMember(Value = "B4")]
            B4,
            
            /// <summary>
            /// Enum B5 for "B5"
            /// </summary>
            [EnumMember(Value = "B5")]
            B5,
            
            /// <summary>
            /// Enum B6 for "B6"
            /// </summary>
            [EnumMember(Value = "B6")]
            B6,
            
            /// <summary>
            /// Enum B7 for "B7"
            /// </summary>
            [EnumMember(Value = "B7")]
            B7,
            
            /// <summary>
            /// Enum C0 for "C0"
            /// </summary>
            [EnumMember(Value = "C0")]
            C0,
            
            /// <summary>
            /// Enum C1 for "C1"
            /// </summary>
            [EnumMember(Value = "C1")]
            C1,
            
            /// <summary>
            /// Enum C2 for "C2"
            /// </summary>
            [EnumMember(Value = "C2")]
            C2,
            
            /// <summary>
            /// Enum C3 for "C3"
            /// </summary>
            [EnumMember(Value = "C3")]
            C3,
            
            /// <summary>
            /// Enum C4 for "C4"
            /// </summary>
            [EnumMember(Value = "C4")]
            C4,
            
            /// <summary>
            /// Enum C5 for "C5"
            /// </summary>
            [EnumMember(Value = "C5")]
            C5,
            
            /// <summary>
            /// Enum C6 for "C6"
            /// </summary>
            [EnumMember(Value = "C6")]
            C6,
            
            /// <summary>
            /// Enum C7 for "C7"
            /// </summary>
            [EnumMember(Value = "C7")]
            C7,
            
            /// <summary>
            /// Enum Letter for "Letter"
            /// </summary>
            [EnumMember(Value = "Letter")]
            Letter,
            
            /// <summary>
            /// Enum Legal for "Legal"
            /// </summary>
            [EnumMember(Value = "Legal")]
            Legal,
            
            /// <summary>
            /// Enum Legal13 for "Legal13"
            /// </summary>
            [EnumMember(Value = "Legal13")]
            Legal13,
            
            /// <summary>
            /// Enum Tabloid for "Tabloid"
            /// </summary>
            [EnumMember(Value = "Tabloid")]
            Tabloid,
            
            /// <summary>
            /// Enum Executive for "Executive"
            /// </summary>
            [EnumMember(Value = "Executive")]
            Executive,
            
            /// <summary>
            /// Enum DL for "DL"
            /// </summary>
            [EnumMember(Value = "DL")]
            DL,
            
            /// <summary>
            /// Enum COM9 for "COM9"
            /// </summary>
            [EnumMember(Value = "COM9")]
            COM9,
            
            /// <summary>
            /// Enum COM10 for "COM10"
            /// </summary>
            [EnumMember(Value = "COM10")]
            COM10,
            
            /// <summary>
            /// Enum Monarch for "Monarch"
            /// </summary>
            [EnumMember(Value = "Monarch")]
            Monarch
        }

        /// <summary>
        /// Gets or sets PaperSizeFormat
        /// </summary>
				
        public PaperSizeFormatEnum? PaperSizeFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageSize {\n");
          sb.Append("  PaperSizeFormat: ").Append(this.PaperSizeFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
