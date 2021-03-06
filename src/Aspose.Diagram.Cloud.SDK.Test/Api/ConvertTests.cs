/* 
 * Aspose.Diagram Cloud API Reference
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Model;
using NUnit.Framework;
using System.IO;

namespace Aspose.Diagram.Cloud.SDK.Test
{
    /// <summary>
    ///  Class for testing DiagramApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConvertTests : TestBase
    {

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            UploadFileTest(); 
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DiagramFileApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf(typeof(DiagramApi), diagramApi, "instance is a DiagramFileApi");
        }


        /// <summary>
        /// Test FileDownloadWithFormat
        /// </summary>
        [Test]
        public void DownloadWithFormat()
        {
            string name = "FileUpload.vdx";
            string folder = StorageTestFOLDER;
            var response = diagramApi.DownloadFileWithFormat(name, "pdf", folder);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
            Assert.IsTrue(response.Length>0);
        }

        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAs()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName= "FileSaveAs.pdf";
            request.Folder = StorageTestFOLDER;
            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }

        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsPDF()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.pdf";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new PdfSaveOptions()
            {
                IsExportComments=true,
                JpegQuality=100,
            };
            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }

        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsPNG()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.png";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new ImageSaveOptions()
            {
                IsExportComments = true,
                JpegQuality = 100,
            };
            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }

        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsBMP()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.bmp";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new ImageSaveOptions()
            {
                IsExportComments = true,
                JpegQuality = 100,
            };
            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }


        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsVSSX()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.vssx";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new DiagramSaveOptions()
            {
            };
              
            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }

        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsVSTM()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.vstm";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new DiagramSaveOptions()
            {
            };

            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }


        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsSVG()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.svg";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new SVGSaveOptions()
            {
                Quality = 100
            };

            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }

        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsSWF()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.swf";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new SWFSaveOptions()
            {
                SaveForegroundPagesOnly = true
            };

            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }

        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsHTML()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.html";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new HTMLSaveOptions()
            {
                Title="Save HTML Test",
            };

            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
            Assert.IsTrue(response.Additionals.Count > 0);
        }

        /// <summary>
        /// Test FileSaveAs
        /// </summary>
        [Test]
        public void SaveAsXPS()
        {
            string name = "FileUpload.vdx";
            SaveOptionsRequest request = new SaveOptionsRequest();
            request.FileName = "FileSaveAs.xps";
            request.Folder = StorageTestFOLDER;
            request.SaveOptions = new XPSSaveOptions()
            {
                SaveForegroundPagesOnly=true
            };

            var response = diagramApi.SaveAs(name, request, StorageTestFOLDER, true);

            Assert.IsInstanceOf<SaveAsResponse>(response, "response is SaveResponse");
            Assert.IsNotEmpty(response.SavedFile);
        }

        /// <summary>
        /// Test DiagramFilePutCreate
        /// </summary>
        [Test]
        public void CreateTest()
        {
            string name = "FileCreate.vdx";
            string folder = StorageTestFOLDER;
            var response = diagramApi.CreateNew(name, folder, true);

            Assert.IsInstanceOf<CreateNewResponse>(response, "response is CreateNewResponse");
            Assert.IsNotEmpty(response.Created);
        }

        /// <summary>
        /// Test DiagramFilePutCreate
        /// </summary>
        [Test]
        public void ConvertTest()
        {
            string name = "Convert.pdf";
            string folder = StorageTestFOLDER;
            var file = GetFileStream(LocalTestSourceFile);
            var response = diagramApi.ConvertDocument(name, file);
            Assert.IsInstanceOf<Stream>(response, "response is System.IO.Stream");
            Assert.IsTrue(response.Length>0);
        }


        public void UploadFileTest()
        {
            string name = "FileUpload.vdx";
            string folder = StorageTestFOLDER;
            Stream stream = GetTestDataStream(name);
            var response = storageApi.UploadFile(StorageTestFOLDER + "\\" + name, stream);
            Assert.IsInstanceOf<FilesUploadResult>(response, "Upload file.");
        }

    }

}
