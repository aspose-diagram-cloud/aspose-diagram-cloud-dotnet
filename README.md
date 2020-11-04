![](https://img.shields.io/badge/api-v3.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.Diagram-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-diagram-cloud/aspose-Diagram-cloud-dotnet)](https://github.com/aspose-diagram-cloud/aspose-Diagram-cloud-dotnet/blob/master/LICENSE) 

# Node.js SDK for Visio® Files

[Aspose.Diagram Cloud SDK for .NET](https://products.aspose.cloud/diagram/net) helps you develop Visio file manipulation applications with the help of Aspose.Diagram REST API. It allows your applications to work with Microsoft Visio Object Model in order to create the diragrams from scratch or convert diagrams to popular formats including PDF, HTML, images and other Visio formats.

## Process Diagrams in the Cloud

- Programmatically create new Microsoft Visio diagrams via API.
- Convert Visio flow-charts to other supported formats.
- Retrieve document information of a Visio file.
- Export Visio files to raster images, fixed-layout and HTML formats.
- Upload your business oriented Visio diagrams to cloud storage.

Please refer to [Developer's Guide](https://docs.aspose.cloud/diagram/developer-guide/) to see what else you can achieve.

## New Features in Version 20.3

Added support to draw following objects on a page:
- Polyline
- Line
- Ellipse

Added support to:
- Set page setting  
- Add new empty page
- Get pages info

For the detailed notes, please visit [Aspose.Diagram Cloud 20.3 Release Notes](https://docs.aspose.cloud/diagram/aspose-diagram-cloud-20-3-release-notes/).

## Read & Write Visio Formats

**Microsoft Visio:** VSDX, VSX, VTX, VDX, VSSX, VSTX, VSDM, VSSM, VSTM

## Save Visio As

**Fixed Layout:** PDF, XPS
**Images:** JPEG, PNG, BMP, TIFF, SVG, EMF
**Web:** HTML
**Other:** XAML, SWF

## Read Visio Formats

**Microsoft Visio:** VDW, VSD, VSS, VST

## Getting Started with Aspose.Diagram Cloud SDK for .NET

You do not need to install anything to get started with Aspose.Diagram Cloud SDK for .NET. All you need to do is create an account at [Aspose for Cloud](https://dashboard.aspose.cloud/#/apps) and get your application information.

Simply execute `Install-Package Aspose.Diagram-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.Diagram assembly in your project. If you already have Aspose.Diagram Cloud SDK for .NET and want to upgrade it, please execute `Update-Package Aspose.Diagram-Cloud` to get the latest version.

Please check the [GitHub Repository](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-dotnet) for other common usage scenarios.

## Create a New VDX Format Diagram in the Cloud

```csharp
DiagramFileApi instance = new DiagramFileApi(GetConfiguration());

string name = "New_Diagram.vdx";
bool isOverwrite = true;
string folder = null;

var response = instance.DiagramFilePutCreate(name, folder, isOverwrite);
```
## Aspose.Diagram Cloud SDKs in Popular Languages

| .NET | Java | PHP | Python | Ruby | Node.js | Android | Perl | Swift |
|---|---|---|---|---|---|---|---|---|
| [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-dotnet) | [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-java) | [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-php) | [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-python) | [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-ruby)  | [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-node) | [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-android) | [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-perl) | [GitHub](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-swift) |
| [NuGet](https://www.nuget.org/packages/Aspose.Diagram-Cloud/) | [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-diagram-cloud) | [Composer](https://packagist.org/packages/aspose/diagram-sdk-php) | [PIP](https://pypi.org/project/asposediagramcloud/) | [GEM](https://rubygems.org/gems/aspose_diagram_cloud)  | [NPM](https://www.npmjs.com/package/asposediagramcloud) | [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-diagram-cloud-android) |  [CPAN](https://metacpan.org/release/AsposeDiagramCloud-DiagramApi) | [POD](https://cocoapods.org/pods/AsposeDiagramCloud) |

[Home](https://www.aspose.cloud) | [Product Page](https://products.aspose.cloud/diagram/net) | [Documentation](https://docs.aspose.cloud/diagram/) | [Live Demo](https://products.aspose.app/diagram/family) | [API Reference](https://apireference.aspose.cloud/diagram/) | [Code Samples](https://github.com/aspose-diagram-cloud/aspose-diagram-cloud-dotnet) | [Blog](https://blog.aspose.cloud/category/diagram/) | [Free Support](https://forum.aspose.cloud/c/diagram) | [Free Trial](https://dashboard.aspose.cloud/)

