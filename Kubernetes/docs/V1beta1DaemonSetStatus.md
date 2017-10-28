# Kubernetes.DotNet.Model.V1beta1DaemonSetStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollisionCount** | **long?** | Count of hash collisions for the DaemonSet. The DaemonSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision. | [optional] 
**CurrentNumberScheduled** | **int?** | The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/ | 
**DesiredNumberScheduled** | **int?** | The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/ | 
**NumberAvailable** | **int?** | The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds) | [optional] 
**NumberMisscheduled** | **int?** | The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/ | 
**NumberReady** | **int?** | The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready. | 
**NumberUnavailable** | **int?** | The number of nodes that should be running the daemon pod and have none of the daemon pod running and available (ready for at least spec.minReadySeconds) | [optional] 
**ObservedGeneration** | **long?** | The most recent generation observed by the daemon set controller. | [optional] 
**UpdatedNumberScheduled** | **int?** | The total number of nodes that are running updated daemon pod | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

