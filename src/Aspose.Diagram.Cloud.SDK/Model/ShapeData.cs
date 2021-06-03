// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeData.cs">
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
  /// Shape element.             
  /// </summary>  
  [DataContract]
  public class ShapeData 
  {                       
        /// <summary>
        /// The unique ID of the element within its parent element.             
        /// </summary>  
		[DataMember(Name="ID", EmitDefaultValue=false)]
        public long? ID { get; set; }

        /// <summary>
        /// The name of the element.             
        /// </summary>  
		[DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the x-coordinate of the shape's pin (center of rotation) in relation to the origin of its parent.             
        /// </summary>  
		[DataMember(Name="PinX", EmitDefaultValue=false)]
        public double? PinX { get; set; }

        /// <summary>
        /// Specifies the y-coordinate of the shape's pin (center of rotation) in relation to the origin of its parent.             
        /// </summary>  
		[DataMember(Name="PinY", EmitDefaultValue=false)]
        public double? PinY { get; set; }

        /// <summary>
        /// Contains the width of the associated shape in drawing units.             
        /// </summary>  
		[DataMember(Name="Width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// Specifies the height of the shape in drawing units.             
        /// </summary>  
		[DataMember(Name="Height", EmitDefaultValue=false)]
        public double? Height { get; set; }

        /// <summary>
        /// Represents the shape's current angle of rotation in relation to its parent(deg,180~-180).             
        /// </summary>  
		[DataMember(Name="Angle", EmitDefaultValue=false)]
        public double? Angle { get; set; }

        /// <summary>
        /// Contains the text of a shape.             
        /// </summary>  
		[DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Style of shape element
        /// </summary>  
		[DataMember(Name="ShapeStyleData", EmitDefaultValue=false)]
        public ShapeStyleData ShapeStyleData { get; set; }

        /// <summary>
        /// The style of the text in the shape
        /// </summary>  
		[DataMember(Name="TextStyleData", EmitDefaultValue=false)]
        public TextStyleData TextStyleData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ShapeData {\n");
          sb.Append("  ID: ").Append(this.ID).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  PinX: ").Append(this.PinX).Append("\n");
          sb.Append("  PinY: ").Append(this.PinY).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Angle: ").Append(this.Angle).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  ShapeStyleData: ").Append(this.ShapeStyleData).Append("\n");
          sb.Append("  TextStyleData: ").Append(this.TextStyleData).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
