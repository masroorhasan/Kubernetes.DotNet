# Kubernetes.DotNet.Model.V1ContainerStateTerminated
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerID** | **string** | Container&#39;s ID in the format &#39;docker://&lt;container_id&gt;&#39; | [optional] 
**ExitCode** | **int?** | Exit status from the last termination of the container | 
**FinishedAt** | **DateTime?** | Time at which the container last terminated | [optional] 
**Message** | **string** | Message regarding the last termination of the container | [optional] 
**Reason** | **string** | (brief) reason from the last termination of the container | [optional] 
**Signal** | **int?** | Signal from the last termination of the container | [optional] 
**StartedAt** | **DateTime?** | Time at which previous execution of the container started | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

