# Kubernetes.DotNet.Model.V1PodStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Conditions** | [**List&lt;V1PodCondition&gt;**](V1PodCondition.md) | Current service state of pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions | [optional] 
**ContainerStatuses** | [**List&lt;V1ContainerStatus&gt;**](V1ContainerStatus.md) | The list has one entry per container in the manifest. Each entry is currently the output of &#x60;docker inspect&#x60;. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status | [optional] 
**HostIP** | **string** | IP address of the host to which the pod is assigned. Empty if not yet scheduled. | [optional] 
**InitContainerStatuses** | [**List&lt;V1ContainerStatus&gt;**](V1ContainerStatus.md) | The list has one entry per init container in the manifest. The most recent successful init container will have ready &#x3D; true, the most recently started container will have startTime set. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status | [optional] 
**Message** | **string** | A human readable message indicating details about why the pod is in this condition. | [optional] 
**Phase** | **string** | Current condition of the pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase | [optional] 
**PodIP** | **string** | IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated. | [optional] 
**QosClass** | **string** | The Quality of Service (QOS) classification assigned to the pod based on resource requirements See PodQOSClass type for available QOS classes More info: https://github.com/kubernetes/kubernetes/blob/master/docs/design/resource-qos.md | [optional] 
**Reason** | **string** | A brief CamelCase message indicating details about why the pod is in this state. e.g. &#39;OutOfDisk&#39; | [optional] 
**StartTime** | **DateTime?** | RFC 3339 date and time at which the object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

