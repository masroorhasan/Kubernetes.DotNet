# Kubernetes.DotNet.Model.V1beta1PodDisruptionBudget
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **string** | APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources | [optional] 
**Kind** | **string** | Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds | [optional] 
**Metadata** | [**V1ObjectMeta**](V1ObjectMeta.md) |  | [optional] 
**Spec** | [**V1beta1PodDisruptionBudgetSpec**](V1beta1PodDisruptionBudgetSpec.md) | Specification of the desired behavior of the PodDisruptionBudget. | [optional] 
**Status** | [**V1beta1PodDisruptionBudgetStatus**](V1beta1PodDisruptionBudgetStatus.md) | Most recently observed status of the PodDisruptionBudget. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

