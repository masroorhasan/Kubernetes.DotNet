# Kubernetes.DotNet.Model.V1beta1StatefulSetStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentReplicas** | **int?** | currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision. | [optional] 
**CurrentRevision** | **string** | currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas). | [optional] 
**ObservedGeneration** | **long?** | observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet&#39;s generation, which is updated on mutation by the API Server. | [optional] 
**ReadyReplicas** | **int?** | readyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition. | [optional] 
**Replicas** | **int?** | replicas is the number of Pods created by the StatefulSet controller. | 
**UpdateRevision** | **string** | updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas) | [optional] 
**UpdatedReplicas** | **int?** | updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

