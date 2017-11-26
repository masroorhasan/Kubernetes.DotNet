# Kubernetes.DotNet.Model.V1Initializers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pending** | [**List&lt;V1Initializer&gt;**](V1Initializer.md) | Pending is a list of initializers that must execute in order before this object is visible. When the last pending initializer is removed, and no failing result is set, the initializers struct will be set to nil and the object is considered as initialized and visible to all clients. | 
**Result** | [**V1Status**](V1Status.md) | If result is set with the Failure field, the object will be persisted to storage and then deleted, ensuring that other clients can observe the deletion. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

