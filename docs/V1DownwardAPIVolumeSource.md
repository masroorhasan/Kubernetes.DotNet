# Kubernetes.DotNet.Model.V1DownwardAPIVolumeSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultMode** | **int?** | Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set. | [optional] 
**Items** | [**List&lt;V1DownwardAPIVolumeFile&gt;**](V1DownwardAPIVolumeFile.md) | Items is a list of downward API volume file | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

