// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageSaveOptions.cs">
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
  public class ImageSaveOptions : RenderingSaveOptions 
  {                       
        /// <summary>
        /// Gets or Sets TiffCompression
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TiffCompressionEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Rle for "Rle"
            /// </summary>
            [EnumMember(Value = "Rle")]
            Rle,
            
            /// <summary>
            /// Enum Ccitt3 for "Ccitt3"
            /// </summary>
            [EnumMember(Value = "Ccitt3")]
            Ccitt3,
            
            /// <summary>
            /// Enum Ccitt4 for "Ccitt4"
            /// </summary>
            [EnumMember(Value = "Ccitt4")]
            Ccitt4,
            
            /// <summary>
            /// Enum Lzw for "Lzw"
            /// </summary>
            [EnumMember(Value = "Lzw")]
            Lzw
        }

        /// <summary>
        /// Gets or Sets ImageColorMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageColorModeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Grayscale for "Grayscale"
            /// </summary>
            [EnumMember(Value = "Grayscale")]
            Grayscale,
            
            /// <summary>
            /// Enum BlackAndWhite for "BlackAndWhite"
            /// </summary>
            [EnumMember(Value = "BlackAndWhite")]
            BlackAndWhite
        }

        /// <summary>
        /// Gets or Sets PixelOffsetMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PixelOffsetModeEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum HighSpeed for "HighSpeed"
            /// </summary>
            [EnumMember(Value = "HighSpeed")]
            HighSpeed,
            
            /// <summary>
            /// Enum HighQuality for "HighQuality"
            /// </summary>
            [EnumMember(Value = "HighQuality")]
            HighQuality,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Half for "Half"
            /// </summary>
            [EnumMember(Value = "Half")]
            Half,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid
        }

        /// <summary>
        /// Gets or Sets SmoothingMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SmoothingModeEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum HighSpeed for "HighSpeed"
            /// </summary>
            [EnumMember(Value = "HighSpeed")]
            HighSpeed,
            
            /// <summary>
            /// Enum HighQuality for "HighQuality"
            /// </summary>
            [EnumMember(Value = "HighQuality")]
            HighQuality,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum AntiAlias for "AntiAlias"
            /// </summary>
            [EnumMember(Value = "AntiAlias")]
            AntiAlias,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid
        }

        /// <summary>
        /// Gets or Sets CompositingQuality
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompositingQualityEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum HighSpeed for "HighSpeed"
            /// </summary>
            [EnumMember(Value = "HighSpeed")]
            HighSpeed,
            
            /// <summary>
            /// Enum HighQuality for "HighQuality"
            /// </summary>
            [EnumMember(Value = "HighQuality")]
            HighQuality,
            
            /// <summary>
            /// Enum GammaCorrected for "GammaCorrected"
            /// </summary>
            [EnumMember(Value = "GammaCorrected")]
            GammaCorrected,
            
            /// <summary>
            /// Enum AssumeLinear for "AssumeLinear"
            /// </summary>
            [EnumMember(Value = "AssumeLinear")]
            AssumeLinear,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid
        }

        /// <summary>
        /// Gets or Sets InterpolationMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InterpolationModeEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>
            [EnumMember(Value = "Low")]
            Low,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>
            [EnumMember(Value = "High")]
            High,
            
            /// <summary>
            /// Enum Bilinear for "Bilinear"
            /// </summary>
            [EnumMember(Value = "Bilinear")]
            Bilinear,
            
            /// <summary>
            /// Enum Bicubic for "Bicubic"
            /// </summary>
            [EnumMember(Value = "Bicubic")]
            Bicubic,
            
            /// <summary>
            /// Enum NearestNeighbor for "NearestNeighbor"
            /// </summary>
            [EnumMember(Value = "NearestNeighbor")]
            NearestNeighbor,
            
            /// <summary>
            /// Enum HighQualityBilinear for "HighQualityBilinear"
            /// </summary>
            [EnumMember(Value = "HighQualityBilinear")]
            HighQualityBilinear,
            
            /// <summary>
            /// Enum HighQualityBicubic for "HighQualityBicubic"
            /// </summary>
            [EnumMember(Value = "HighQualityBicubic")]
            HighQualityBicubic,
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid
        }

        /// <summary>
        /// Gets or sets TiffCompression
        /// </summary>
				
        public TiffCompressionEnum? TiffCompression { get; set; }

        /// <summary>
        /// Gets or sets ImageColorMode
        /// </summary>
				
        public ImageColorModeEnum? ImageColorMode { get; set; }

        /// <summary>
        /// Gets or sets PixelOffsetMode
        /// </summary>
				
        public PixelOffsetModeEnum? PixelOffsetMode { get; set; }

        /// <summary>
        /// Gets or sets SmoothingMode
        /// </summary>
				
        public SmoothingModeEnum? SmoothingMode { get; set; }

        /// <summary>
        /// Gets or sets CompositingQuality
        /// </summary>
				
        public CompositingQualityEnum? CompositingQuality { get; set; }

        /// <summary>
        /// Gets or sets InterpolationMode
        /// </summary>
				
        public InterpolationModeEnum? InterpolationMode { get; set; }

        /// <summary>
        /// Gets or sets ImageBrightness
        /// </summary>  
		[DataMember(Name="ImageBrightness", EmitDefaultValue=false)]
        public double? ImageBrightness { get; set; }

        /// <summary>
        /// Gets or sets ImageContrast
        /// </summary>  
		[DataMember(Name="ImageContrast", EmitDefaultValue=false)]
        public double? ImageContrast { get; set; }

        /// <summary>
        /// Gets or sets JpegQuality
        /// </summary>  
		[DataMember(Name="JpegQuality", EmitDefaultValue=false)]
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or sets PageCount
        /// </summary>  
		[DataMember(Name="PageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets Resolution
        /// </summary>  
		[DataMember(Name="Resolution", EmitDefaultValue=false)]
        public double? Resolution { get; set; }

        /// <summary>
        /// Gets or sets Scale
        /// </summary>  
		[DataMember(Name="Scale", EmitDefaultValue=false)]
        public double? Scale { get; set; }

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
        /// Gets or sets SameAsPdfConversionArea
        /// </summary>  
		[DataMember(Name="SameAsPdfConversionArea", EmitDefaultValue=false)]
        public bool? SameAsPdfConversionArea { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImageSaveOptions {\n");
          sb.Append("  ImageBrightness: ").Append(this.ImageBrightness).Append("\n");
          sb.Append("  ImageContrast: ").Append(this.ImageContrast).Append("\n");
          sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
          sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
          sb.Append("  Resolution: ").Append(this.Resolution).Append("\n");
          sb.Append("  Scale: ").Append(this.Scale).Append("\n");
          sb.Append("  TiffCompression: ").Append(this.TiffCompression).Append("\n");
          sb.Append("  ExportHiddenPage: ").Append(this.ExportHiddenPage).Append("\n");
          sb.Append("  ImageColorMode: ").Append(this.ImageColorMode).Append("\n");
          sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
          sb.Append("  SaveForegroundPagesOnly: ").Append(this.SaveForegroundPagesOnly).Append("\n");
          sb.Append("  SameAsPdfConversionArea: ").Append(this.SameAsPdfConversionArea).Append("\n");
          sb.Append("  PixelOffsetMode: ").Append(this.PixelOffsetMode).Append("\n");
          sb.Append("  SmoothingMode: ").Append(this.SmoothingMode).Append("\n");
          sb.Append("  CompositingQuality: ").Append(this.CompositingQuality).Append("\n");
          sb.Append("  InterpolationMode: ").Append(this.InterpolationMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
