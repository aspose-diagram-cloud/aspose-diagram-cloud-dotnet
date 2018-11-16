# Aspose.Diagram.Cloud.SDK.Api.DiagramFileApi

All URIs are relative to *https://api.aspose.cloud/v1.1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DiagramFileGetDiagram**](DiagramFileApi.md#diagramfilegetdiagram) | **GET** /diagram/{name} | Read document info or export.
[**DiagramFilePostSaveAs**](DiagramFileApi.md#diagramfilepostsaveas) | **POST** /diagram/{name}/SaveAs | Convert document and save result to storage.
[**DiagramFilePutCreate**](DiagramFileApi.md#diagramfileputcreate) | **PUT** /diagram/{name} | Create new diagram and save result to storage.
[**DiagramFilePutUpload**](DiagramFileApi.md#diagramfileputupload) | **PUT** /diagram/{name}/upload | Upload file and save result to storage.


<a name="diagramfilegetdiagram"></a>
# **DiagramFileGetDiagram**
> System.IO.Stream DiagramFileGetDiagram (string name, string format = null, string folder = null, string storage = null)

Read document info or export.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class DiagramFileGetDiagramExample
    {
        public void main()
        {
            var apiInstance = new DiagramFileApi();
            var name = name_example;  // string | The document name.
            var format = format_example;  // string | The exported file format. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Read document info or export.
                System.IO.Stream result = apiInstance.DiagramFileGetDiagram(name, format, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagramFileApi.DiagramFileGetDiagram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **format** | **string**| The exported file format. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| storage name. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diagramfilepostsaveas"></a>
# **DiagramFilePostSaveAs**
> SaveResponse DiagramFilePostSaveAs (string name, FileFormatRequest format = null, string newfilename = null, string folder = null, bool? isOverwrite = null, string storage = null)

Convert document and save result to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class DiagramFilePostSaveAsExample
    {
        public void main()
        {
            var apiInstance = new DiagramFileApi();
            var name = name_example;  // string | The document name.
            var format = new FileFormatRequest(); // FileFormatRequest | Save format. (optional) 
            var newfilename = newfilename_example;  // string | The new file name. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var isOverwrite = true;  // bool? | If true overwrite the same name file.The default value is false. (optional)  (default to false)
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Convert document and save result to storage.
                SaveResponse result = apiInstance.DiagramFilePostSaveAs(name, format, newfilename, folder, isOverwrite, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagramFileApi.DiagramFilePostSaveAs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **format** | [**FileFormatRequest**](FileFormatRequest.md)| Save format. | [optional] 
 **newfilename** | **string**| The new file name. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **isOverwrite** | **bool?**| If true overwrite the same name file.The default value is false. | [optional] [default to false]
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaveResponse**](SaveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diagramfileputcreate"></a>
# **DiagramFilePutCreate**
> SaaSposeResponse DiagramFilePutCreate (string name, string folder = null, bool? isOverwrite = null, string storage = null)

Create new diagram and save result to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class DiagramFilePutCreateExample
    {
        public void main()
        {
            var apiInstance = new DiagramFileApi();
            var name = name_example;  // string | The new document name.
            var folder = folder_example;  // string | The new document folder. (optional) 
            var isOverwrite = true;  // bool? | If true overwrite the same name file.The default value is false. (optional)  (default to false)
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Create new diagram and save result to storage.
                SaaSposeResponse result = apiInstance.DiagramFilePutCreate(name, folder, isOverwrite, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagramFileApi.DiagramFilePutCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The new document name. | 
 **folder** | **string**| The new document folder. | [optional] 
 **isOverwrite** | **bool?**| If true overwrite the same name file.The default value is false. | [optional] [default to false]
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diagramfileputupload"></a>
# **DiagramFilePutUpload**
> SaaSposeResponse DiagramFilePutUpload (string name, string folder = null, bool? isOverwrite = null, string storage = null)

Upload file and save result to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class DiagramFilePutUploadExample
    {
        public void main()
        {
            var apiInstance = new DiagramFileApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var isOverwrite = true;  // bool? | If true overwrite the same name file.The default value is false. (optional)  (default to false)
            var storage = storage_example;  // string | storage name. (optional) 

            try
            {
                // Upload file and save result to storage.
                SaaSposeResponse result = apiInstance.DiagramFilePutUpload(name, folder, isOverwrite, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagramFileApi.DiagramFilePutUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **isOverwrite** | **bool?**| If true overwrite the same name file.The default value is false. | [optional] [default to false]
 **storage** | **string**| storage name. | [optional] 

### Return type

[**SaaSposeResponse**](SaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

