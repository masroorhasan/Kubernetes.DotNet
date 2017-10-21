using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// Volume represents a named volume in a pod that may be accessed by any container in the pod.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1Volume {
    /// <summary>
    /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
    /// </summary>
    /// <value>AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</value>
    [DataMember(Name="awsElasticBlockStore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "awsElasticBlockStore")]
    public IoK8sKubernetesPkgApiV1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

    /// <summary>
    /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
    /// </summary>
    /// <value>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</value>
    [DataMember(Name="azureDisk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "azureDisk")]
    public IoK8sKubernetesPkgApiV1AzureDiskVolumeSource AzureDisk { get; set; }

    /// <summary>
    /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
    /// </summary>
    /// <value>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</value>
    [DataMember(Name="azureFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "azureFile")]
    public IoK8sKubernetesPkgApiV1AzureFileVolumeSource AzureFile { get; set; }

    /// <summary>
    /// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
    /// </summary>
    /// <value>CephFS represents a Ceph FS mount on the host that shares a pod's lifetime</value>
    [DataMember(Name="cephfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cephfs")]
    public IoK8sKubernetesPkgApiV1CephFSVolumeSource Cephfs { get; set; }

    /// <summary>
    /// Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
    /// </summary>
    /// <value>Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</value>
    [DataMember(Name="cinder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cinder")]
    public IoK8sKubernetesPkgApiV1CinderVolumeSource Cinder { get; set; }

    /// <summary>
    /// ConfigMap represents a configMap that should populate this volume
    /// </summary>
    /// <value>ConfigMap represents a configMap that should populate this volume</value>
    [DataMember(Name="configMap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configMap")]
    public IoK8sKubernetesPkgApiV1ConfigMapVolumeSource ConfigMap { get; set; }

    /// <summary>
    /// DownwardAPI represents downward API about the pod that should populate this volume
    /// </summary>
    /// <value>DownwardAPI represents downward API about the pod that should populate this volume</value>
    [DataMember(Name="downwardAPI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "downwardAPI")]
    public IoK8sKubernetesPkgApiV1DownwardAPIVolumeSource DownwardAPI { get; set; }

    /// <summary>
    /// EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
    /// </summary>
    /// <value>EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir</value>
    [DataMember(Name="emptyDir", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emptyDir")]
    public IoK8sKubernetesPkgApiV1EmptyDirVolumeSource EmptyDir { get; set; }

    /// <summary>
    /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
    /// </summary>
    /// <value>FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</value>
    [DataMember(Name="fc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fc")]
    public IoK8sKubernetesPkgApiV1FCVolumeSource Fc { get; set; }

    /// <summary>
    /// FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. This is an alpha feature and may change in future.
    /// </summary>
    /// <value>FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. This is an alpha feature and may change in future.</value>
    [DataMember(Name="flexVolume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flexVolume")]
    public IoK8sKubernetesPkgApiV1FlexVolumeSource FlexVolume { get; set; }

    /// <summary>
    /// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running
    /// </summary>
    /// <value>Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running</value>
    [DataMember(Name="flocker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flocker")]
    public IoK8sKubernetesPkgApiV1FlockerVolumeSource Flocker { get; set; }

    /// <summary>
    /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
    /// </summary>
    /// <value>GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</value>
    [DataMember(Name="gcePersistentDisk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gcePersistentDisk")]
    public IoK8sKubernetesPkgApiV1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

    /// <summary>
    /// GitRepo represents a git repository at a particular revision.
    /// </summary>
    /// <value>GitRepo represents a git repository at a particular revision.</value>
    [DataMember(Name="gitRepo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gitRepo")]
    public IoK8sKubernetesPkgApiV1GitRepoVolumeSource GitRepo { get; set; }

    /// <summary>
    /// Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
    /// </summary>
    /// <value>Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md</value>
    [DataMember(Name="glusterfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glusterfs")]
    public IoK8sKubernetesPkgApiV1GlusterfsVolumeSource Glusterfs { get; set; }

    /// <summary>
    /// HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
    /// </summary>
    /// <value>HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</value>
    [DataMember(Name="hostPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostPath")]
    public IoK8sKubernetesPkgApiV1HostPathVolumeSource HostPath { get; set; }

    /// <summary>
    /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md
    /// </summary>
    /// <value>ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md</value>
    [DataMember(Name="iscsi", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iscsi")]
    public IoK8sKubernetesPkgApiV1ISCSIVolumeSource Iscsi { get; set; }

    /// <summary>
    /// Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    /// <value>Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
    /// </summary>
    /// <value>NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</value>
    [DataMember(Name="nfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nfs")]
    public IoK8sKubernetesPkgApiV1NFSVolumeSource Nfs { get; set; }

    /// <summary>
    /// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
    /// </summary>
    /// <value>PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</value>
    [DataMember(Name="persistentVolumeClaim", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "persistentVolumeClaim")]
    public IoK8sKubernetesPkgApiV1PersistentVolumeClaimVolumeSource PersistentVolumeClaim { get; set; }

    /// <summary>
    /// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
    /// </summary>
    /// <value>PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine</value>
    [DataMember(Name="photonPersistentDisk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "photonPersistentDisk")]
    public IoK8sKubernetesPkgApiV1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

    /// <summary>
    /// PortworxVolume represents a portworx volume attached and mounted on kubelets host machine
    /// </summary>
    /// <value>PortworxVolume represents a portworx volume attached and mounted on kubelets host machine</value>
    [DataMember(Name="portworxVolume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "portworxVolume")]
    public IoK8sKubernetesPkgApiV1PortworxVolumeSource PortworxVolume { get; set; }

    /// <summary>
    /// Items for all in one resources secrets, configmaps, and downward API
    /// </summary>
    /// <value>Items for all in one resources secrets, configmaps, and downward API</value>
    [DataMember(Name="projected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projected")]
    public IoK8sKubernetesPkgApiV1ProjectedVolumeSource Projected { get; set; }

    /// <summary>
    /// Quobyte represents a Quobyte mount on the host that shares a pod's lifetime
    /// </summary>
    /// <value>Quobyte represents a Quobyte mount on the host that shares a pod's lifetime</value>
    [DataMember(Name="quobyte", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quobyte")]
    public IoK8sKubernetesPkgApiV1QuobyteVolumeSource Quobyte { get; set; }

    /// <summary>
    /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
    /// </summary>
    /// <value>RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md</value>
    [DataMember(Name="rbd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rbd")]
    public IoK8sKubernetesPkgApiV1RBDVolumeSource Rbd { get; set; }

    /// <summary>
    /// ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
    /// </summary>
    /// <value>ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</value>
    [DataMember(Name="scaleIO", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaleIO")]
    public IoK8sKubernetesPkgApiV1ScaleIOVolumeSource ScaleIO { get; set; }

    /// <summary>
    /// Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
    /// </summary>
    /// <value>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public IoK8sKubernetesPkgApiV1SecretVolumeSource Secret { get; set; }

    /// <summary>
    /// StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
    /// </summary>
    /// <value>StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.</value>
    [DataMember(Name="storageos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storageos")]
    public IoK8sKubernetesPkgApiV1StorageOSVolumeSource Storageos { get; set; }

    /// <summary>
    /// VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
    /// </summary>
    /// <value>VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine</value>
    [DataMember(Name="vsphereVolume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vsphereVolume")]
    public IoK8sKubernetesPkgApiV1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1Volume {\n");
      sb.Append("  AwsElasticBlockStore: ").Append(AwsElasticBlockStore).Append("\n");
      sb.Append("  AzureDisk: ").Append(AzureDisk).Append("\n");
      sb.Append("  AzureFile: ").Append(AzureFile).Append("\n");
      sb.Append("  Cephfs: ").Append(Cephfs).Append("\n");
      sb.Append("  Cinder: ").Append(Cinder).Append("\n");
      sb.Append("  ConfigMap: ").Append(ConfigMap).Append("\n");
      sb.Append("  DownwardAPI: ").Append(DownwardAPI).Append("\n");
      sb.Append("  EmptyDir: ").Append(EmptyDir).Append("\n");
      sb.Append("  Fc: ").Append(Fc).Append("\n");
      sb.Append("  FlexVolume: ").Append(FlexVolume).Append("\n");
      sb.Append("  Flocker: ").Append(Flocker).Append("\n");
      sb.Append("  GcePersistentDisk: ").Append(GcePersistentDisk).Append("\n");
      sb.Append("  GitRepo: ").Append(GitRepo).Append("\n");
      sb.Append("  Glusterfs: ").Append(Glusterfs).Append("\n");
      sb.Append("  HostPath: ").Append(HostPath).Append("\n");
      sb.Append("  Iscsi: ").Append(Iscsi).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Nfs: ").Append(Nfs).Append("\n");
      sb.Append("  PersistentVolumeClaim: ").Append(PersistentVolumeClaim).Append("\n");
      sb.Append("  PhotonPersistentDisk: ").Append(PhotonPersistentDisk).Append("\n");
      sb.Append("  PortworxVolume: ").Append(PortworxVolume).Append("\n");
      sb.Append("  Projected: ").Append(Projected).Append("\n");
      sb.Append("  Quobyte: ").Append(Quobyte).Append("\n");
      sb.Append("  Rbd: ").Append(Rbd).Append("\n");
      sb.Append("  ScaleIO: ").Append(ScaleIO).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  Storageos: ").Append(Storageos).Append("\n");
      sb.Append("  VsphereVolume: ").Append(VsphereVolume).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
