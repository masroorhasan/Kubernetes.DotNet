# Kubernetes.DotNet
Kubernetes API bindings in DotNet.
Note: Usage is limited to local Minikube cluster (proxy to API server).


## Usage

Initialize the client like the following:
```csharp
using Kubernetes.DotNet;

// Override master url with minikube cluster's proxy url
IKubernetesClient client = new KubernetesClientConfiguration() { MasterUrl = "http://127.0.0.1:8001" }.CreateClientInstance();
```

### Pods

**Fetch all Pods** 

```csharp
IoK8sKubernetesPkgApiV1PodList podList = client.CoreApi.ListCoreV1NamespacedPod("default", null, null, null, null, null, null, null);
foreach (IoK8sKubernetesPkgApiV1Pod pod in podList.Items)
    Console.WriteLine($"Pod name={pod.Metadata.Name}, object={pod.ToString()}");
```

**Create a Pod** 

```csharp
client.CoreApi.CreateCoreV1NamespacedPod(
    "default", 
    new IoK8sKubernetesPkgApiV1Pod
    {
        Kind = "Pod",
        ApiVersion = "v1",
        Metadata = new IoK8sApimachineryPkgApisMetaV1ObjectMeta
        {
            Name = "nginx",
            _Namespace = "default",
            Labels = new Dictionary<string, string> { { "name", "nginx" } }
        },
        Spec = new IoK8sKubernetesPkgApiV1PodSpec
        {
            Containers = new List<IoK8sKubernetesPkgApiV1Container>
            {
                new IoK8sKubernetesPkgApiV1Container
                {
                    Name = "nginx",
                    Image = "nginx",
                    Ports = new List<IoK8sKubernetesPkgApiV1ContainerPort>
                    {
                        new IoK8sKubernetesPkgApiV1ContainerPort { ContainerPort = 80 }
                    }
                }
            }
        }
    },
    null);
```