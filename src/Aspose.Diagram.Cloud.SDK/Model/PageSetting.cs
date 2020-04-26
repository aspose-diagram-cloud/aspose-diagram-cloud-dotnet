// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageSetting.cs">
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
  /// page setting info
  /// </summary>  
  [DataContract]
  public class PageSetting 
  {                       
        /// <summary>
        /// Page Name
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Page Name
        /// </summary>  
		[DataMember(Name="NameU", EmitDefaultValue=false)]
        public string NameU { get; set; }

        /// <summary>
        /// Page Width
        /// </summary>  
		[DataMember(Name="PageWidth", EmitDefaultValue=false)]
        public double? PageWidth { get; set; }

        /// <summary>
        /// Page Height
        /// </summary>  
		[DataMember(Name="PageHeight", EmitDefaultValue=false)]
        public double? PageHeight { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageSetting {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  NameU: ").Append(this.NameU).Append("\n");
          sb.Append("  PageWidth: ").Append(this.PageWidth).Append("\n");
          sb.Append("  PageHeight: ").Append(this.PageHeight).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
