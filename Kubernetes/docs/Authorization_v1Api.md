# Kubernetes.DotNet.Api.Authorization_v1Api

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNamespacedLocalSubjectAccessReview**](Authorization_v1Api.md#createnamespacedlocalsubjectaccessreview) | **POST** /apis/authorization.k8s.io/v1/namespaces/{namespace}/localsubjectaccessreviews | 
[**CreateSelfSubjectAccessReview**](Authorization_v1Api.md#createselfsubjectaccessreview) | **POST** /apis/authorization.k8s.io/v1/selfsubjectaccessreviews | 
[**CreateSubjectAccessReview**](Authorization_v1Api.md#createsubjectaccessreview) | **POST** /apis/authorization.k8s.io/v1/subjectaccessreviews | 
[**GetAPIResources**](Authorization_v1Api.md#getapiresources) | **GET** /apis/authorization.k8s.io/v1/ | 


<a name="createnamespacedlocalsubjectaccessreview"></a>
# **CreateNamespacedLocalSubjectAccessReview**
> V1LocalSubjectAccessReview CreateNamespacedLocalSubjectAccessReview (string _namespace, V1LocalSubjectAccessReview body, string pretty = null)



create a LocalSubjectAccessReview

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedLocalSubjectAccessReviewExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Authorization_v1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1LocalSubjectAccessReview(); // V1LocalSubjectAccessReview | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1LocalSubjectAccessReview result = apiInstance.CreateNamespacedLocalSubjectAccessReview(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Authorization_v1Api.CreateNamespacedLocalSubjectAccessReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1LocalSubjectAccessReview**](V1LocalSubjectAccessReview.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1LocalSubjectAccessReview**](V1LocalSubjectAccessReview.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createselfsubjectaccessreview"></a>
# **CreateSelfSubjectAccessReview**
> V1SelfSubjectAccessReview CreateSelfSubjectAccessReview (V1SelfSubjectAccessReview body, string pretty = null)



create a SelfSubjectAccessReview

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateSelfSubjectAccessReviewExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Authorization_v1Api();
            var body = new V1SelfSubjectAccessReview(); // V1SelfSubjectAccessReview | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1SelfSubjectAccessReview result = apiInstance.CreateSelfSubjectAccessReview(body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Authorization_v1Api.CreateSelfSubjectAccessReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1SelfSubjectAccessReview**](V1SelfSubjectAccessReview.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1SelfSubjectAccessReview**](V1SelfSubjectAccessReview.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubjectaccessreview"></a>
# **CreateSubjectAccessReview**
> V1SubjectAccessReview CreateSubjectAccessReview (V1SubjectAccessReview body, string pretty = null)



create a SubjectAccessReview

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateSubjectAccessReviewExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Authorization_v1Api();
            var body = new V1SubjectAccessReview(); // V1SubjectAccessReview | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1SubjectAccessReview result = apiInstance.CreateSubjectAccessReview(body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Authorization_v1Api.CreateSubjectAccessReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1SubjectAccessReview**](V1SubjectAccessReview.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1SubjectAccessReview**](V1SubjectAccessReview.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapiresources"></a>
# **GetAPIResources**
> V1APIResourceList GetAPIResources ()



get available resources

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class GetAPIResourcesExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Authorization_v1Api();

            try
            {
                V1APIResourceList result = apiInstance.GetAPIResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Authorization_v1Api.GetAPIResources: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**V1APIResourceList**](V1APIResourceList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml, application/vnd.kubernetes.protobuf
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

