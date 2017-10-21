# Kubernetes.DotNet
Kubernetes API bindings in DotNet.
Note: Usage is limited to local Minikube cluster (proxy to API server).


## Usage

**Get pods running in default namespace**
Use generated API to request resources. Resource bindings are available under Models.

```csharp
// Minikube cluster proxy running on port 8001
Core_v1Api coreApi = new Core_v1Api("http://127.0.0.1:8001");
IoK8sKubernetesPkgApiV1PodList podList = coreApi.ListCoreV1NamespacedPod("default", null, null, null, null, null, null, null);
foreach (IoK8sKubernetesPkgApiV1Pod pod in podList.Items)
    Console.WriteLine($"Pod name={pod.Metadata.Name}, object={pod.ToString()}");
```
