// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PointF.cs">
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
  public class PointF 
  {                       
        /// <summary>
        /// Gets or sets IsEmpty
        /// </summary>  
		[DataMember(Name="IsEmpty", EmitDefaultValue=false)]
        public bool? IsEmpty { get; set; }

        public PointF(double x, double y) {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets X
        /// </summary>  
		[DataMember(Name="X", EmitDefaultValue=false)]
        public double? X { get; set; }

        /// <summary>
        /// Gets or sets Y
        /// </summary>  
		[DataMember(Name="Y", EmitDefaultValue=false)]
        public double? Y { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PointF {\n");
          sb.Append("  IsEmpty: ").Append(this.IsEmpty).Append("\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
