using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.Diagram.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Aspose.Diagram.Cloud.SDK.Model;
using Aspose.Diagram.Cloud.SDK.Api;
using System;

namespace Aspose.Diagram.Cloud.Live.Demos.UI.Models
{
    ///<Summary>
    /// Aspose.Diagram Cloud API convert method to convert word document file to other format
    ///</Summary>

    public class AsposeDiagramConversion : AsposeDiagramCloudBase
    {
        protected MemoryStream GetTestDataStream(string filename, string folderName)
        {
            string LocalTestFolder = Config.Configuration.WorkingDirectory + folderName;

            var filePath = Path.Combine(LocalTestFolder, filename);
            try
            {
                var file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                var stream = new MemoryStream();
                file.CopyTo(stream);
                stream.Seek(0, SeekOrigin.Begin);
                return stream;
            }
            catch (Exception)
            {
                return null;
            }
        }

        ///<Summary>
        /// Convert method to convert file to other format
        ///</Summary>
        public Response Convert(string fileName, string folderName, string outputType)
        {
            outputType = outputType.ToLower();

            string grantType = "client_credentials";
            string appSID = Config.Configuration.AppSID;
            string appKey = Config.Configuration.AppKey;

            Aspose.Diagram.Cloud.SDK.Api.DiagramApi diagramApi = new DiagramApi(grantType, appSID, appKey);

            string outputFileName = Path.GetFileNameWithoutExtension(fileName) + "." + outputType;

            string name = fileName;
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = outputFileName;
            request.Folder = "";
            var response = diagramApi.SaveAs(name, request, "", true);

            bool foundSaveOption = true;

            if (outputType == "pdf"|| 
                outputType == "png" ||
                outputType == "bmp" ||
                outputType == "vssx" ||
                outputType == "vstm" || 
                outputType == "svg" ||
                outputType == "html" ||
                outputType == "xps" )
            {
            }
            else
            {
                foundSaveOption = false;
            }

            if (foundSaveOption)
            {
                return new Response
                {
                    FileName = outputFileName,
                    Status = "OK",
                    StatusCode = 200,
                };
            }

            return new Response
            {
                FileName = null,
                Status = "Output type not found",
                StatusCode = 500
            };

        }

    }
}
