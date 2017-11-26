# Kubernetes.DotNet
The C# client SDK for Kubernetes API spec on .NET 4.5+ platform.

## Dependencies
* BouncyCastle
* Newtonsoft.Json
* RestSharp
* YamlDotNet

## Code gen
Generate C# client using docker container. Image definition in `Scripts/Dockerfile`.

### Build image
`docker build -t k8s-client-gen .`

* `K8S_BRANCH_VERSION`: Kubernetes API version, i.e. "release-1.7".
* `GEN_OP_TYPE`: Type of code gen operation, i.e. "create" or "update".

### Generate project from empty state
```sh
docker run -e "K8S_BRANCH_VERSION=release-1.7" -e "GEN_OP_TYPE=create" -v /path/to/code/root/:/usr/src/app/gen/ k8s-client-gen
```

### Update generated API spec only
```sh
docker run -e "K8S_BRANCH_VERSION=release-1.7" -e "GEN_OP_TYPE=update" -v /path/to/code/root/:/usr/src/app/gen/ k8s-client-gen
```

## Usage

### Create client using kube config
Create a client instance using configuration parsed from %USERPROFILE%\.kube\config with specified authentication type.
```csharp
// Initialize client with default kube config using SSL authentication
IKubernetesClient k8sClient = new KubeConfigClientConfiguration().CreateClient(AuthType.SSLAuth);
```

### Create client using custom config
Create a client instance by extending `IClientConfiguration` for custom configuration and authentication type.
```csharp
// Initialize client with user provided SSL configuration
IKubernetesClient k8sClient = new SslClientConfiguration
{
    ClusterUri = new Uri("https://your-k8s-cluster.cloudapp.azure.com"),
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
