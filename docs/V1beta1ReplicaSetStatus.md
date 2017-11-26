# Kubernetes.DotNet.Model.V1beta1ReplicaSetStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AvailableReplicas** | **int?** | The number of available replicas (ready for at least minReadySeconds) for this replica set. | [optional] 
**Conditions** | [**List&lt;V1beta1ReplicaSetCondition&gt;**](V1beta1ReplicaSetCondition.md) | Represents the latest available observations of a replica set&#39;s current state. | [optional] 
**FullyLabeledReplicas** | **int?** | The number of pods that have labels matching the labels of the pod template of the replicaset. | [optional] 
**ObservedGeneration** | **long?** | ObservedGeneration reflects the generation of the most recently observed ReplicaSet. | [optional] 
**ReadyReplicas** | **int?** | The number of ready replicas for this replica set. | [optional] 
**Replicas** | **int?** | Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

