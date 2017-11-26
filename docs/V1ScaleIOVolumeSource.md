# Kubernetes.DotNet.Model.V1ScaleIOVolumeSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FsType** | **string** | Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified. | [optional] 
**Gateway** | **string** | The host address of the ScaleIO API Gateway. | 
**ProtectionDomain** | **string** | The name of the Protection Domain for the configured storage (defaults to \&quot;default\&quot;). | [optional] 
**_ReadOnly** | **bool?** | Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. | [optional] 
**SecretRef** | [**V1LocalObjectReference**](V1LocalObjectReference.md) | SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail. | 
**SslEnabled** | **bool?** | Flag to enable/disable SSL communication with Gateway, default false | [optional] 
**StorageMode** | **string** | Indicates whether the storage for a volume should be thick or thin (defaults to \&quot;thin\&quot;). | [optional] 
**StoragePool** | **string** | The Storage Pool associated with the protection domain (defaults to \&quot;default\&quot;). | [optional] 
**System** | **string** | The name of the storage system as configured in ScaleIO. | 
**VolumeName** | **string** | The name of a volume already created in the ScaleIO system that is associated with this volume source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

