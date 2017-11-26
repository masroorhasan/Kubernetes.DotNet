# Kubernetes.DotNet.Model.V1LabelSelectorRequirement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | key is the label key that the selector applies to. | 
**_Operator** | **string** | operator represents a key&#39;s relationship to a set of values. Valid operators ard In, NotIn, Exists and DoesNotExist. | 
**Values** | **List&lt;string&gt;** | values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

