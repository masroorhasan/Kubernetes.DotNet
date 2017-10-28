# Kubernetes.DotNet.Model.AppsV1beta1DeploymentStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AvailableReplicas** | **int?** | Total number of available pods (ready for at least minReadySeconds) targeted by this deployment. | [optional] 
**CollisionCount** | **long?** | Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet. | [optional] 
**Conditions** | [**List&lt;AppsV1beta1DeploymentCondition&gt;**](AppsV1beta1DeploymentCondition.md) | Represents the latest available observations of a deployment&#39;s current state. | [optional] 
**ObservedGeneration** | **long?** | The generation observed by the deployment controller. | [optional] 
**ReadyReplicas** | **int?** | Total number of ready pods targeted by this deployment. | [optional] 
**Replicas** | **int?** | Total number of non-terminated pods targeted by this deployment (their labels match the selector). | [optional] 
**UnavailableReplicas** | **int?** | Total number of unavailable pods targeted by this deployment. | [optional] 
**UpdatedReplicas** | **int?** | Total number of non-terminated pods targeted by this deployment that have the desired template spec. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

