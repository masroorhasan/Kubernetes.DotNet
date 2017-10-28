# Kubernetes.DotNet.Model.V1APIResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Categories** | **List&lt;string&gt;** | categories is a list of the grouped resources this resource belongs to (e.g. &#39;all&#39;) | [optional] 
**Kind** | **string** | kind is the kind for the resource (e.g. &#39;Foo&#39; is the kind for a resource &#39;foo&#39;) | 
**Name** | **string** | name is the plural name of the resource. | 
**Namespaced** | **bool?** | namespaced indicates if a resource is namespaced or not. | 
**ShortNames** | **List&lt;string&gt;** | shortNames is a list of suggested short names of the resource. | [optional] 
**SingularName** | **string** | singularName is the singular name of the resource.  This allows clients to handle plural and singular opaquely. The singularName is more correct for reporting status on a single item and both singular and plural are allowed from the kubectl CLI interface. | 
**Verbs** | **List&lt;string&gt;** | verbs is a list of supported kube verbs (this includes get, list, watch, create, update, patch, delete, deletecollection, and proxy) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

