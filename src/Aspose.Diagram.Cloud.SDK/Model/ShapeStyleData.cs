// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeStyleData.cs">
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
  /// Shape style setting
  /// </summary>  
  [DataContract]
  public class ShapeStyleData 
  {                       
        /// <summary>
        /// Specifies the color used for the background of the shape's fill pattern.like '#000000'             
        /// </summary>  
		[DataMember(Name="FillBackGroundColor", EmitDefaultValue=false)]
        public string FillBackGroundColor { get; set; }

        /// <summary>
        /// Specifies the fill pattern for the shape.             
        /// </summary>  
		[DataMember(Name="FillPattern", EmitDefaultValue=false)]
        public int? FillPattern { get; set; }

        /// <summary>
        /// Specifies the line color of the shape.
        /// </summary>  
		[DataMember(Name="LineColor", EmitDefaultValue=false)]
        public string LineColor { get; set; }

        /// <summary>
        /// Specifies the line weight of a shape. Line weight is independent of the scale of the drawing. If the drawing is scaled, the line weight remains the same.             
        /// </summary>  
		[DataMember(Name="LineWeight", EmitDefaultValue=false)]
        public double? LineWeight { get; set; }

        /// <summary>
        /// Specifies the line pattern of the shape
        /// </summary>  
		[DataMember(Name="LinePattern", EmitDefaultValue=false)]
        public int? LinePattern { get; set; }

        /// <summary>
        /// Specifies the radius of the rounding arc applied where two contiguous segments of a path meet. For example, rounding can be used to give a rectangle rounded corners.
        /// </summary>  
		[DataMember(Name="Rounding", EmitDefaultValue=false)]
        public double? Rounding { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ShapeStyleData {\n");
          sb.Append("  FillBackGroundColor: ").Append(this.FillBackGroundColor).Append("\n");
          sb.Append("  FillPattern: ").Append(this.FillPattern).Append("\n");
          sb.Append("  LineColor: ").Append(this.LineColor).Append("\n");
          sb.Append("  LineWeight: ").Append(this.LineWeight).Append("\n");
          sb.Append("  LinePattern: ").Append(this.LinePattern).Append("\n");
          sb.Append("  Rounding: ").Append(this.Rounding).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
