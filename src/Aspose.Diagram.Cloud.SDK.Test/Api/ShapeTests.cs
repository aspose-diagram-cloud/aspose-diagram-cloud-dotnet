using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Aspose.Diagram.Cloud.SDK.Test
{
    [TestFixture]
    public class ShapeTests : TestBase
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
        public void AddShape()
        {
            var masters=diagramApi.AddMaster(fileName, GetFileStream("BasicShapes.vssx"), StorageTestFOLDER);
            Assert.IsTrue(masters.AddedMasters.Count > 0);
            List<DrawShapeModel> list = new List<DrawShapeModel>();
            DrawShapeModel item = new DrawShapeModel();
            item.MasterName = masters.AddedMasters[0].Name;
            item.PinX = 3;
            item.PinY = 3;
            item.Width = 1;
            item.Height = 1;
            item.Text = "draw test";
            var shapeStyleData = new ShapeStyleData();
            shapeStyleData.FillBackGroundColor = "#FF0000";
            var textStyleData = new TextStyleData();
            textStyleData.FontSize = 0.25;
            textStyleData.FontName = "Times New Roman";
            item.ShapeStyleData = shapeStyleData;
            item.TextStyleData = textStyleData;
            list.Add(item);
            var response = diagramApi.AddShapes(fileName, "newPage", list, StorageTestFOLDER);
            Assert.IsTrue(response.IsSuccess);
        }

        [Test]
        public void GetShapes()
        {
            var response = diagramApi.GetShapes(fileName, "newPage", StorageTestFOLDER);
            Assert.IsTrue(response.Count>0);
        }

        [Test]
        public void UpdateShape()
        {
            ShapeData shape = new ShapeData();
            shape.ID = 5;
            shape.Text = "Update Success";
            var response = diagramApi.UpdateShape(fileName, "newPage", shape, StorageTestFOLDER);
            Assert.IsTrue(response.IsSuccess);
        }

        [Test]
        public void DeleteShape()
        {
            var response = diagramApi.DeleteShapes(fileName, "newPage", 3, StorageTestFOLDER);
            Assert.IsTrue(response.IsSuccess);
        }
    }
}
