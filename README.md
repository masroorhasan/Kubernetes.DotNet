# Kubernetes.DotNet
Kubernetes API bindings in DotNet.
Note: Usage is limited to local Minikube cluster (proxy to API server).

## Auto generation

Generates C# client wrapper for Kubernetes 1.7 using swagger-codegen.

```
sh Scripts\client-gen.sh
```
Assumes swagger-codgen is installed on machine.

## Usage

Initialize the client like the following:
```csharp
using Kubernetes.DotNet;

// Initialize a client connection to K8s API proxy server 
IKubernetesClient k8sClient = new KubernetesClientConfiguration
{
    MasterUrl = "http://127.0.0.1:8001/"
}.CreateClientInstance();
```

### Pods

**Fetch all Pods** 

```csharp
V1PodList podList = k8sClient.CoreApi.ListNamespacedPod("default");
foreach (V1Pod pod in podList.Items)
    Console.WriteLine($"Pod name={pod.Metadata.Name}, object={pod.ToString()}");
```