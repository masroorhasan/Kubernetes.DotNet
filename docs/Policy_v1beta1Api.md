# Kubernetes.DotNet.Api.Policy_v1beta1Api

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNamespacedPodDisruptionBudget**](Policy_v1beta1Api.md#createnamespacedpoddisruptionbudget) | **POST** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets | 
[**DeleteCollectionNamespacedPodDisruptionBudget**](Policy_v1beta1Api.md#deletecollectionnamespacedpoddisruptionbudget) | **DELETE** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets | 
[**DeleteNamespacedPodDisruptionBudget**](Policy_v1beta1Api.md#deletenamespacedpoddisruptionbudget) | **DELETE** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets/{name} | 
[**GetAPIResources**](Policy_v1beta1Api.md#getapiresources) | **GET** /apis/policy/v1beta1/ | 
[**ListNamespacedPodDisruptionBudget**](Policy_v1beta1Api.md#listnamespacedpoddisruptionbudget) | **GET** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets | 
[**ListPodDisruptionBudgetForAllNamespaces**](Policy_v1beta1Api.md#listpoddisruptionbudgetforallnamespaces) | **GET** /apis/policy/v1beta1/poddisruptionbudgets | 
[**PatchNamespacedPodDisruptionBudget**](Policy_v1beta1Api.md#patchnamespacedpoddisruptionbudget) | **PATCH** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets/{name} | 
[**PatchNamespacedPodDisruptionBudgetStatus**](Policy_v1beta1Api.md#patchnamespacedpoddisruptionbudgetstatus) | **PATCH** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets/{name}/status | 
[**ReadNamespacedPodDisruptionBudget**](Policy_v1beta1Api.md#readnamespacedpoddisruptionbudget) | **GET** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets/{name} | 
[**ReadNamespacedPodDisruptionBudgetStatus**](Policy_v1beta1Api.md#readnamespacedpoddisruptionbudgetstatus) | **GET** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets/{name}/status | 
[**ReplaceNamespacedPodDisruptionBudget**](Policy_v1beta1Api.md#replacenamespacedpoddisruptionbudget) | **PUT** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets/{name} | 
[**ReplaceNamespacedPodDisruptionBudgetStatus**](Policy_v1beta1Api.md#replacenamespacedpoddisruptionbudgetstatus) | **PUT** /apis/policy/v1beta1/namespaces/{namespace}/poddisruptionbudgets/{name}/status | 


<a name="createnamespacedpoddisruptionbudget"></a>
# **CreateNamespacedPodDisruptionBudget**
> V1beta1PodDisruptionBudget CreateNamespacedPodDisruptionBudget (string _namespace, V1beta1PodDisruptionBudget body, string pretty = null)



create a PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedPodDisruptionBudgetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1PodDisruptionBudget(); // V1beta1PodDisruptionBudget | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodDisruptionBudget result = apiInstance.CreateNamespacedPodDisruptionBudget(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.CreateNamespacedPodDisruptionBudget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollectionnamespacedpoddisruptionbudget"></a>
# **DeleteCollectionNamespacedPodDisruptionBudget**
> V1Status DeleteCollectionNamespacedPodDisruptionBudget (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteCollectionNamespacedPodDisruptionBudgetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteCollectionNamespacedPodDisruptionBudget(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.DeleteCollectionNamespacedPodDisruptionBudget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **includeUninitialized** | **bool?**| If true, partially initialized resources are included in the response. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. | [optional] 

### Return type

[**V1Status**](V1Status.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenamespacedpoddisruptionbudget"></a>
# **DeleteNamespacedPodDisruptionBudget**
> V1Status DeleteNamespacedPodDisruptionBudget (string name, string _namespace, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



delete a PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteNamespacedPodDisruptionBudgetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var name = name_example;  // string | name of the PodDisruptionBudget
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteNamespacedPodDisruptionBudget(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.DeleteNamespacedPodDisruptionBudget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodDisruptionBudget | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1DeleteOptions**](V1DeleteOptions.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 

### Return type

[**V1Status**](V1Status.md)

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

            var apiInstance = new Policy_v1beta1Api();

            try
            {
                V1APIResourceList result = apiInstance.GetAPIResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.GetAPIResources: " + e.Message );
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

<a name="listnamespacedpoddisruptionbudget"></a>
# **ListNamespacedPodDisruptionBudget**
> V1beta1PodDisruptionBudgetList ListNamespacedPodDisruptionBudget (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListNamespacedPodDisruptionBudgetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1beta1PodDisruptionBudgetList result = apiInstance.ListNamespacedPodDisruptionBudget(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.ListNamespacedPodDisruptionBudget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **includeUninitialized** | **bool?**| If true, partially initialized resources are included in the response. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. | [optional] 

### Return type

[**V1beta1PodDisruptionBudgetList**](V1beta1PodDisruptionBudgetList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpoddisruptionbudgetforallnamespaces"></a>
# **ListPodDisruptionBudgetForAllNamespaces**
> V1beta1PodDisruptionBudgetList ListPodDisruptionBudgetForAllNamespaces (string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string pretty = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListPodDisruptionBudgetForAllNamespacesExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1beta1PodDisruptionBudgetList result = apiInstance.ListPodDisruptionBudgetForAllNamespaces(fieldSelector, includeUninitialized, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.ListPodDisruptionBudgetForAllNamespaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **includeUninitialized** | **bool?**| If true, partially initialized resources are included in the response. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. | [optional] 

### Return type

[**V1beta1PodDisruptionBudgetList**](V1beta1PodDisruptionBudgetList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedpoddisruptionbudget"></a>
# **PatchNamespacedPodDisruptionBudget**
> V1beta1PodDisruptionBudget PatchNamespacedPodDisruptionBudget (string name, string _namespace, Object body, string pretty = null)



partially update the specified PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedPodDisruptionBudgetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var name = name_example;  // string | name of the PodDisruptionBudget
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodDisruptionBudget result = apiInstance.PatchNamespacedPodDisruptionBudget(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.PatchNamespacedPodDisruptionBudget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodDisruptionBudget | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedpoddisruptionbudgetstatus"></a>
# **PatchNamespacedPodDisruptionBudgetStatus**
> V1beta1PodDisruptionBudget PatchNamespacedPodDisruptionBudgetStatus (string name, string _namespace, Object body, string pretty = null)



partially update status of the specified PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedPodDisruptionBudgetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var name = name_example;  // string | name of the PodDisruptionBudget
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodDisruptionBudget result = apiInstance.PatchNamespacedPodDisruptionBudgetStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.PatchNamespacedPodDisruptionBudgetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodDisruptionBudget | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedpoddisruptionbudget"></a>
# **ReadNamespacedPodDisruptionBudget**
> V1beta1PodDisruptionBudget ReadNamespacedPodDisruptionBudget (string name, string _namespace, string pretty = null, bool? exact = null, bool? export = null)



read the specified PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedPodDisruptionBudgetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var name = name_example;  // string | name of the PodDisruptionBudget
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace'. (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1beta1PodDisruptionBudget result = apiInstance.ReadNamespacedPodDisruptionBudget(name, _namespace, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.ReadNamespacedPodDisruptionBudget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodDisruptionBudget | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;. | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedpoddisruptionbudgetstatus"></a>
# **ReadNamespacedPodDisruptionBudgetStatus**
> V1beta1PodDisruptionBudget ReadNamespacedPodDisruptionBudgetStatus (string name, string _namespace, string pretty = null)



read status of the specified PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedPodDisruptionBudgetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var name = name_example;  // string | name of the PodDisruptionBudget
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodDisruptionBudget result = apiInstance.ReadNamespacedPodDisruptionBudgetStatus(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.ReadNamespacedPodDisruptionBudgetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodDisruptionBudget | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedpoddisruptionbudget"></a>
# **ReplaceNamespacedPodDisruptionBudget**
> V1beta1PodDisruptionBudget ReplaceNamespacedPodDisruptionBudget (string name, string _namespace, V1beta1PodDisruptionBudget body, string pretty = null)



replace the specified PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedPodDisruptionBudgetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var name = name_example;  // string | name of the PodDisruptionBudget
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1PodDisruptionBudget(); // V1beta1PodDisruptionBudget | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodDisruptionBudget result = apiInstance.ReplaceNamespacedPodDisruptionBudget(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.ReplaceNamespacedPodDisruptionBudget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodDisruptionBudget | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedpoddisruptionbudgetstatus"></a>
# **ReplaceNamespacedPodDisruptionBudgetStatus**
> V1beta1PodDisruptionBudget ReplaceNamespacedPodDisruptionBudgetStatus (string name, string _namespace, V1beta1PodDisruptionBudget body, string pretty = null)



replace status of the specified PodDisruptionBudget

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedPodDisruptionBudgetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Policy_v1beta1Api();
            var name = name_example;  // string | name of the PodDisruptionBudget
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1PodDisruptionBudget(); // V1beta1PodDisruptionBudget | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodDisruptionBudget result = apiInstance.ReplaceNamespacedPodDisruptionBudgetStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Policy_v1beta1Api.ReplaceNamespacedPodDisruptionBudgetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodDisruptionBudget | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodDisruptionBudget**](V1beta1PodDisruptionBudget.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

