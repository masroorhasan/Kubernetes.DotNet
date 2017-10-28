# Kubernetes.DotNet.Api.Custom_objectsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateClusterCustomObject**](Custom_objectsApi.md#createclustercustomobject) | **POST** /apis/{group}/{version}/{plural} | 
[**CreateNamespacedCustomObject**](Custom_objectsApi.md#createnamespacedcustomobject) | **POST** /apis/{group}/{version}/namespaces/{namespace}/{plural} | 
[**DeleteClusterCustomObject**](Custom_objectsApi.md#deleteclustercustomobject) | **DELETE** /apis/{group}/{version}/{plural}/{name} | 
[**DeleteNamespacedCustomObject**](Custom_objectsApi.md#deletenamespacedcustomobject) | **DELETE** /apis/{group}/{version}/namespaces/{namespace}/{plural}/{name} | 
[**GetClusterCustomObject**](Custom_objectsApi.md#getclustercustomobject) | **GET** /apis/{group}/{version}/{plural}/{name} | 
[**GetNamespacedCustomObject**](Custom_objectsApi.md#getnamespacedcustomobject) | **GET** /apis/{group}/{version}/namespaces/{namespace}/{plural}/{name} | 
[**ListClusterCustomObject**](Custom_objectsApi.md#listclustercustomobject) | **GET** /apis/{group}/{version}/{plural} | 
[**ListNamespacedCustomObject**](Custom_objectsApi.md#listnamespacedcustomobject) | **GET** /apis/{group}/{version}/namespaces/{namespace}/{plural} | 
[**ReplaceClusterCustomObject**](Custom_objectsApi.md#replaceclustercustomobject) | **PUT** /apis/{group}/{version}/{plural}/{name} | 
[**ReplaceNamespacedCustomObject**](Custom_objectsApi.md#replacenamespacedcustomobject) | **PUT** /apis/{group}/{version}/namespaces/{namespace}/{plural}/{name} | 


<a name="createclustercustomobject"></a>
# **CreateClusterCustomObject**
> Object CreateClusterCustomObject (string group, string version, string plural, Object body, string pretty = null)



Creates a cluster scoped Custom object

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateClusterCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | The custom resource's group name
            var version = version_example;  // string | The custom resource's version
            var plural = plural_example;  // string | The custom resource's plural name. For TPRs this would be lowercase plural kind.
            var body = ;  // Object | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                Object result = apiInstance.CreateClusterCustomObject(group, version, plural, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.CreateClusterCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The custom resource&#39;s group name | 
 **version** | **string**| The custom resource&#39;s version | 
 **plural** | **string**| The custom resource&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **body** | **Object**| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnamespacedcustomobject"></a>
# **CreateNamespacedCustomObject**
> Object CreateNamespacedCustomObject (string group, string version, string _namespace, string plural, Object body, string pretty = null)



Creates a namespace scoped Custom object

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | The custom resource's group name
            var version = version_example;  // string | The custom resource's version
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var plural = plural_example;  // string | The custom resource's plural name. For TPRs this would be lowercase plural kind.
            var body = ;  // Object | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                Object result = apiInstance.CreateNamespacedCustomObject(group, version, _namespace, plural, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.CreateNamespacedCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The custom resource&#39;s group name | 
 **version** | **string**| The custom resource&#39;s version | 
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **plural** | **string**| The custom resource&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **body** | **Object**| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclustercustomobject"></a>
# **DeleteClusterCustomObject**
> Object DeleteClusterCustomObject (string group, string version, string plural, string name, V1DeleteOptions body, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



Deletes the specified cluster scoped custom object

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteClusterCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | the custom resource's group
            var version = version_example;  // string | the custom resource's version
            var plural = plural_example;  // string | the custom object's plural name. For TPRs this would be lowercase plural kind.
            var name = name_example;  // string | the custom object's name
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                Object result = apiInstance.DeleteClusterCustomObject(group, version, plural, name, body, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.DeleteClusterCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| the custom resource&#39;s group | 
 **version** | **string**| the custom resource&#39;s version | 
 **plural** | **string**| the custom object&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**V1DeleteOptions**](V1DeleteOptions.md)|  | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenamespacedcustomobject"></a>
# **DeleteNamespacedCustomObject**
> Object DeleteNamespacedCustomObject (string group, string version, string _namespace, string plural, string name, V1DeleteOptions body, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



Deletes the specified namespace scoped custom object

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteNamespacedCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | the custom resource's group
            var version = version_example;  // string | the custom resource's version
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var plural = plural_example;  // string | the custom resource's plural name. For TPRs this would be lowercase plural kind.
            var name = name_example;  // string | the custom object's name
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                Object result = apiInstance.DeleteNamespacedCustomObject(group, version, _namespace, plural, name, body, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.DeleteNamespacedCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| the custom resource&#39;s group | 
 **version** | **string**| the custom resource&#39;s version | 
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **plural** | **string**| the custom resource&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**V1DeleteOptions**](V1DeleteOptions.md)|  | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclustercustomobject"></a>
# **GetClusterCustomObject**
> Object GetClusterCustomObject (string group, string version, string plural, string name)



Returns a cluster scoped custom object

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class GetClusterCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | the custom resource's group
            var version = version_example;  // string | the custom resource's version
            var plural = plural_example;  // string | the custom object's plural name. For TPRs this would be lowercase plural kind.
            var name = name_example;  // string | the custom object's name

            try
            {
                Object result = apiInstance.GetClusterCustomObject(group, version, plural, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.GetClusterCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| the custom resource&#39;s group | 
 **version** | **string**| the custom resource&#39;s version | 
 **plural** | **string**| the custom object&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnamespacedcustomobject"></a>
# **GetNamespacedCustomObject**
> Object GetNamespacedCustomObject (string group, string version, string _namespace, string plural, string name)



Returns a namespace scoped custom object

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class GetNamespacedCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | the custom resource's group
            var version = version_example;  // string | the custom resource's version
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var plural = plural_example;  // string | the custom resource's plural name. For TPRs this would be lowercase plural kind.
            var name = name_example;  // string | the custom object's name

            try
            {
                Object result = apiInstance.GetNamespacedCustomObject(group, version, _namespace, plural, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.GetNamespacedCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| the custom resource&#39;s group | 
 **version** | **string**| the custom resource&#39;s version | 
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **plural** | **string**| the custom resource&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listclustercustomobject"></a>
# **ListClusterCustomObject**
> Object ListClusterCustomObject (string group, string version, string plural, string pretty = null, string labelSelector = null, string resourceVersion = null, bool? watch = null)



list or watch cluster scoped custom objects

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListClusterCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | The custom resource's group name
            var version = version_example;  // string | The custom resource's version
            var plural = plural_example;  // string | The custom resource's plural name. For TPRs this would be lowercase plural kind.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                Object result = apiInstance.ListClusterCustomObject(group, version, plural, pretty, labelSelector, resourceVersion, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.ListClusterCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The custom resource&#39;s group name | 
 **version** | **string**| The custom resource&#39;s version | 
 **plural** | **string**| The custom resource&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/json;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnamespacedcustomobject"></a>
# **ListNamespacedCustomObject**
> Object ListNamespacedCustomObject (string group, string version, string _namespace, string plural, string pretty = null, string labelSelector = null, string resourceVersion = null, bool? watch = null)



list or watch namespace scoped custom objects

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListNamespacedCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | The custom resource's group name
            var version = version_example;  // string | The custom resource's version
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var plural = plural_example;  // string | The custom resource's plural name. For TPRs this would be lowercase plural kind.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                Object result = apiInstance.ListNamespacedCustomObject(group, version, _namespace, plural, pretty, labelSelector, resourceVersion, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.ListNamespacedCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The custom resource&#39;s group name | 
 **version** | **string**| The custom resource&#39;s version | 
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **plural** | **string**| The custom resource&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/json;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceclustercustomobject"></a>
# **ReplaceClusterCustomObject**
> Object ReplaceClusterCustomObject (string group, string version, string plural, string name, Object body)



replace the specified cluster scoped custom object

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceClusterCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | the custom resource's group
            var version = version_example;  // string | the custom resource's version
            var plural = plural_example;  // string | the custom object's plural name. For TPRs this would be lowercase plural kind.
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to replace.

            try
            {
                Object result = apiInstance.ReplaceClusterCustomObject(group, version, plural, name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.ReplaceClusterCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| the custom resource&#39;s group | 
 **version** | **string**| the custom resource&#39;s version | 
 **plural** | **string**| the custom object&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to replace. | 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedcustomobject"></a>
# **ReplaceNamespacedCustomObject**
> Object ReplaceNamespacedCustomObject (string group, string version, string _namespace, string plural, string name, Object body)



replace the specified namespace scoped custom object

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedCustomObjectExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Custom_objectsApi();
            var group = group_example;  // string | the custom resource's group
            var version = version_example;  // string | the custom resource's version
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var plural = plural_example;  // string | the custom resource's plural name. For TPRs this would be lowercase plural kind.
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to replace.

            try
            {
                Object result = apiInstance.ReplaceNamespacedCustomObject(group, version, _namespace, plural, name, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Custom_objectsApi.ReplaceNamespacedCustomObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| the custom resource&#39;s group | 
 **version** | **string**| the custom resource&#39;s version | 
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **plural** | **string**| the custom resource&#39;s plural name. For TPRs this would be lowercase plural kind. | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to replace. | 

### Return type

**Object**

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

