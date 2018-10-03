# Kubernetes.DotNet
[![Build Status](https://travis-ci.org/masroorhasan/Kubernetes.DotNet.svg?branch=master)](https://travis-ci.org/masroorhasan/Kubernetes.DotNet)


The C# client SDK for Kubernetes API spec on .NET 4.5+ platform.

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

**Create a Pod** 

```csharp
k8sClient.CoreApi.CreateNamespacedPod(
    "default",
    new V1Pod(
        Metadata: new V1ObjectMeta(Name: "iis-example"),
        Spec: new V1PodSpec(
            Containers: new List<V1Container>
            {
                new V1Container(
                    Image: "microsoft/iis:nanoserver", 
                    Name: "iis", 
                    Ports: new List<V1ContainerPort> { new V1ContainerPort(ContainerPort: 80) })
            })
        )
    );
```

## Development

Generate C# client using docker container. Image definition in `Scripts/Dockerfile`.

### Dependencies
* BouncyCastle
* Newtonsoft.Json
* RestSharp
* YamlDotNet

### Build image
```sh
docker build -t k8s-client-gen .
```

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
