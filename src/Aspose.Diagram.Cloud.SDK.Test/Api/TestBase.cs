using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Diagram.Cloud.SDK.Test
{
    public abstract class TestBase
    {
        protected StorageApi storageApi;
        protected DiagramApi diagramApi;

        protected string grantType = "client_credentials";
        protected string clientId = "yourClientId";
        protected string clientSecret = "yourClientSecret";

        protected string LocalTestFolder = @"D:\TestFiles\";
        protected string StorageTestFOLDER = @"SDKTests\CSharp";
        protected string LocalTestSourceFile = "Source.vsd";

        public TestBase()
        {
            storageApi = new StorageApi(grantType, clientId, clientSecret);
            diagramApi = new DiagramApi(grantType, clientId, clientSecret);
        }

        protected MemoryStream GetTestDataStream(string filename)
        {
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

        protected FileStream GetFileStream(string filename)
        {
            var filePath = Path.Combine(LocalTestFolder, filename);
            try
            {
                var file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                return file;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
