# Kubernetes.DotNet.Model.V1alpha1RuleWithOperations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiGroups** | **List&lt;string&gt;** | APIGroups is the API groups the resources belong to. &#39;*&#39; is all groups. If &#39;*&#39; is present, the length of the slice must be one. Required. | [optional] 
**ApiVersions** | **List&lt;string&gt;** | APIVersions is the API versions the resources belong to. &#39;*&#39; is all versions. If &#39;*&#39; is present, the length of the slice must be one. Required. | [optional] 
**Operations** | **List&lt;string&gt;** | Operations is the operations the admission hook cares about - CREATE, UPDATE, or * for all operations. If &#39;*&#39; is present, the length of the slice must be one. Required. | [optional] 
**Resources** | **List&lt;string&gt;** | Resources is a list of resources this rule applies to.  For example: &#39;pods&#39; means pods. &#39;pods/log&#39; means the log subresource of pods. &#39;*&#39; means all resources, but not subresources. &#39;pods/_*&#39; means all subresources of pods. &#39;*_/scale&#39; means all scale subresources. &#39;*_/_*&#39; means all resources and their subresources.  If wildcard is present, the validation rule will ensure resources do not overlap with each other.  Depending on the enclosing object, subresources might not be allowed. Required. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

