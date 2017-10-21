# Kubernetes.DotNet
Kubernetes API bindings in DotNet.
Note: Usage is limited to local Minikube cluster (proxy to API server).


## Usage

Uses generated API to request resources. Resource bindings are available under Models.

### Pods

**Fetching all Pods in namespace** 

```csharp
// Minikube cluster proxy running on port 8001
Core_v1Api coreApi = new Core_v1Api("http://127.0.0.1:8001");
IoK8sKubernetesPkgApiV1PodList podList = coreApi.ListCoreV1NamespacedPod("default", null, null, null, null, null, null, null);
foreach (IoK8sKubernetesPkgApiV1Pod pod in podList.Items)
    Console.WriteLine($"Pod name={pod.Metadata.Name}, object={pod.ToString()}");
```

**Create a Pod** 

```csharp
// Create a Pod in 'default' namespace
Core_v1Api coreApi = new Core_v1Api("http://127.0.0.1:8001");
coreApi.CreateCoreV1NamespacedPod(
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