# Kubernetes.DotNet.Model.V1beta1CertificateSigningRequestSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Extra** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Extra information about the requesting user. See user.Info interface for details. | [optional] 
**Groups** | **List&lt;string&gt;** | Group information about the requesting user. See user.Info interface for details. | [optional] 
**Request** | **byte[]** | Base64-encoded PKCS#10 CSR data | 
**Uid** | **string** | UID information about the requesting user. See user.Info interface for details. | [optional] 
**Usages** | **List&lt;string&gt;** | allowedUsages specifies a set of usage contexts the key will be valid for. See: https://tools.ietf.org/html/rfc5280#section-4.2.1.3      https://tools.ietf.org/html/rfc5280#section-4.2.1.12 | [optional] 
**Username** | **string** | Information about the requesting user. See user.Info interface for details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

