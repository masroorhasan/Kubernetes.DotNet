# Kubernetes.DotNet.Model.V1LimitRangeItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_Default** | **Dictionary&lt;string, string&gt;** | Default resource requirement limit value by resource name if resource limit is omitted. | [optional] 
**DefaultRequest** | **Dictionary&lt;string, string&gt;** | DefaultRequest is the default resource requirement request value by resource name if resource request is omitted. | [optional] 
**Max** | **Dictionary&lt;string, string&gt;** | Max usage constraints on this kind by resource name. | [optional] 
**MaxLimitRequestRatio** | **Dictionary&lt;string, string&gt;** | MaxLimitRequestRatio if specified, the named resource must have a request and limit that are both non-zero where limit divided by request is less than or equal to the enumerated value; this represents the max burst for the named resource. | [optional] 
**Min** | **Dictionary&lt;string, string&gt;** | Min usage constraints on this kind by resource name. | [optional] 
**Type** | **string** | Type of resource that this limit applies to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

