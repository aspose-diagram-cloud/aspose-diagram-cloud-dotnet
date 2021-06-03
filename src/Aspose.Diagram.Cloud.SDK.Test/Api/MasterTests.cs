using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Model;
using NUnit.Framework;
using System.IO;

namespace Aspose.Diagram.Cloud.SDK.Test
{
    [TestFixture]
    public class MasterTests : TestBase
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
        public void GetMasters()
        {
            var response = diagramApi.GetMasters(fileName, StorageTestFOLDER);
            Assert.IsTrue(response.Count>0);
        }

        [Test]
        public void AddMaster()
        {
            var response = diagramApi.AddMaster(fileName,GetFileStream("BasicShapes.vssx"), StorageTestFOLDER);
            Assert.IsTrue(response.AddedMasters.Count>0);
        }

        [Test]
        public void AddExistMaster()
        {
            var response = diagramApi.AddExistMaster(fileName, @"/BasicShapes.vssx", StorageTestFOLDER);
            Assert.IsTrue(response.AddedMasters.Count > 0);
        }
    }
}
