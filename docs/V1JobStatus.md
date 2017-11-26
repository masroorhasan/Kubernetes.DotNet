# Kubernetes.DotNet.Model.V1JobStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **int?** | The number of actively running pods. | [optional] 
**CompletionTime** | **DateTime?** | Represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC. | [optional] 
**Conditions** | [**List&lt;V1JobCondition&gt;**](V1JobCondition.md) | The latest available observations of an object&#39;s current state. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/ | [optional] 
**Failed** | **int?** | The number of pods which reached phase Failed. | [optional] 
**StartTime** | **DateTime?** | Represents time when the job was acknowledged by the job controller. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC. | [optional] 
**Succeeded** | **int?** | The number of pods which reached phase Succeeded. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

