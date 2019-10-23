// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfDigitalSignatureDetails.cs">
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
  public class PdfDigitalSignatureDetails 
  {                       
        /// <summary>
        /// Gets or Sets HashAlgorithm
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HashAlgorithmEnum
        {
            
            /// <summary>
            /// Enum Sha1 for "Sha1"
            /// </summary>
            [EnumMember(Value = "Sha1")]
            Sha1,
            
            /// <summary>
            /// Enum Sha256 for "Sha256"
            /// </summary>
            [EnumMember(Value = "Sha256")]
            Sha256,
            
            /// <summary>
            /// Enum Sha384 for "Sha384"
            /// </summary>
            [EnumMember(Value = "Sha384")]
            Sha384,
            
            /// <summary>
            /// Enum Sha512 for "Sha512"
            /// </summary>
            [EnumMember(Value = "Sha512")]
            Sha512,
            
            /// <summary>
            /// Enum Md5 for "Md5"
            /// </summary>
            [EnumMember(Value = "Md5")]
            Md5
        }

        /// <summary>
        /// Gets or sets HashAlgorithm
        /// </summary>
				
        public HashAlgorithmEnum? HashAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets SignatureDate
        /// </summary>  
		[DataMember(Name="SignatureDate", EmitDefaultValue=false)]
        public DateTime? SignatureDate { get; set; }

        /// <summary>
        /// Gets or sets Reason
        /// </summary>  
		[DataMember(Name="Reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets Location
        /// </summary>  
		[DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfDigitalSignatureDetails {\n");
          sb.Append("  SignatureDate: ").Append(this.SignatureDate).Append("\n");
          sb.Append("  Reason: ").Append(this.Reason).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  HashAlgorithm: ").Append(this.HashAlgorithm).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
