# Kubernetes.DotNet.Model.V1GitRepoVolumeSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Directory** | **string** | Target directory name. Must not contain or start with &#39;..&#39;.  If &#39;.&#39; is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name. | [optional] 
**Repository** | **string** | Repository URL | 
**Revision** | **string** | Commit hash for the specified revision. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

