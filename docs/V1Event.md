# Kubernetes.DotNet.Model.V1Event
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **string** | APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources | [optional] 
**Count** | **int?** | The number of times this event has occurred. | [optional] 
**FirstTimestamp** | **DateTime?** | The time at which the event was first recorded. (Time of server receipt is in TypeMeta.) | [optional] 
**InvolvedObject** | [**V1ObjectReference**](V1ObjectReference.md) | The object that this event is about. | 
**Kind** | **string** | Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds | [optional] 
**LastTimestamp** | **DateTime?** | The time at which the most recent occurrence of this event was recorded. | [optional] 
**Message** | **string** | A human-readable description of the status of this operation. | [optional] 
**Metadata** | [**V1ObjectMeta**](V1ObjectMeta.md) | Standard object&#39;s metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata | 
**Reason** | **string** | This should be a short, machine understandable string that gives the reason for the transition into the object&#39;s current status. | [optional] 
**Source** | [**V1EventSource**](V1EventSource.md) | The component reporting this event. Should be a short machine understandable string. | [optional] 
**Type** | **string** | Type of this event (Normal, Warning), new types could be added in the future | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

