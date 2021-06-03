using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Aspose.Diagram.Cloud.SDK.Test
{
    [TestFixture]
    public class DrawingTests : TestBase
    {

        private readonly static string fileName = "drawingTest.vsdx";
        private readonly static string pageName = "Page-0";
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
        public void DrawLine()
        {
            var request = new LineData();
            request.PinX = 1;
            request.PinY = 2;
            request.Width = 1;
            request.Height = 1;
            request.Points = new List<PointF>{ new PointF(0, 0), new PointF(0, 1) };
            request.Text = "test draw line";
            var shapeStyleData = new ShapeStyleData();
            shapeStyleData.FillBackGroundColor = "#FF0000";
            var textStyleData = new TextStyleData();
            textStyleData.FontSize = 0.25;
            textStyleData.FontName = "Times New Roman";
            request.ShapeStyleData = shapeStyleData;
            request.TextStyleData = textStyleData;

            var response = diagramApi.PutDrawLine(fileName, pageName, request, StorageTestFOLDER);

            Assert.IsTrue(response.IsSuccess);
        }

        [Test]
        public void DrawEllipse()
        {
            var request = new EllipseData();
            request.PinX = 5;
            request.PinY = 5;
            request.Width = 1;
            request.Height = 1;
            request.Text = "test draw ellipse";
            var shapeStyleData = new ShapeStyleData();
            shapeStyleData.FillBackGroundColor = "#FF0000";
            var textStyleData = new TextStyleData();
            textStyleData.FontSize = 0.25;
            textStyleData.FontName = "Times New Roman";
            request.ShapeStyleData = shapeStyleData;
            request.TextStyleData = textStyleData;

            var response = diagramApi.PutDrawEllipse(fileName, pageName, request, StorageTestFOLDER);

            Assert.IsTrue(response.IsSuccess);
        }



        [Test]
        public void DrawPolyline()
        {
            var request = new PolylineData();
            request.PinX = 3;
            request.PinY = 3;
            request.Width = 1;
            request.Height = 1;
            request.Points = new List<PointF>{ new PointF(0, 0), new PointF(0, 1), new PointF(1, 1), new PointF(1, 0) };
            request.Text = "test draw polyline";
            var shapeStyleData = new ShapeStyleData();
            shapeStyleData.FillBackGroundColor = "#FF0000";
            var textStyleData = new TextStyleData();
            textStyleData.FontSize = 0.25;
            textStyleData.FontName = "Times New Roman";
            request.ShapeStyleData = shapeStyleData;
            request.TextStyleData = textStyleData;

            var response = diagramApi.PutDrawPolyline(fileName, pageName, request, StorageTestFOLDER);

            Assert.IsTrue(response.IsSuccess);
        }
    }
}
