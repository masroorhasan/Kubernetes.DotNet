# Kubernetes.DotNet.Model.V1beta1CertificateSigningRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **string** | APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources | [optional] 
**Kind** | **string** | Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds | [optional] 
**Metadata** | [**V1ObjectMeta**](V1ObjectMeta.md) |  | [optional] 
**Spec** | [**V1beta1CertificateSigningRequestSpec**](V1beta1CertificateSigningRequestSpec.md) | The certificate request itself and any additional information. | [optional] 
**Status** | [**V1beta1CertificateSigningRequestStatus**](V1beta1CertificateSigningRequestStatus.md) | Derived information about the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

