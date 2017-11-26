# Kubernetes.DotNet.Model.V1PodCondition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastProbeTime** | **DateTime?** | Last time we probed the condition. | [optional] 
**LastTransitionTime** | **DateTime?** | Last time the condition transitioned from one status to another. | [optional] 
**Message** | **string** | Human-readable message indicating details about last transition. | [optional] 
**Reason** | **string** | Unique, one-word, CamelCase reason for the condition&#39;s last transition. | [optional] 
**Status** | **string** | Status is the status of the condition. Can be True, False, Unknown. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions | 
**Type** | **string** | Type is the type of the condition. Currently only Ready. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

