# Kubernetes.DotNet.Api.CoreApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAPIVersions**](CoreApi.md#getapiversions) | **GET** /api/ | 


<a name="getapiversions"></a>
# **GetAPIVersions**
> V1APIVersions GetAPIVersions ()



get available API versions

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class GetAPIVersionsExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new CoreApi();

            try
            {
                V1APIVersions result = apiInstance.GetAPIVersions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoreApi.GetAPIVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**V1APIVersions**](V1APIVersions.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml, application/vnd.kubernetes.protobuf
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

