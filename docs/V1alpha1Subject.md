# Kubernetes.DotNet.Model.V1alpha1Subject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **string** | APIVersion holds the API group and version of the referenced subject. Defaults to \&quot;v1\&quot; for ServiceAccount subjects. Defaults to \&quot;rbac.authorization.k8s.io/v1alpha1\&quot; for User and Group subjects. | [optional] 
**Kind** | **string** | Kind of object being referenced. Values defined by this API group are \&quot;User\&quot;, \&quot;Group\&quot;, and \&quot;ServiceAccount\&quot;. If the Authorizer does not recognized the kind value, the Authorizer should report an error. | 
**Name** | **string** | Name of the object being referenced. | 
**_Namespace** | **string** | Namespace of the referenced object.  If the object kind is non-namespace, such as \&quot;User\&quot; or \&quot;Group\&quot;, and this value is not empty the Authorizer should report an error. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

