using System;
using System.Data;
using System.Configuration;
using System.Web;

/// <summary>
/// Summary description for Configuration
/// </summary>
namespace Aspose.Diagram.Cloud.Live.Demos.UI.Config
{
	public static class Configuration
	{

		private static string _asposeDiagramCloudLiveDemosPath = ConfigurationManager.AppSettings["AsposeDiagramCloudLiveDemosPath"].ToString();
		private static string _resourceFileSessionName = ConfigurationManager.AppSettings["ResourceFileSessionName"];
		//private static string _fileViewLink = ConfigurationManager.AppSettings["FileViewLink"];
		private static string _asposeDiagramCloudAppsAssetURL = ConfigurationManager.AppSettings["AsposeDiagramCloudAppsAssetURL"];
		private static string _appKey = ConfigurationManager.AppSettings["AppKey"];
		private static string _appSID = ConfigurationManager.AppSettings["AppSID"];
		private static string _asposeCloudStorage = ConfigurationManager.AppSettings["AsposeCloudStorage"];
		private static string _baseProductURI = ConfigurationManager.AppSettings["BaseProductURI"];

		public static string ResourceFileSessionName
		{
			get { return _resourceFileSessionName; }
		}
		/// <summary>
		/// Get Working Directory
		/// </summary>
		public static string WorkingDirectory
		{
			get
			{
				string sourceFilespath = HttpContext.Current.Server.MapPath("~/Assets/SourceFiles/");
				if (!System.IO.Directory.Exists(sourceFilespath))
				{
					System.IO.Directory.CreateDirectory(sourceFilespath);
				}

				return sourceFilespath;
			}
		}

		/// <summary>
		/// Get Working Directory
		/// </summary>
		public static string OutputDirectory
		{
			get
			{
				string OutputFilespath = HttpContext.Current.Server.MapPath("~/Assets/OutputFiles/");
				if (!System.IO.Directory.Exists(OutputFilespath))
				{
					System.IO.Directory.CreateDirectory(OutputFilespath);
				}

				return OutputFilespath;
			}
		}
		public static string AsposeDiagramCloudLiveDemosPath
		{
			get { return _asposeDiagramCloudLiveDemosPath; }
		}
		public static string AppKey
		{
			get { return _appKey; }
		}
		public static string BaseProductURI
		{
			get { return _baseProductURI; }
		}
		public static string AppSID
		{
			get { return _appSID; }
		}

		public static string AsposeCloudStorage
		{
			get { return _asposeCloudStorage; }
		}
		public static string AsposeDiagramCloudAppsAssetURL
		{
			get { return _asposeDiagramCloudAppsAssetURL; }
		}


		/*public static string FileViewLink
		{
			get { return _fileViewLink; }
		}*/
	}
}
