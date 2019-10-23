# Aspose.Diagram.Cloud.SDK.Api.StorageApi

All URIs are relative to *https://api-qa.aspose.cloud/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CopyFile**](StorageApi.md#copyfile) | **PUT** /diagram/storage/file/copy/{srcPath} | Copy file
[**CopyFolder**](StorageApi.md#copyfolder) | **PUT** /diagram/storage/folder/copy/{srcPath} | Copy folder
[**CreateFolder**](StorageApi.md#createfolder) | **PUT** /diagram/storage/folder/{path} | Create the folder
[**DeleteFile**](StorageApi.md#deletefile) | **DELETE** /diagram/storage/file/{path} | Delete file
[**DeleteFolder**](StorageApi.md#deletefolder) | **DELETE** /diagram/storage/folder/{path} | Delete folder
[**DownloadFile**](StorageApi.md#downloadfile) | **GET** /diagram/storage/file/{path} | Download file
[**GetDiscUsage**](StorageApi.md#getdiscusage) | **GET** /diagram/storage/disc | Get disc usage
[**GetFileVersions**](StorageApi.md#getfileversions) | **GET** /diagram/storage/version/{path} | Get file versions
[**GetFilesList**](StorageApi.md#getfileslist) | **GET** /diagram/storage/folder/{path} | Get all files and folders within a folder
[**MoveFile**](StorageApi.md#movefile) | **PUT** /diagram/storage/file/move/{srcPath} | Move file
[**MoveFolder**](StorageApi.md#movefolder) | **PUT** /diagram/storage/folder/move/{srcPath} | Move folder
[**ObjectExists**](StorageApi.md#objectexists) | **GET** /diagram/storage/exist/{path} | Check if file or folder exists
[**StorageExists**](StorageApi.md#storageexists) | **GET** /diagram/storage/{storageName}/exist | Check if storage exists
[**UploadFile**](StorageApi.md#uploadfile) | **PUT** /diagram/storage/file/{path} | Upload file


<a name="copyfile"></a>
# **CopyFile**
> void CopyFile (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)

Copy file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class CopyFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var srcPath = srcPath_example;  // string | Source file path e.g. '/folder/file.ext'
            var destPath = destPath_example;  // string | Destination file path
            var srcStorageName = srcStorageName_example;  // string | Source storage name (optional) 
            var destStorageName = destStorageName_example;  // string | Destination storage name (optional) 
            var versionId = versionId_example;  // string | File version ID to copy (optional) 

            try
            {
                // Copy file
                apiInstance.CopyFile(srcPath, destPath, srcStorageName, destStorageName, versionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.CopyFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; | 
 **destPath** | **string**| Destination file path | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to copy | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copyfolder"></a>
# **CopyFolder**
> void CopyFolder (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)

Copy folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class CopyFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var srcPath = srcPath_example;  // string | Source folder path e.g. '/src'
            var destPath = destPath_example;  // string | Destination folder path e.g. '/dst'
            var srcStorageName = srcStorageName_example;  // string | Source storage name (optional) 
            var destStorageName = destStorageName_example;  // string | Destination storage name (optional) 

            try
            {
                // Copy folder
                apiInstance.CopyFolder(srcPath, destPath, srcStorageName, destStorageName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.CopyFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source folder path e.g. &#39;/src&#39; | 
 **destPath** | **string**| Destination folder path e.g. &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfolder"></a>
# **CreateFolder**
> void CreateFolder (string path, string storageName = null)

Create the folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class CreateFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | Folder path to create e.g. 'folder_1/folder_2/'
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Create the folder
                apiInstance.CreateFolder(path, storageName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.CreateFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path to create e.g. &#39;folder_1/folder_2/&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefile"></a>
# **DeleteFile**
> void DeleteFile (string path, string storageName = null, string versionId = null)

Delete file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class DeleteFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | File path e.g. '/folder/file.ext'
            var storageName = storageName_example;  // string | Storage name (optional) 
            var versionId = versionId_example;  // string | File version ID to delete (optional) 

            try
            {
                // Delete file
                apiInstance.DeleteFile(path, storageName, versionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to delete | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefolder"></a>
# **DeleteFolder**
> void DeleteFolder (string path, string storageName = null, bool? recursive = null)

Delete folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class DeleteFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | Folder path e.g. '/folder'
            var storageName = storageName_example;  // string | Storage name (optional) 
            var recursive = true;  // bool? | Enable to delete folders, subfolders and files (optional)  (default to false)

            try
            {
                // Delete folder
                apiInstance.DeleteFolder(path, storageName, recursive);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **recursive** | **bool?**| Enable to delete folders, subfolders and files | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadfile"></a>
# **DownloadFile**
> System.IO.Stream DownloadFile (string path, string storageName = null, string versionId = null)

Download file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class DownloadFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | File path e.g. '/folder/file.ext'
            var storageName = storageName_example;  // string | Storage name (optional) 
            var versionId = versionId_example;  // string | File version ID to download (optional) 

            try
            {
                // Download file
                System.IO.Stream result = apiInstance.DownloadFile(path, storageName, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.DownloadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to download | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiscusage"></a>
# **GetDiscUsage**
> DiscUsage GetDiscUsage (string storageName = null)

Get disc usage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class GetDiscUsageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Get disc usage
                DiscUsage result = apiInstance.GetDiscUsage(storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetDiscUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**DiscUsage**](DiscUsage.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfileversions"></a>
# **GetFileVersions**
> FileVersions GetFileVersions (string path, string storageName = null)

Get file versions

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class GetFileVersionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | File path e.g. '/file.ext'
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Get file versions
                FileVersions result = apiInstance.GetFileVersions(path, storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetFileVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FileVersions**](FileVersions.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfileslist"></a>
# **GetFilesList**
> FilesList GetFilesList (string path, string storageName = null)

Get all files and folders within a folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class GetFilesListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | Folder path e.g. '/folder'
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Get all files and folders within a folder
                FilesList result = apiInstance.GetFilesList(path, storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetFilesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesList**](FilesList.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movefile"></a>
# **MoveFile**
> void MoveFile (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)

Move file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class MoveFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var srcPath = srcPath_example;  // string | Source file path e.g. '/src.ext'
            var destPath = destPath_example;  // string | Destination file path e.g. '/dest.ext'
            var srcStorageName = srcStorageName_example;  // string | Source storage name (optional) 
            var destStorageName = destStorageName_example;  // string | Destination storage name (optional) 
            var versionId = versionId_example;  // string | File version ID to move (optional) 

            try
            {
                // Move file
                apiInstance.MoveFile(srcPath, destPath, srcStorageName, destStorageName, versionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.MoveFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to move | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movefolder"></a>
# **MoveFolder**
> void MoveFolder (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)

Move folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class MoveFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var srcPath = srcPath_example;  // string | Folder path to move e.g. '/folder'
            var destPath = destPath_example;  // string | Destination folder path to move to e.g '/dst'
            var srcStorageName = srcStorageName_example;  // string | Source storage name (optional) 
            var destStorageName = destStorageName_example;  // string | Destination storage name (optional) 

            try
            {
                // Move folder
                apiInstance.MoveFolder(srcPath, destPath, srcStorageName, destStorageName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.MoveFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Folder path to move e.g. &#39;/folder&#39; | 
 **destPath** | **string**| Destination folder path to move to e.g &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="objectexists"></a>
# **ObjectExists**
> ObjectExist ObjectExists (string path, string storageName = null, string versionId = null)

Check if file or folder exists

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class ObjectExistsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | File or folder path e.g. '/file.ext' or '/folder'
            var storageName = storageName_example;  // string | Storage name (optional) 
            var versionId = versionId_example;  // string | File version ID (optional) 

            try
            {
                // Check if file or folder exists
                ObjectExist result = apiInstance.ObjectExists(path, storageName, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ObjectExists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

### Return type

[**ObjectExist**](ObjectExist.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storageexists"></a>
# **StorageExists**
> StorageExist StorageExists (string storageName)

Check if storage exists

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class StorageExistsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var storageName = storageName_example;  // string | Storage name

            try
            {
                // Check if storage exists
                StorageExist result = apiInstance.StorageExists(storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageExists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

### Return type

[**StorageExist**](StorageExist.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadfile"></a>
# **UploadFile**
> FilesUploadResult UploadFile (string path, System.IO.Stream file, string storageName = null)

Upload file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class UploadFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Upload file
                FilesUploadResult result = apiInstance.UploadFile(path, file, storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.UploadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.              | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

