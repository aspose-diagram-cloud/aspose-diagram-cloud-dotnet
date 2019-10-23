// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsResponse.cs">
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
  public class SaveAsResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets SourceFile
        /// </summary>  
		[DataMember(Name="SourceFile", EmitDefaultValue=false)]
        public string SourceFile { get; set; }

        /// <summary>
        /// Gets or sets SavedFile
        /// </summary>  
		[DataMember(Name="SavedFile", EmitDefaultValue=false)]
        public string SavedFile { get; set; }

        /// <summary>
        /// List of Additionals file names
        /// </summary>  
        [DataMember(Name = "Additionals", EmitDefaultValue = false)]
        public List<string> Additionals { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveAsResponse {\n");
          sb.Append("  SourceFile: ").Append(this.SourceFile).Append("\n");
          sb.Append("  SavedFile: ").Append(this.SavedFile).Append("\n");
          sb.Append("  Additionals: ").Append(this.Additionals).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
