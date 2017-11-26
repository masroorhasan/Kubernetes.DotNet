# Kubernetes.DotNet.Model.V1beta1FSGroupStrategyOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ranges** | [**List&lt;V1beta1IDRange&gt;**](V1beta1IDRange.md) | Ranges are the allowed ranges of fs groups.  If you would like to force a single fs group then supply a single range with the same start and end. | [optional] 
**Rule** | **string** | Rule is the strategy that will dictate what FSGroup is used in the SecurityContext. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

