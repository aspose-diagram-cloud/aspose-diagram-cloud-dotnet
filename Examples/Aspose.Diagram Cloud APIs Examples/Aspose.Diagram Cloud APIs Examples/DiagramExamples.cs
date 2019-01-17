using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;
using Aspose.Storage.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Diagram_Cloud_APIs_Examples
{
    class DiagramExamples
    {
        protected ApiClient client;
        protected Configuration config;
        protected static OAuthApi oauth2 = null;
        protected string grantType = "client_credentials";
        protected string clientId = ""; // Get App Key and App SID from https://dashboard.aspose.cloud/
        protected string clientSecret = ""; // Get App Key and App SID from https://dashboard.aspose.cloud/
        protected static string accesstoken;
        protected string refreshtoken;

        static void Main(string[] args)
        {
            DiagramExamples diagramExamples = new DiagramExamples();
            // Get Diagram Document Information
            diagramExamples.GetDiagram();
            // Convert Diagram File to Another Format
            diagramExamples.PostSaveAsTest();
            // Create Diagram File
            diagramExamples.PutCreateTest();
            // Upload Diagram File
            diagramExamples.PutUploadTest();
        }

        // Get Diagram Document Information
        private void GetDiagram()
        {
            DiagramFileApi instance = new DiagramFileApi(GetConfiguration());

            string name = "file_get_1.vdx";
            string folder = null;
            UpdateDataFile(name);
            var response = instance.DiagramFileGetDiagram(name, "pdf", folder);
            int i = 5;
        }

        // Convert Diagram File to Another Format
        private void PostSaveAsTest()
        {
            DiagramFileApi instance = new DiagramFileApi(GetConfiguration());

            string name = "file_get_1.vdx";
            bool isOverwrite = true;
            string folder = null;

            FileFormatRequest format = new FileFormatRequest() { Format = "pdf" };
            string newfilename = "file_saveas_1.pdf";

            UpdateDataFile(name);
            var response = instance.DiagramFilePostSaveAs(name, format, newfilename, folder, isOverwrite);
        }

        // Create Diagram File
        private void PutCreateTest()
        {
            DiagramFileApi instance = new DiagramFileApi(GetConfiguration());

            string name = "file_get_1.vdx";
            bool isOverwrite = true;
            string folder = null;

            var response = instance.DiagramFilePutCreate(name, folder, isOverwrite);
        }

        // Upload Diagram File
        private void PutUploadTest()
        {
            DiagramFileApi instance = new DiagramFileApi(GetConfiguration());

            string name = "123.vsd";
            bool isOverwrite = true;
            string folder = null;

            string localFilePath = @"c:\Data\123.vsd";
            var response = instance.DiagramFilePutUpload(localFilePath, name, folder, isOverwrite);
        }

        protected void UpdateDataFile(string filename)
        {
            StorageApi StorageApi = new StorageApi(clientSecret, clientId);

            // Upload document to Cloud Storage
            PutCreateRequest request = new PutCreateRequest(filename, File.OpenRead(@"c:\Data\" + filename), null, null);
            StorageApi.PutCreate(request);
        }

        protected Configuration GetConfiguration()
        {
            if (oauth2 == null)
            {
                oauth2 = new OAuthApi("https://api.aspose.cloud");
                var oauth2response = oauth2.OAuthPost(grantType, clientId, clientSecret);
                accesstoken = oauth2response.AccessToken;
                refreshtoken = oauth2response.RefreshToken;
            }
            Dictionary<string, string> headerParameters = new Dictionary<string, string>();
            headerParameters.Add("Authorization", "Bearer " + accesstoken);
            client = new ApiClient();
            config = new Configuration(client, headerParameters);
            return config;
        }
    }
}
