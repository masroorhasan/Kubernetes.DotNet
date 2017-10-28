# Kubernetes.DotNet.Api.Extensions_v1beta1Api

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNamespacedDaemonSet**](Extensions_v1beta1Api.md#createnamespaceddaemonset) | **POST** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets | 
[**CreateNamespacedDeployment**](Extensions_v1beta1Api.md#createnamespaceddeployment) | **POST** /apis/extensions/v1beta1/namespaces/{namespace}/deployments | 
[**CreateNamespacedDeploymentRollback**](Extensions_v1beta1Api.md#createnamespaceddeploymentrollback) | **POST** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/rollback | 
[**CreateNamespacedIngress**](Extensions_v1beta1Api.md#createnamespacedingress) | **POST** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses | 
[**CreateNamespacedNetworkPolicy**](Extensions_v1beta1Api.md#createnamespacednetworkpolicy) | **POST** /apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies | 
[**CreateNamespacedReplicaSet**](Extensions_v1beta1Api.md#createnamespacedreplicaset) | **POST** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets | 
[**CreatePodSecurityPolicy**](Extensions_v1beta1Api.md#createpodsecuritypolicy) | **POST** /apis/extensions/v1beta1/podsecuritypolicies | 
[**CreateThirdPartyResource**](Extensions_v1beta1Api.md#createthirdpartyresource) | **POST** /apis/extensions/v1beta1/thirdpartyresources | 
[**DeleteCollectionNamespacedDaemonSet**](Extensions_v1beta1Api.md#deletecollectionnamespaceddaemonset) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets | 
[**DeleteCollectionNamespacedDeployment**](Extensions_v1beta1Api.md#deletecollectionnamespaceddeployment) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/deployments | 
[**DeleteCollectionNamespacedIngress**](Extensions_v1beta1Api.md#deletecollectionnamespacedingress) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses | 
[**DeleteCollectionNamespacedNetworkPolicy**](Extensions_v1beta1Api.md#deletecollectionnamespacednetworkpolicy) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies | 
[**DeleteCollectionNamespacedReplicaSet**](Extensions_v1beta1Api.md#deletecollectionnamespacedreplicaset) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets | 
[**DeleteCollectionPodSecurityPolicy**](Extensions_v1beta1Api.md#deletecollectionpodsecuritypolicy) | **DELETE** /apis/extensions/v1beta1/podsecuritypolicies | 
[**DeleteCollectionThirdPartyResource**](Extensions_v1beta1Api.md#deletecollectionthirdpartyresource) | **DELETE** /apis/extensions/v1beta1/thirdpartyresources | 
[**DeleteNamespacedDaemonSet**](Extensions_v1beta1Api.md#deletenamespaceddaemonset) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name} | 
[**DeleteNamespacedDeployment**](Extensions_v1beta1Api.md#deletenamespaceddeployment) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name} | 
[**DeleteNamespacedIngress**](Extensions_v1beta1Api.md#deletenamespacedingress) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name} | 
[**DeleteNamespacedNetworkPolicy**](Extensions_v1beta1Api.md#deletenamespacednetworkpolicy) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies/{name} | 
[**DeleteNamespacedReplicaSet**](Extensions_v1beta1Api.md#deletenamespacedreplicaset) | **DELETE** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name} | 
[**DeletePodSecurityPolicy**](Extensions_v1beta1Api.md#deletepodsecuritypolicy) | **DELETE** /apis/extensions/v1beta1/podsecuritypolicies/{name} | 
[**DeleteThirdPartyResource**](Extensions_v1beta1Api.md#deletethirdpartyresource) | **DELETE** /apis/extensions/v1beta1/thirdpartyresources/{name} | 
[**GetAPIResources**](Extensions_v1beta1Api.md#getapiresources) | **GET** /apis/extensions/v1beta1/ | 
[**ListDaemonSetForAllNamespaces**](Extensions_v1beta1Api.md#listdaemonsetforallnamespaces) | **GET** /apis/extensions/v1beta1/daemonsets | 
[**ListDeploymentForAllNamespaces**](Extensions_v1beta1Api.md#listdeploymentforallnamespaces) | **GET** /apis/extensions/v1beta1/deployments | 
[**ListIngressForAllNamespaces**](Extensions_v1beta1Api.md#listingressforallnamespaces) | **GET** /apis/extensions/v1beta1/ingresses | 
[**ListNamespacedDaemonSet**](Extensions_v1beta1Api.md#listnamespaceddaemonset) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets | 
[**ListNamespacedDeployment**](Extensions_v1beta1Api.md#listnamespaceddeployment) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/deployments | 
[**ListNamespacedIngress**](Extensions_v1beta1Api.md#listnamespacedingress) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses | 
[**ListNamespacedNetworkPolicy**](Extensions_v1beta1Api.md#listnamespacednetworkpolicy) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies | 
[**ListNamespacedReplicaSet**](Extensions_v1beta1Api.md#listnamespacedreplicaset) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets | 
[**ListNetworkPolicyForAllNamespaces**](Extensions_v1beta1Api.md#listnetworkpolicyforallnamespaces) | **GET** /apis/extensions/v1beta1/networkpolicies | 
[**ListPodSecurityPolicy**](Extensions_v1beta1Api.md#listpodsecuritypolicy) | **GET** /apis/extensions/v1beta1/podsecuritypolicies | 
[**ListReplicaSetForAllNamespaces**](Extensions_v1beta1Api.md#listreplicasetforallnamespaces) | **GET** /apis/extensions/v1beta1/replicasets | 
[**ListThirdPartyResource**](Extensions_v1beta1Api.md#listthirdpartyresource) | **GET** /apis/extensions/v1beta1/thirdpartyresources | 
[**PatchNamespacedDaemonSet**](Extensions_v1beta1Api.md#patchnamespaceddaemonset) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name} | 
[**PatchNamespacedDaemonSetStatus**](Extensions_v1beta1Api.md#patchnamespaceddaemonsetstatus) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}/status | 
[**PatchNamespacedDeployment**](Extensions_v1beta1Api.md#patchnamespaceddeployment) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name} | 
[**PatchNamespacedDeploymentScale**](Extensions_v1beta1Api.md#patchnamespaceddeploymentscale) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale | 
[**PatchNamespacedDeploymentStatus**](Extensions_v1beta1Api.md#patchnamespaceddeploymentstatus) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/status | 
[**PatchNamespacedIngress**](Extensions_v1beta1Api.md#patchnamespacedingress) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name} | 
[**PatchNamespacedIngressStatus**](Extensions_v1beta1Api.md#patchnamespacedingressstatus) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}/status | 
[**PatchNamespacedNetworkPolicy**](Extensions_v1beta1Api.md#patchnamespacednetworkpolicy) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies/{name} | 
[**PatchNamespacedReplicaSet**](Extensions_v1beta1Api.md#patchnamespacedreplicaset) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name} | 
[**PatchNamespacedReplicaSetScale**](Extensions_v1beta1Api.md#patchnamespacedreplicasetscale) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale | 
[**PatchNamespacedReplicaSetStatus**](Extensions_v1beta1Api.md#patchnamespacedreplicasetstatus) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/status | 
[**PatchNamespacedReplicationControllerDummyScale**](Extensions_v1beta1Api.md#patchnamespacedreplicationcontrollerdummyscale) | **PATCH** /apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale | 
[**PatchPodSecurityPolicy**](Extensions_v1beta1Api.md#patchpodsecuritypolicy) | **PATCH** /apis/extensions/v1beta1/podsecuritypolicies/{name} | 
[**PatchThirdPartyResource**](Extensions_v1beta1Api.md#patchthirdpartyresource) | **PATCH** /apis/extensions/v1beta1/thirdpartyresources/{name} | 
[**ReadNamespacedDaemonSet**](Extensions_v1beta1Api.md#readnamespaceddaemonset) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name} | 
[**ReadNamespacedDaemonSetStatus**](Extensions_v1beta1Api.md#readnamespaceddaemonsetstatus) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}/status | 
[**ReadNamespacedDeployment**](Extensions_v1beta1Api.md#readnamespaceddeployment) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name} | 
[**ReadNamespacedDeploymentScale**](Extensions_v1beta1Api.md#readnamespaceddeploymentscale) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale | 
[**ReadNamespacedDeploymentStatus**](Extensions_v1beta1Api.md#readnamespaceddeploymentstatus) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/status | 
[**ReadNamespacedIngress**](Extensions_v1beta1Api.md#readnamespacedingress) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name} | 
[**ReadNamespacedIngressStatus**](Extensions_v1beta1Api.md#readnamespacedingressstatus) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}/status | 
[**ReadNamespacedNetworkPolicy**](Extensions_v1beta1Api.md#readnamespacednetworkpolicy) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies/{name} | 
[**ReadNamespacedReplicaSet**](Extensions_v1beta1Api.md#readnamespacedreplicaset) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name} | 
[**ReadNamespacedReplicaSetScale**](Extensions_v1beta1Api.md#readnamespacedreplicasetscale) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale | 
[**ReadNamespacedReplicaSetStatus**](Extensions_v1beta1Api.md#readnamespacedreplicasetstatus) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/status | 
[**ReadNamespacedReplicationControllerDummyScale**](Extensions_v1beta1Api.md#readnamespacedreplicationcontrollerdummyscale) | **GET** /apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale | 
[**ReadPodSecurityPolicy**](Extensions_v1beta1Api.md#readpodsecuritypolicy) | **GET** /apis/extensions/v1beta1/podsecuritypolicies/{name} | 
[**ReadThirdPartyResource**](Extensions_v1beta1Api.md#readthirdpartyresource) | **GET** /apis/extensions/v1beta1/thirdpartyresources/{name} | 
[**ReplaceNamespacedDaemonSet**](Extensions_v1beta1Api.md#replacenamespaceddaemonset) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name} | 
[**ReplaceNamespacedDaemonSetStatus**](Extensions_v1beta1Api.md#replacenamespaceddaemonsetstatus) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}/status | 
[**ReplaceNamespacedDeployment**](Extensions_v1beta1Api.md#replacenamespaceddeployment) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name} | 
[**ReplaceNamespacedDeploymentScale**](Extensions_v1beta1Api.md#replacenamespaceddeploymentscale) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale | 
[**ReplaceNamespacedDeploymentStatus**](Extensions_v1beta1Api.md#replacenamespaceddeploymentstatus) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/status | 
[**ReplaceNamespacedIngress**](Extensions_v1beta1Api.md#replacenamespacedingress) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name} | 
[**ReplaceNamespacedIngressStatus**](Extensions_v1beta1Api.md#replacenamespacedingressstatus) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}/status | 
[**ReplaceNamespacedNetworkPolicy**](Extensions_v1beta1Api.md#replacenamespacednetworkpolicy) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies/{name} | 
[**ReplaceNamespacedReplicaSet**](Extensions_v1beta1Api.md#replacenamespacedreplicaset) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name} | 
[**ReplaceNamespacedReplicaSetScale**](Extensions_v1beta1Api.md#replacenamespacedreplicasetscale) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale | 
[**ReplaceNamespacedReplicaSetStatus**](Extensions_v1beta1Api.md#replacenamespacedreplicasetstatus) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/status | 
[**ReplaceNamespacedReplicationControllerDummyScale**](Extensions_v1beta1Api.md#replacenamespacedreplicationcontrollerdummyscale) | **PUT** /apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale | 
[**ReplacePodSecurityPolicy**](Extensions_v1beta1Api.md#replacepodsecuritypolicy) | **PUT** /apis/extensions/v1beta1/podsecuritypolicies/{name} | 
[**ReplaceThirdPartyResource**](Extensions_v1beta1Api.md#replacethirdpartyresource) | **PUT** /apis/extensions/v1beta1/thirdpartyresources/{name} | 


<a name="createnamespaceddaemonset"></a>
# **CreateNamespacedDaemonSet**
> V1beta1DaemonSet CreateNamespacedDaemonSet (string _namespace, V1beta1DaemonSet body, string pretty = null)



create a DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedDaemonSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1DaemonSet(); // V1beta1DaemonSet | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1DaemonSet result = apiInstance.CreateNamespacedDaemonSet(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.CreateNamespacedDaemonSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1DaemonSet**](V1beta1DaemonSet.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1DaemonSet**](V1beta1DaemonSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnamespaceddeployment"></a>
# **CreateNamespacedDeployment**
> ExtensionsV1beta1Deployment CreateNamespacedDeployment (string _namespace, ExtensionsV1beta1Deployment body, string pretty = null)



create a Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new ExtensionsV1beta1Deployment(); // ExtensionsV1beta1Deployment | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Deployment result = apiInstance.CreateNamespacedDeployment(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.CreateNamespacedDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnamespaceddeploymentrollback"></a>
# **CreateNamespacedDeploymentRollback**
> ExtensionsV1beta1DeploymentRollback CreateNamespacedDeploymentRollback (string name, string _namespace, ExtensionsV1beta1DeploymentRollback body, string pretty = null)



create rollback of a Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedDeploymentRollbackExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the DeploymentRollback
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new ExtensionsV1beta1DeploymentRollback(); // ExtensionsV1beta1DeploymentRollback | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1DeploymentRollback result = apiInstance.CreateNamespacedDeploymentRollback(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.CreateNamespacedDeploymentRollback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the DeploymentRollback | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**ExtensionsV1beta1DeploymentRollback**](ExtensionsV1beta1DeploymentRollback.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1DeploymentRollback**](ExtensionsV1beta1DeploymentRollback.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnamespacedingress"></a>
# **CreateNamespacedIngress**
> V1beta1Ingress CreateNamespacedIngress (string _namespace, V1beta1Ingress body, string pretty = null)



create an Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedIngressExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1Ingress(); // V1beta1Ingress | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1Ingress result = apiInstance.CreateNamespacedIngress(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.CreateNamespacedIngress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1Ingress**](V1beta1Ingress.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1Ingress**](V1beta1Ingress.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnamespacednetworkpolicy"></a>
# **CreateNamespacedNetworkPolicy**
> V1beta1NetworkPolicy CreateNamespacedNetworkPolicy (string _namespace, V1beta1NetworkPolicy body, string pretty = null)



create a NetworkPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedNetworkPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1NetworkPolicy(); // V1beta1NetworkPolicy | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1NetworkPolicy result = apiInstance.CreateNamespacedNetworkPolicy(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.CreateNamespacedNetworkPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1NetworkPolicy**](V1beta1NetworkPolicy.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1NetworkPolicy**](V1beta1NetworkPolicy.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnamespacedreplicaset"></a>
# **CreateNamespacedReplicaSet**
> V1beta1ReplicaSet CreateNamespacedReplicaSet (string _namespace, V1beta1ReplicaSet body, string pretty = null)



create a ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateNamespacedReplicaSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1ReplicaSet(); // V1beta1ReplicaSet | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ReplicaSet result = apiInstance.CreateNamespacedReplicaSet(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.CreateNamespacedReplicaSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpodsecuritypolicy"></a>
# **CreatePodSecurityPolicy**
> V1beta1PodSecurityPolicy CreatePodSecurityPolicy (V1beta1PodSecurityPolicy body, string pretty = null)



create a PodSecurityPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreatePodSecurityPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var body = new V1beta1PodSecurityPolicy(); // V1beta1PodSecurityPolicy | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodSecurityPolicy result = apiInstance.CreatePodSecurityPolicy(body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.CreatePodSecurityPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1beta1PodSecurityPolicy**](V1beta1PodSecurityPolicy.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodSecurityPolicy**](V1beta1PodSecurityPolicy.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createthirdpartyresource"></a>
# **CreateThirdPartyResource**
> V1beta1ThirdPartyResource CreateThirdPartyResource (V1beta1ThirdPartyResource body, string pretty = null)



create a ThirdPartyResource

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class CreateThirdPartyResourceExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var body = new V1beta1ThirdPartyResource(); // V1beta1ThirdPartyResource | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ThirdPartyResource result = apiInstance.CreateThirdPartyResource(body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.CreateThirdPartyResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1beta1ThirdPartyResource**](V1beta1ThirdPartyResource.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ThirdPartyResource**](V1beta1ThirdPartyResource.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollectionnamespaceddaemonset"></a>
# **DeleteCollectionNamespacedDaemonSet**
> V1Status DeleteCollectionNamespacedDaemonSet (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteCollectionNamespacedDaemonSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1Status result = apiInstance.DeleteCollectionNamespacedDaemonSet(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteCollectionNamespacedDaemonSet: " + e.Message );
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

<a name="deletecollectionnamespaceddeployment"></a>
# **DeleteCollectionNamespacedDeployment**
> V1Status DeleteCollectionNamespacedDeployment (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteCollectionNamespacedDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1Status result = apiInstance.DeleteCollectionNamespacedDeployment(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteCollectionNamespacedDeployment: " + e.Message );
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

<a name="deletecollectionnamespacedingress"></a>
# **DeleteCollectionNamespacedIngress**
> V1Status DeleteCollectionNamespacedIngress (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteCollectionNamespacedIngressExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1Status result = apiInstance.DeleteCollectionNamespacedIngress(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteCollectionNamespacedIngress: " + e.Message );
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

<a name="deletecollectionnamespacednetworkpolicy"></a>
# **DeleteCollectionNamespacedNetworkPolicy**
> V1Status DeleteCollectionNamespacedNetworkPolicy (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of NetworkPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteCollectionNamespacedNetworkPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1Status result = apiInstance.DeleteCollectionNamespacedNetworkPolicy(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteCollectionNamespacedNetworkPolicy: " + e.Message );
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

<a name="deletecollectionnamespacedreplicaset"></a>
# **DeleteCollectionNamespacedReplicaSet**
> V1Status DeleteCollectionNamespacedReplicaSet (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteCollectionNamespacedReplicaSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1Status result = apiInstance.DeleteCollectionNamespacedReplicaSet(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteCollectionNamespacedReplicaSet: " + e.Message );
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

<a name="deletecollectionpodsecuritypolicy"></a>
# **DeleteCollectionPodSecurityPolicy**
> V1Status DeleteCollectionPodSecurityPolicy (string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of PodSecurityPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteCollectionPodSecurityPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteCollectionPodSecurityPolicy(pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteCollectionPodSecurityPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="deletecollectionthirdpartyresource"></a>
# **DeleteCollectionThirdPartyResource**
> V1Status DeleteCollectionThirdPartyResource (string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of ThirdPartyResource

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteCollectionThirdPartyResourceExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteCollectionThirdPartyResource(pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteCollectionThirdPartyResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="deletenamespaceddaemonset"></a>
# **DeleteNamespacedDaemonSet**
> V1Status DeleteNamespacedDaemonSet (string name, string _namespace, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



delete a DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteNamespacedDaemonSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the DaemonSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteNamespacedDaemonSet(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteNamespacedDaemonSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the DaemonSet | 
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

<a name="deletenamespaceddeployment"></a>
# **DeleteNamespacedDeployment**
> V1Status DeleteNamespacedDeployment (string name, string _namespace, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



delete a Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteNamespacedDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Deployment
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteNamespacedDeployment(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteNamespacedDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Deployment | 
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

<a name="deletenamespacedingress"></a>
# **DeleteNamespacedIngress**
> V1Status DeleteNamespacedIngress (string name, string _namespace, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



delete an Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteNamespacedIngressExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Ingress
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteNamespacedIngress(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteNamespacedIngress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Ingress | 
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

<a name="deletenamespacednetworkpolicy"></a>
# **DeleteNamespacedNetworkPolicy**
> V1Status DeleteNamespacedNetworkPolicy (string name, string _namespace, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



delete a NetworkPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteNamespacedNetworkPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the NetworkPolicy
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteNamespacedNetworkPolicy(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteNamespacedNetworkPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the NetworkPolicy | 
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

<a name="deletenamespacedreplicaset"></a>
# **DeleteNamespacedReplicaSet**
> V1Status DeleteNamespacedReplicaSet (string name, string _namespace, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



delete a ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteNamespacedReplicaSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ReplicaSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteNamespacedReplicaSet(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteNamespacedReplicaSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ReplicaSet | 
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

<a name="deletepodsecuritypolicy"></a>
# **DeletePodSecurityPolicy**
> V1Status DeletePodSecurityPolicy (string name, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



delete a PodSecurityPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeletePodSecurityPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the PodSecurityPolicy
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                V1Status result = apiInstance.DeletePodSecurityPolicy(name, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeletePodSecurityPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodSecurityPolicy | 
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

<a name="deletethirdpartyresource"></a>
# **DeleteThirdPartyResource**
> V1Status DeleteThirdPartyResource (string name, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null)



delete a ThirdPartyResource

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class DeleteThirdPartyResourceExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ThirdPartyResource
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 

            try
            {
                V1Status result = apiInstance.DeleteThirdPartyResource(name, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.DeleteThirdPartyResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ThirdPartyResource | 
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

            var apiInstance = new Extensions_v1beta1Api();

            try
            {
                V1APIResourceList result = apiInstance.GetAPIResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.GetAPIResources: " + e.Message );
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

<a name="listdaemonsetforallnamespaces"></a>
# **ListDaemonSetForAllNamespaces**
> V1beta1DaemonSetList ListDaemonSetForAllNamespaces (string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string pretty = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListDaemonSetForAllNamespacesExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1beta1DaemonSetList result = apiInstance.ListDaemonSetForAllNamespaces(fieldSelector, includeUninitialized, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListDaemonSetForAllNamespaces: " + e.Message );
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

[**V1beta1DaemonSetList**](V1beta1DaemonSetList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdeploymentforallnamespaces"></a>
# **ListDeploymentForAllNamespaces**
> ExtensionsV1beta1DeploymentList ListDeploymentForAllNamespaces (string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string pretty = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListDeploymentForAllNamespacesExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                ExtensionsV1beta1DeploymentList result = apiInstance.ListDeploymentForAllNamespaces(fieldSelector, includeUninitialized, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListDeploymentForAllNamespaces: " + e.Message );
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

[**ExtensionsV1beta1DeploymentList**](ExtensionsV1beta1DeploymentList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingressforallnamespaces"></a>
# **ListIngressForAllNamespaces**
> V1beta1IngressList ListIngressForAllNamespaces (string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string pretty = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListIngressForAllNamespacesExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1beta1IngressList result = apiInstance.ListIngressForAllNamespaces(fieldSelector, includeUninitialized, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListIngressForAllNamespaces: " + e.Message );
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

[**V1beta1IngressList**](V1beta1IngressList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnamespaceddaemonset"></a>
# **ListNamespacedDaemonSet**
> V1beta1DaemonSetList ListNamespacedDaemonSet (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListNamespacedDaemonSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1beta1DaemonSetList result = apiInstance.ListNamespacedDaemonSet(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListNamespacedDaemonSet: " + e.Message );
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

[**V1beta1DaemonSetList**](V1beta1DaemonSetList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnamespaceddeployment"></a>
# **ListNamespacedDeployment**
> ExtensionsV1beta1DeploymentList ListNamespacedDeployment (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListNamespacedDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                ExtensionsV1beta1DeploymentList result = apiInstance.ListNamespacedDeployment(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListNamespacedDeployment: " + e.Message );
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

[**ExtensionsV1beta1DeploymentList**](ExtensionsV1beta1DeploymentList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnamespacedingress"></a>
# **ListNamespacedIngress**
> V1beta1IngressList ListNamespacedIngress (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListNamespacedIngressExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1beta1IngressList result = apiInstance.ListNamespacedIngress(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListNamespacedIngress: " + e.Message );
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

[**V1beta1IngressList**](V1beta1IngressList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnamespacednetworkpolicy"></a>
# **ListNamespacedNetworkPolicy**
> V1beta1NetworkPolicyList ListNamespacedNetworkPolicy (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind NetworkPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListNamespacedNetworkPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1beta1NetworkPolicyList result = apiInstance.ListNamespacedNetworkPolicy(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListNamespacedNetworkPolicy: " + e.Message );
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

[**V1beta1NetworkPolicyList**](V1beta1NetworkPolicyList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnamespacedreplicaset"></a>
# **ListNamespacedReplicaSet**
> V1beta1ReplicaSetList ListNamespacedReplicaSet (string _namespace, string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListNamespacedReplicaSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
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
                V1beta1ReplicaSetList result = apiInstance.ListNamespacedReplicaSet(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListNamespacedReplicaSet: " + e.Message );
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

[**V1beta1ReplicaSetList**](V1beta1ReplicaSetList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnetworkpolicyforallnamespaces"></a>
# **ListNetworkPolicyForAllNamespaces**
> V1beta1NetworkPolicyList ListNetworkPolicyForAllNamespaces (string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string pretty = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind NetworkPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListNetworkPolicyForAllNamespacesExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1beta1NetworkPolicyList result = apiInstance.ListNetworkPolicyForAllNamespaces(fieldSelector, includeUninitialized, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListNetworkPolicyForAllNamespaces: " + e.Message );
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

[**V1beta1NetworkPolicyList**](V1beta1NetworkPolicyList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpodsecuritypolicy"></a>
# **ListPodSecurityPolicy**
> V1beta1PodSecurityPolicyList ListPodSecurityPolicy (string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind PodSecurityPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListPodSecurityPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1beta1PodSecurityPolicyList result = apiInstance.ListPodSecurityPolicy(pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListPodSecurityPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **includeUninitialized** | **bool?**| If true, partially initialized resources are included in the response. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. | [optional] 

### Return type

[**V1beta1PodSecurityPolicyList**](V1beta1PodSecurityPolicyList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listreplicasetforallnamespaces"></a>
# **ListReplicaSetForAllNamespaces**
> V1beta1ReplicaSetList ListReplicaSetForAllNamespaces (string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string pretty = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListReplicaSetForAllNamespacesExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1beta1ReplicaSetList result = apiInstance.ListReplicaSetForAllNamespaces(fieldSelector, includeUninitialized, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListReplicaSetForAllNamespaces: " + e.Message );
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

[**V1beta1ReplicaSetList**](V1beta1ReplicaSetList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listthirdpartyresource"></a>
# **ListThirdPartyResource**
> V1beta1ThirdPartyResourceList ListThirdPartyResource (string pretty = null, string fieldSelector = null, bool? includeUninitialized = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind ThirdPartyResource

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ListThirdPartyResourceExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var includeUninitialized = true;  // bool? | If true, partially initialized resources are included in the response. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1beta1ThirdPartyResourceList result = apiInstance.ListThirdPartyResource(pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ListThirdPartyResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **includeUninitialized** | **bool?**| If true, partially initialized resources are included in the response. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. | [optional] 

### Return type

[**V1beta1ThirdPartyResourceList**](V1beta1ThirdPartyResourceList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespaceddaemonset"></a>
# **PatchNamespacedDaemonSet**
> V1beta1DaemonSet PatchNamespacedDaemonSet (string name, string _namespace, Object body, string pretty = null)



partially update the specified DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedDaemonSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the DaemonSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1DaemonSet result = apiInstance.PatchNamespacedDaemonSet(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedDaemonSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the DaemonSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1DaemonSet**](V1beta1DaemonSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespaceddaemonsetstatus"></a>
# **PatchNamespacedDaemonSetStatus**
> V1beta1DaemonSet PatchNamespacedDaemonSetStatus (string name, string _namespace, Object body, string pretty = null)



partially update status of the specified DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedDaemonSetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the DaemonSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1DaemonSet result = apiInstance.PatchNamespacedDaemonSetStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedDaemonSetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the DaemonSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1DaemonSet**](V1beta1DaemonSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespaceddeployment"></a>
# **PatchNamespacedDeployment**
> ExtensionsV1beta1Deployment PatchNamespacedDeployment (string name, string _namespace, Object body, string pretty = null)



partially update the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Deployment
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Deployment result = apiInstance.PatchNamespacedDeployment(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Deployment | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespaceddeploymentscale"></a>
# **PatchNamespacedDeploymentScale**
> ExtensionsV1beta1Scale PatchNamespacedDeploymentScale (string name, string _namespace, Object body, string pretty = null)



partially update scale of the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedDeploymentScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.PatchNamespacedDeploymentScale(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedDeploymentScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespaceddeploymentstatus"></a>
# **PatchNamespacedDeploymentStatus**
> ExtensionsV1beta1Deployment PatchNamespacedDeploymentStatus (string name, string _namespace, Object body, string pretty = null)



partially update status of the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedDeploymentStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Deployment
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Deployment result = apiInstance.PatchNamespacedDeploymentStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedDeploymentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Deployment | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedingress"></a>
# **PatchNamespacedIngress**
> V1beta1Ingress PatchNamespacedIngress (string name, string _namespace, Object body, string pretty = null)



partially update the specified Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedIngressExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Ingress
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1Ingress result = apiInstance.PatchNamespacedIngress(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedIngress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Ingress | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1Ingress**](V1beta1Ingress.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedingressstatus"></a>
# **PatchNamespacedIngressStatus**
> V1beta1Ingress PatchNamespacedIngressStatus (string name, string _namespace, Object body, string pretty = null)



partially update status of the specified Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedIngressStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Ingress
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1Ingress result = apiInstance.PatchNamespacedIngressStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedIngressStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Ingress | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1Ingress**](V1beta1Ingress.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacednetworkpolicy"></a>
# **PatchNamespacedNetworkPolicy**
> V1beta1NetworkPolicy PatchNamespacedNetworkPolicy (string name, string _namespace, Object body, string pretty = null)



partially update the specified NetworkPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedNetworkPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the NetworkPolicy
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1NetworkPolicy result = apiInstance.PatchNamespacedNetworkPolicy(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedNetworkPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the NetworkPolicy | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1NetworkPolicy**](V1beta1NetworkPolicy.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedreplicaset"></a>
# **PatchNamespacedReplicaSet**
> V1beta1ReplicaSet PatchNamespacedReplicaSet (string name, string _namespace, Object body, string pretty = null)



partially update the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedReplicaSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ReplicaSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ReplicaSet result = apiInstance.PatchNamespacedReplicaSet(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedReplicaSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ReplicaSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedreplicasetscale"></a>
# **PatchNamespacedReplicaSetScale**
> ExtensionsV1beta1Scale PatchNamespacedReplicaSetScale (string name, string _namespace, Object body, string pretty = null)



partially update scale of the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedReplicaSetScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.PatchNamespacedReplicaSetScale(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedReplicaSetScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedreplicasetstatus"></a>
# **PatchNamespacedReplicaSetStatus**
> V1beta1ReplicaSet PatchNamespacedReplicaSetStatus (string name, string _namespace, Object body, string pretty = null)



partially update status of the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedReplicaSetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ReplicaSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ReplicaSet result = apiInstance.PatchNamespacedReplicaSetStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedReplicaSetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ReplicaSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedreplicationcontrollerdummyscale"></a>
# **PatchNamespacedReplicationControllerDummyScale**
> ExtensionsV1beta1Scale PatchNamespacedReplicationControllerDummyScale (string name, string _namespace, Object body, string pretty = null)



partially update scale of the specified ReplicationControllerDummy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchNamespacedReplicationControllerDummyScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.PatchNamespacedReplicationControllerDummyScale(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchNamespacedReplicationControllerDummyScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpodsecuritypolicy"></a>
# **PatchPodSecurityPolicy**
> V1beta1PodSecurityPolicy PatchPodSecurityPolicy (string name, Object body, string pretty = null)



partially update the specified PodSecurityPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchPodSecurityPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the PodSecurityPolicy
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodSecurityPolicy result = apiInstance.PatchPodSecurityPolicy(name, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchPodSecurityPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodSecurityPolicy | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodSecurityPolicy**](V1beta1PodSecurityPolicy.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchthirdpartyresource"></a>
# **PatchThirdPartyResource**
> V1beta1ThirdPartyResource PatchThirdPartyResource (string name, Object body, string pretty = null)



partially update the specified ThirdPartyResource

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class PatchThirdPartyResourceExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ThirdPartyResource
            var body = ;  // Object | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ThirdPartyResource result = apiInstance.PatchThirdPartyResource(name, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.PatchThirdPartyResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ThirdPartyResource | 
 **body** | **Object**|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ThirdPartyResource**](V1beta1ThirdPartyResource.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespaceddaemonset"></a>
# **ReadNamespacedDaemonSet**
> V1beta1DaemonSet ReadNamespacedDaemonSet (string name, string _namespace, string pretty = null, bool? exact = null, bool? export = null)



read the specified DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedDaemonSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the DaemonSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace'. (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1beta1DaemonSet result = apiInstance.ReadNamespacedDaemonSet(name, _namespace, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedDaemonSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the DaemonSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;. | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1beta1DaemonSet**](V1beta1DaemonSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespaceddaemonsetstatus"></a>
# **ReadNamespacedDaemonSetStatus**
> V1beta1DaemonSet ReadNamespacedDaemonSetStatus (string name, string _namespace, string pretty = null)



read status of the specified DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedDaemonSetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the DaemonSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1DaemonSet result = apiInstance.ReadNamespacedDaemonSetStatus(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedDaemonSetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the DaemonSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1DaemonSet**](V1beta1DaemonSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespaceddeployment"></a>
# **ReadNamespacedDeployment**
> ExtensionsV1beta1Deployment ReadNamespacedDeployment (string name, string _namespace, string pretty = null, bool? exact = null, bool? export = null)



read the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Deployment
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace'. (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                ExtensionsV1beta1Deployment result = apiInstance.ReadNamespacedDeployment(name, _namespace, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Deployment | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;. | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespaceddeploymentscale"></a>
# **ReadNamespacedDeploymentScale**
> ExtensionsV1beta1Scale ReadNamespacedDeploymentScale (string name, string _namespace, string pretty = null)



read scale of the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedDeploymentScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.ReadNamespacedDeploymentScale(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedDeploymentScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespaceddeploymentstatus"></a>
# **ReadNamespacedDeploymentStatus**
> ExtensionsV1beta1Deployment ReadNamespacedDeploymentStatus (string name, string _namespace, string pretty = null)



read status of the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedDeploymentStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Deployment
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Deployment result = apiInstance.ReadNamespacedDeploymentStatus(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedDeploymentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Deployment | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedingress"></a>
# **ReadNamespacedIngress**
> V1beta1Ingress ReadNamespacedIngress (string name, string _namespace, string pretty = null, bool? exact = null, bool? export = null)



read the specified Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedIngressExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Ingress
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace'. (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1beta1Ingress result = apiInstance.ReadNamespacedIngress(name, _namespace, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedIngress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Ingress | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;. | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1beta1Ingress**](V1beta1Ingress.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedingressstatus"></a>
# **ReadNamespacedIngressStatus**
> V1beta1Ingress ReadNamespacedIngressStatus (string name, string _namespace, string pretty = null)



read status of the specified Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedIngressStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Ingress
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1Ingress result = apiInstance.ReadNamespacedIngressStatus(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedIngressStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Ingress | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1Ingress**](V1beta1Ingress.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacednetworkpolicy"></a>
# **ReadNamespacedNetworkPolicy**
> V1beta1NetworkPolicy ReadNamespacedNetworkPolicy (string name, string _namespace, string pretty = null, bool? exact = null, bool? export = null)



read the specified NetworkPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedNetworkPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the NetworkPolicy
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace'. (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1beta1NetworkPolicy result = apiInstance.ReadNamespacedNetworkPolicy(name, _namespace, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedNetworkPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the NetworkPolicy | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;. | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1beta1NetworkPolicy**](V1beta1NetworkPolicy.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedreplicaset"></a>
# **ReadNamespacedReplicaSet**
> V1beta1ReplicaSet ReadNamespacedReplicaSet (string name, string _namespace, string pretty = null, bool? exact = null, bool? export = null)



read the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedReplicaSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ReplicaSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace'. (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1beta1ReplicaSet result = apiInstance.ReadNamespacedReplicaSet(name, _namespace, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedReplicaSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ReplicaSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;. | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedreplicasetscale"></a>
# **ReadNamespacedReplicaSetScale**
> ExtensionsV1beta1Scale ReadNamespacedReplicaSetScale (string name, string _namespace, string pretty = null)



read scale of the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedReplicaSetScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.ReadNamespacedReplicaSetScale(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedReplicaSetScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedreplicasetstatus"></a>
# **ReadNamespacedReplicaSetStatus**
> V1beta1ReplicaSet ReadNamespacedReplicaSetStatus (string name, string _namespace, string pretty = null)



read status of the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedReplicaSetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ReplicaSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ReplicaSet result = apiInstance.ReadNamespacedReplicaSetStatus(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedReplicaSetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ReplicaSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedreplicationcontrollerdummyscale"></a>
# **ReadNamespacedReplicationControllerDummyScale**
> ExtensionsV1beta1Scale ReadNamespacedReplicationControllerDummyScale (string name, string _namespace, string pretty = null)



read scale of the specified ReplicationControllerDummy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadNamespacedReplicationControllerDummyScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.ReadNamespacedReplicationControllerDummyScale(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadNamespacedReplicationControllerDummyScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpodsecuritypolicy"></a>
# **ReadPodSecurityPolicy**
> V1beta1PodSecurityPolicy ReadPodSecurityPolicy (string name, string pretty = null, bool? exact = null, bool? export = null)



read the specified PodSecurityPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadPodSecurityPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the PodSecurityPolicy
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace'. (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1beta1PodSecurityPolicy result = apiInstance.ReadPodSecurityPolicy(name, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadPodSecurityPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodSecurityPolicy | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;. | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1beta1PodSecurityPolicy**](V1beta1PodSecurityPolicy.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readthirdpartyresource"></a>
# **ReadThirdPartyResource**
> V1beta1ThirdPartyResource ReadThirdPartyResource (string name, string pretty = null, bool? exact = null, bool? export = null)



read the specified ThirdPartyResource

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReadThirdPartyResourceExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ThirdPartyResource
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace'. (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1beta1ThirdPartyResource result = apiInstance.ReadThirdPartyResource(name, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReadThirdPartyResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ThirdPartyResource | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;. | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1beta1ThirdPartyResource**](V1beta1ThirdPartyResource.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespaceddaemonset"></a>
# **ReplaceNamespacedDaemonSet**
> V1beta1DaemonSet ReplaceNamespacedDaemonSet (string name, string _namespace, V1beta1DaemonSet body, string pretty = null)



replace the specified DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedDaemonSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the DaemonSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1DaemonSet(); // V1beta1DaemonSet | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1DaemonSet result = apiInstance.ReplaceNamespacedDaemonSet(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedDaemonSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the DaemonSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1DaemonSet**](V1beta1DaemonSet.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1DaemonSet**](V1beta1DaemonSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespaceddaemonsetstatus"></a>
# **ReplaceNamespacedDaemonSetStatus**
> V1beta1DaemonSet ReplaceNamespacedDaemonSetStatus (string name, string _namespace, V1beta1DaemonSet body, string pretty = null)



replace status of the specified DaemonSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedDaemonSetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the DaemonSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1DaemonSet(); // V1beta1DaemonSet | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1DaemonSet result = apiInstance.ReplaceNamespacedDaemonSetStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedDaemonSetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the DaemonSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1DaemonSet**](V1beta1DaemonSet.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1DaemonSet**](V1beta1DaemonSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespaceddeployment"></a>
# **ReplaceNamespacedDeployment**
> ExtensionsV1beta1Deployment ReplaceNamespacedDeployment (string name, string _namespace, ExtensionsV1beta1Deployment body, string pretty = null)



replace the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Deployment
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new ExtensionsV1beta1Deployment(); // ExtensionsV1beta1Deployment | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Deployment result = apiInstance.ReplaceNamespacedDeployment(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Deployment | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespaceddeploymentscale"></a>
# **ReplaceNamespacedDeploymentScale**
> ExtensionsV1beta1Scale ReplaceNamespacedDeploymentScale (string name, string _namespace, ExtensionsV1beta1Scale body, string pretty = null)



replace scale of the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedDeploymentScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new ExtensionsV1beta1Scale(); // ExtensionsV1beta1Scale | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.ReplaceNamespacedDeploymentScale(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedDeploymentScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespaceddeploymentstatus"></a>
# **ReplaceNamespacedDeploymentStatus**
> ExtensionsV1beta1Deployment ReplaceNamespacedDeploymentStatus (string name, string _namespace, ExtensionsV1beta1Deployment body, string pretty = null)



replace status of the specified Deployment

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedDeploymentStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Deployment
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new ExtensionsV1beta1Deployment(); // ExtensionsV1beta1Deployment | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Deployment result = apiInstance.ReplaceNamespacedDeploymentStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedDeploymentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Deployment | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Deployment**](ExtensionsV1beta1Deployment.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedingress"></a>
# **ReplaceNamespacedIngress**
> V1beta1Ingress ReplaceNamespacedIngress (string name, string _namespace, V1beta1Ingress body, string pretty = null)



replace the specified Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedIngressExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Ingress
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1Ingress(); // V1beta1Ingress | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1Ingress result = apiInstance.ReplaceNamespacedIngress(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedIngress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Ingress | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1Ingress**](V1beta1Ingress.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1Ingress**](V1beta1Ingress.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedingressstatus"></a>
# **ReplaceNamespacedIngressStatus**
> V1beta1Ingress ReplaceNamespacedIngressStatus (string name, string _namespace, V1beta1Ingress body, string pretty = null)



replace status of the specified Ingress

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedIngressStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Ingress
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1Ingress(); // V1beta1Ingress | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1Ingress result = apiInstance.ReplaceNamespacedIngressStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedIngressStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Ingress | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1Ingress**](V1beta1Ingress.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1Ingress**](V1beta1Ingress.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacednetworkpolicy"></a>
# **ReplaceNamespacedNetworkPolicy**
> V1beta1NetworkPolicy ReplaceNamespacedNetworkPolicy (string name, string _namespace, V1beta1NetworkPolicy body, string pretty = null)



replace the specified NetworkPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedNetworkPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the NetworkPolicy
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1NetworkPolicy(); // V1beta1NetworkPolicy | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1NetworkPolicy result = apiInstance.ReplaceNamespacedNetworkPolicy(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedNetworkPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the NetworkPolicy | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1NetworkPolicy**](V1beta1NetworkPolicy.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1NetworkPolicy**](V1beta1NetworkPolicy.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedreplicaset"></a>
# **ReplaceNamespacedReplicaSet**
> V1beta1ReplicaSet ReplaceNamespacedReplicaSet (string name, string _namespace, V1beta1ReplicaSet body, string pretty = null)



replace the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedReplicaSetExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ReplicaSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1ReplicaSet(); // V1beta1ReplicaSet | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ReplicaSet result = apiInstance.ReplaceNamespacedReplicaSet(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedReplicaSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ReplicaSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedreplicasetscale"></a>
# **ReplaceNamespacedReplicaSetScale**
> ExtensionsV1beta1Scale ReplaceNamespacedReplicaSetScale (string name, string _namespace, ExtensionsV1beta1Scale body, string pretty = null)



replace scale of the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedReplicaSetScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new ExtensionsV1beta1Scale(); // ExtensionsV1beta1Scale | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.ReplaceNamespacedReplicaSetScale(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedReplicaSetScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedreplicasetstatus"></a>
# **ReplaceNamespacedReplicaSetStatus**
> V1beta1ReplicaSet ReplaceNamespacedReplicaSetStatus (string name, string _namespace, V1beta1ReplicaSet body, string pretty = null)



replace status of the specified ReplicaSet

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedReplicaSetStatusExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ReplicaSet
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1beta1ReplicaSet(); // V1beta1ReplicaSet | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ReplicaSet result = apiInstance.ReplaceNamespacedReplicaSetStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedReplicaSetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ReplicaSet | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ReplicaSet**](V1beta1ReplicaSet.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedreplicationcontrollerdummyscale"></a>
# **ReplaceNamespacedReplicationControllerDummyScale**
> ExtensionsV1beta1Scale ReplaceNamespacedReplicationControllerDummyScale (string name, string _namespace, ExtensionsV1beta1Scale body, string pretty = null)



replace scale of the specified ReplicationControllerDummy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceNamespacedReplicationControllerDummyScaleExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the Scale
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new ExtensionsV1beta1Scale(); // ExtensionsV1beta1Scale | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                ExtensionsV1beta1Scale result = apiInstance.ReplaceNamespacedReplicationControllerDummyScale(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceNamespacedReplicationControllerDummyScale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Scale | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**ExtensionsV1beta1Scale**](ExtensionsV1beta1Scale.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacepodsecuritypolicy"></a>
# **ReplacePodSecurityPolicy**
> V1beta1PodSecurityPolicy ReplacePodSecurityPolicy (string name, V1beta1PodSecurityPolicy body, string pretty = null)



replace the specified PodSecurityPolicy

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplacePodSecurityPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the PodSecurityPolicy
            var body = new V1beta1PodSecurityPolicy(); // V1beta1PodSecurityPolicy | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1PodSecurityPolicy result = apiInstance.ReplacePodSecurityPolicy(name, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplacePodSecurityPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the PodSecurityPolicy | 
 **body** | [**V1beta1PodSecurityPolicy**](V1beta1PodSecurityPolicy.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1PodSecurityPolicy**](V1beta1PodSecurityPolicy.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacethirdpartyresource"></a>
# **ReplaceThirdPartyResource**
> V1beta1ThirdPartyResource ReplaceThirdPartyResource (string name, V1beta1ThirdPartyResource body, string pretty = null)



replace the specified ThirdPartyResource

### Example
```csharp
using System;
using System.Diagnostics;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Example
{
    public class ReplaceThirdPartyResourceExample
    {
        public void main()
        {
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new Extensions_v1beta1Api();
            var name = name_example;  // string | name of the ThirdPartyResource
            var body = new V1beta1ThirdPartyResource(); // V1beta1ThirdPartyResource | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1ThirdPartyResource result = apiInstance.ReplaceThirdPartyResource(name, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Extensions_v1beta1Api.ReplaceThirdPartyResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the ThirdPartyResource | 
 **body** | [**V1beta1ThirdPartyResource**](V1beta1ThirdPartyResource.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1ThirdPartyResource**](V1beta1ThirdPartyResource.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

