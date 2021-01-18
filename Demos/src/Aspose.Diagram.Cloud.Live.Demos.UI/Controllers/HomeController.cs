using Aspose.Diagram.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Diagram.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Convert Visio Online App - Free Online Visio Converter";
			ViewBag.MetaDescription = "Convert VSDX to PDF,Free Online Convert Microsoft Visio VSD, VSDX, VSX, VTX, VDX, VSSX, VSTX, VSDM, VSSM &amp; VSTM files to PDF, HTML, JPG, PNG, SVG, BMP, TIFF, XPS, GIF, EMF, VSDX and more.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
