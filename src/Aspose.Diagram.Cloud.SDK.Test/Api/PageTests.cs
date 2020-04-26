using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Model;
using NUnit.Framework;
using System.IO;

namespace Aspose.Diagram.Cloud.SDK.Test
{
    [TestFixture]
    public class PageTests : TestBase
    {

        private readonly static string fileName = "pageTest.vsdx";

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            CreateEmptyDocument();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        public void CreateEmptyDocument() {
            string name = fileName;
            string folder = StorageTestFOLDER;
            var response = diagramApi.CreateNew(name, folder, true);
        }

        /// <summary>
        /// Test an instance of DiagramFileApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf(typeof(DiagramApi), diagramApi, "instance is a DiagramFileApi");
        }

        [Test]
        public void PutNewPage()
        {
            var response = diagramApi.PutNewPage(fileName, "newPage", StorageTestFOLDER);
            Assert.IsTrue(response.IsSuccess);
        }

        [Test]
        public void GetPages()
        {
            var response = diagramApi.GetPages(fileName, StorageTestFOLDER);
            Assert.IsTrue(response.Model.Count>0);
        }

        [Test]
        public void PostPageSetup()
        {
            var request = new PageSetting();
            request.PageHeight = 2;
            request.PageWidth = 2;
            var response = diagramApi.PostPageSetup(fileName, "Page-0", request, StorageTestFOLDER);
            Assert.IsTrue(response.IsSuccess);
        }
    }
}
