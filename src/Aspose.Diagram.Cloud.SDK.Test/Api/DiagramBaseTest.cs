
namespace Aspose.Diagram.Cloud.SDK.Test
{
    using NUnit.Framework;

    using Aspose.Diagram.Cloud.SDK.Client;
    using Aspose.Diagram.Cloud.SDK.Api;
    using Aspose.Diagram.Cloud.SDK.Model;
    using Com.Aspose.Storage.Api;
    using System.IO;
    using System.Collections.Generic;
    public class DiagramBaseTest
    {
        protected ApiClient client;
        protected Configuration config;
        protected static OAuthApi oauth2 = null;
        protected string grantType = "client_credentials";
        protected string clientId = "xxxxxxxx";
        protected string clientSecret = "xxxxxx";
        protected static string accesstoken;
        protected string refreshtoken;
        protected StorageApi storageApi;

        private string TestDataFolder = @"D:xxxxx\testdata\Diagram\upload\";
        protected string TEMPFOLDER = "Temp";
        protected string File_TEST_GET = "file_get_1.vdx";


        protected void UpdateDataFile(string folder, string filename)
        {
            this.storageApi = new StorageApi(clientSecret, clientId, "https://api.aspose.cloud/v1.1");
            if (string.IsNullOrEmpty(folder))
            {
                this.storageApi.DeleteFile(filename, null, null);
                this.storageApi.PutCreate(filename, null, null, File.ReadAllBytes(TestDataFolder + filename));

            }
            else
            {
                this.storageApi.DeleteFile(folder + "/" + filename, null, null);
                this.storageApi.PutCreate(folder + "/" + filename, null, null, File.ReadAllBytes(TestDataFolder + filename));

            }
        }
        protected void UpdateDataFileForDropBox(string folder, string filename)
        {
            this.storageApi = new StorageApi(clientSecret, clientId, "https://api.aspose.cloud/v1.1");
            if (string.IsNullOrEmpty(folder))
            {
                this.storageApi.DeleteFile(filename, null, "DropBox");
                this.storageApi.PutCreate(filename, null, "DropBox", File.ReadAllBytes(TestDataFolder + filename));

            }
            else
            {
                this.storageApi.DeleteFile(folder + "/" + filename, null, "DropBox");
                this.storageApi.PutCreate(folder + "/" + filename, null, "DropBox", File.ReadAllBytes(TestDataFolder + filename));

            }
        }
        protected Stream GetTestDataStream(string filename)
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter writer = new StreamWriter(ms);
            writer.Write(System.Text.Encoding.Default.GetString(File.ReadAllBytes(TestDataFolder + filename)));
            writer.Flush();
            ms.Position = 0;
            return ms;
        }
        protected byte[] GetTestDataByteArray(string filename)
        {
            return File.ReadAllBytes(TestDataFolder + filename);
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
