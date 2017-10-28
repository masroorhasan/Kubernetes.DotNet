# Kubernetes.DotNet.Model.V2alpha1HorizontalPodAutoscalerStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Conditions** | [**List&lt;V2alpha1HorizontalPodAutoscalerCondition&gt;**](V2alpha1HorizontalPodAutoscalerCondition.md) | conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met. | 
**CurrentMetrics** | [**List&lt;V2alpha1MetricStatus&gt;**](V2alpha1MetricStatus.md) | currentMetrics is the last read state of the metrics used by this autoscaler. | 
**CurrentReplicas** | **int?** | currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler. | 
**DesiredReplicas** | **int?** | desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler. | 
**LastScaleTime** | **DateTime?** | lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed. | [optional] 
**ObservedGeneration** | **long?** | observedGeneration is the most recent generation observed by this autoscaler. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

