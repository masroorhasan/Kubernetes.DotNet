# Kubernetes.DotNet.Model.V1alpha1PodPresetSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Env** | [**List&lt;V1EnvVar&gt;**](V1EnvVar.md) | Env defines the collection of EnvVar to inject into containers. | [optional] 
**EnvFrom** | [**List&lt;V1EnvFromSource&gt;**](V1EnvFromSource.md) | EnvFrom defines the collection of EnvFromSource to inject into containers. | [optional] 
**Selector** | [**V1LabelSelector**](V1LabelSelector.md) | Selector is a label query over a set of resources, in this case pods. Required. | [optional] 
**VolumeMounts** | [**List&lt;V1VolumeMount&gt;**](V1VolumeMount.md) | VolumeMounts defines the collection of VolumeMount to inject into containers. | [optional] 
**Volumes** | [**List&lt;V1Volume&gt;**](V1Volume.md) | Volumes defines the collection of Volume to inject into the pod. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

