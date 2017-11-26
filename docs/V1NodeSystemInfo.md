# Kubernetes.DotNet.Model.V1NodeSystemInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Architecture** | **string** | The Architecture reported by the node | 
**BootID** | **string** | Boot ID reported by the node. | 
**ContainerRuntimeVersion** | **string** | ContainerRuntime Version reported by the node through runtime remote API (e.g. docker://1.5.0). | 
**KernelVersion** | **string** | Kernel Version reported by the node from &#39;uname -r&#39; (e.g. 3.16.0-0.bpo.4-amd64). | 
**KubeProxyVersion** | **string** | KubeProxy Version reported by the node. | 
**KubeletVersion** | **string** | Kubelet Version reported by the node. | 
**MachineID** | **string** | MachineID reported by the node. For unique machine identification in the cluster this field is preferred. Learn more from man(5) machine-id: http://man7.org/linux/man-pages/man5/machine-id.5.html | 
**OperatingSystem** | **string** | The Operating System reported by the node | 
**OsImage** | **string** | OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)). | 
**SystemUUID** | **string** | SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

