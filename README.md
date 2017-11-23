# Kubernetes.DotNet - C# client library for the Kubernetes

Kubernetes.DotNet supports .NET 4.5+ platform.

## Dependencies
* BouncyCastle
* Newtonsoft.Json
* RestSharp
* YamlDotNet

## Auto generation

Generates C# client wrapper for Kubernetes API 1.7 using swagger-codegen.

```
sh Scripts\client-gen.sh
```

## Usage

### Build client using .kube\config configuration
```csharp

// Initialize client with default kube config using SSL authentication
IKubernetesClient k8sClient = new KubeConfigClientConfiguration().CreateClient(AuthType.SSLAuth);
```


### Build client using extended configuration
The `IClientConfiguration` can be extended to implement client configurations that target specific authentication type.
```csharp
// Initialize client with user provided SSL configuration
IKubernetesClient k8sClient = new SslClientConfiguration
{
    MasterUrl = new Uri("https://your-k8s-cluster.cloudapp.azure.com"),
    Certificate = new X509Certificate2("path\\to\\cert.pfx", "password")
}.CreateClient();
```


### Pods

**Fetch all Pods** 

```csharp
V1PodList podList = k8sClient.CoreApi.ListNamespacedPod("default");
foreach (V1Pod pod in podList.Items)
    Console.WriteLine($"Pod name={pod.Metadata.Name}, object={pod.ToString()}");
```
