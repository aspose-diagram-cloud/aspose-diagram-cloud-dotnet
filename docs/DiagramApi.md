# Aspose.Diagram.Cloud.SDK.Api.DiagramApi

All URIs are relative to *https://api-qa.aspose.cloud/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertDocument**](DiagramApi.md#convertdocument) | **PUT** /diagram/{name}/convert | Converts document from the request&#39;s content to the specified format.
[**CreateNew**](DiagramApi.md#createnew) | **PUT** /diagram/{name} | Create Empty file into the specified format.
[**DownloadFileWithFormat**](DiagramApi.md#downloadfilewithformat) | **GET** /diagram/{name} | Exports the document into the specified format.
[**SaveAs**](DiagramApi.md#saveas) | **POST** /diagram/{name}/saveAs | Converts document to destination format with detailed settings and saves result to storage.


<a name="convertdocument"></a>
# **ConvertDocument**
> System.IO.Stream ConvertDocument (string name, System.IO.Stream file, string sourceFilename = null)

Converts document from the request's content to the specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class ConvertDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiagramApi();
            var name = name_example;  // string | Download document name.
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var sourceFilename = sourceFilename_example;  // string | Source document name. (optional) 

            try
            {
                // Converts document from the request's content to the specified format.
                System.IO.Stream result = apiInstance.ConvertDocument(name, file, sourceFilename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagramApi.ConvertDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Download document name. | 
 **file** | **System.IO.Stream**| File to upload | 
 **sourceFilename** | **string**| Source document name. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnew"></a>
# **CreateNew**
> CreateNewResponse CreateNew (string name, string folder = null, bool? isOverwrite = null)

Create Empty file into the specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class CreateNewExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiagramApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var isOverwrite = true;  // bool? | If true overwrite the same name file.The default value is false  (optional)  (default to false)

            try
            {
                // Create Empty file into the specified format.
                CreateNewResponse result = apiInstance.CreateNew(name, folder, isOverwrite);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagramApi.CreateNew: " + e.Message );
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
 **isOverwrite** | **bool?**| If true overwrite the same name file.The default value is false  | [optional] [default to false]

### Return type

[**CreateNewResponse**](CreateNewResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadfilewithformat"></a>
# **DownloadFileWithFormat**
> System.IO.Stream DownloadFileWithFormat (string name, string format, string folder = null)

Exports the document into the specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class DownloadFileWithFormatExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiagramApi();
            var name = name_example;  // string | The document name.
            var format = format_example;  // string | The destination format.
            var folder = folder_example;  // string | Original document folder. (optional) 

            try
            {
                // Exports the document into the specified format.
                System.IO.Stream result = apiInstance.DownloadFileWithFormat(name, format, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagramApi.DownloadFileWithFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **format** | **string**| The destination format. | 
 **folder** | **string**| Original document folder. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveas"></a>
# **SaveAs**
> SaveAsResponse SaveAs (string name, SaveOptionsRequest saveOptionsRequest, string folder = null, bool? isOverwrite = null)

Converts document to destination format with detailed settings and saves result to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Diagram.Cloud.SDK.Api;
using Aspose.Diagram.Cloud.SDK.Client;
using Aspose.Diagram.Cloud.SDK.Model;

namespace Example
{
    public class SaveAsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DiagramApi();
            var name = name_example;  // string | Original document name.
            var saveOptionsRequest = new SaveOptionsRequest(); // SaveOptionsRequest | Save options.
            var folder = folder_example;  // string | Original document folder. (optional) 
            var isOverwrite = true;  // bool? | If true overwrite the same name file.The default value is false  (optional)  (default to false)

            try
            {
                // Converts document to destination format with detailed settings and saves result to storage.
                SaveAsResponse result = apiInstance.SaveAs(name, saveOptionsRequest, folder, isOverwrite);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagramApi.SaveAs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Original document name. | 
 **saveOptionsRequest** | [**SaveOptionsRequest**](SaveOptionsRequest.md)| Save options. | 
 **folder** | **string**| Original document folder. | [optional] 
 **isOverwrite** | **bool?**| If true overwrite the same name file.The default value is false  | [optional] [default to false]

### Return type

[**SaveAsResponse**](SaveAsResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

