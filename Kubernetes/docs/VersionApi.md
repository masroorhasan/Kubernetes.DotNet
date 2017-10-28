# Kubernetes.DotNet.Api.VersionApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCode**](VersionApi.md#getcode) | **GET** /version/ | 


<a name="getcode"></a>
# **GetCode**
> VersionInfo GetCode ()



get the code version

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class GetCodeExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new VersionApi();

            try
            {
                VersionInfo result = apiInstance.GetCode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionApi.GetCode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**VersionInfo**](VersionInfo.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

