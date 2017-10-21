using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// PersistentVolumeSpec is the specification of a persistent volume.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1PersistentVolumeSpec {
    /// <summary>
    /// AccessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
    /// </summary>
    /// <value>AccessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes</value>
    [DataMember(Name="accessModes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessModes")]
    public List<string> AccessModes { get; set; }

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
    /// A description of the persistent volume's resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
    /// </summary>
    /// <value>A description of the persistent volume's resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capacity")]
    public Dictionary<string, IoK8sApimachineryPkgApiResourceQuantity> Capacity { get; set; }

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
    /// ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
    /// </summary>
    /// <value>ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding</value>
    [DataMember(Name="claimRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claimRef")]
    public IoK8sKubernetesPkgApiV1ObjectReference ClaimRef { get; set; }

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
    /// Flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage. This depends on the Flocker control service being running
    /// </summary>
    /// <value>Flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage. This depends on the Flocker control service being running</value>
    [DataMember(Name="flocker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flocker")]
    public IoK8sKubernetesPkgApiV1FlockerVolumeSource Flocker { get; set; }

    /// <summary>
    /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
    /// </summary>
    /// <value>GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</value>
    [DataMember(Name="gcePersistentDisk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gcePersistentDisk")]
    public IoK8sKubernetesPkgApiV1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

    /// <summary>
    /// Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
    /// </summary>
    /// <value>Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md</value>
    [DataMember(Name="glusterfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "glusterfs")]
    public IoK8sKubernetesPkgApiV1GlusterfsVolumeSource Glusterfs { get; set; }

    /// <summary>
    /// HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
    /// </summary>
    /// <value>HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</value>
    [DataMember(Name="hostPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostPath")]
    public IoK8sKubernetesPkgApiV1HostPathVolumeSource HostPath { get; set; }

    /// <summary>
    /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin.
    /// </summary>
    /// <value>ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin.</value>
    [DataMember(Name="iscsi", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iscsi")]
    public IoK8sKubernetesPkgApiV1ISCSIVolumeSource Iscsi { get; set; }

    /// <summary>
    /// Local represents directly-attached storage with node affinity
    /// </summary>
    /// <value>Local represents directly-attached storage with node affinity</value>
    [DataMember(Name="local", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "local")]
    public IoK8sKubernetesPkgApiV1LocalVolumeSource Local { get; set; }

    /// <summary>
    /// NFS represents an NFS mount on the host. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
    /// </summary>
    /// <value>NFS represents an NFS mount on the host. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</value>
    [DataMember(Name="nfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nfs")]
    public IoK8sKubernetesPkgApiV1NFSVolumeSource Nfs { get; set; }

    /// <summary>
    /// What happens to a persistent volume when released from its claim. Valid options are Retain (default) and Recycle. Recycling must be supported by the volume plugin underlying this persistent volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
    /// </summary>
    /// <value>What happens to a persistent volume when released from its claim. Valid options are Retain (default) and Recycle. Recycling must be supported by the volume plugin underlying this persistent volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming</value>
    [DataMember(Name="persistentVolumeReclaimPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "persistentVolumeReclaimPolicy")]
    public string PersistentVolumeReclaimPolicy { get; set; }

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
    /// Name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass.
    /// </summary>
    /// <value>Name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass.</value>
    [DataMember(Name="storageClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storageClassName")]
    public string StorageClassName { get; set; }

    /// <summary>
    /// StorageOS represents a StorageOS volume that is attached to the kubelet's host machine and mounted into the pod More info: https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md
    /// </summary>
    /// <value>StorageOS represents a StorageOS volume that is attached to the kubelet's host machine and mounted into the pod More info: https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md</value>
    [DataMember(Name="storageos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storageos")]
    public IoK8sKubernetesPkgApiV1StorageOSPersistentVolumeSource Storageos { get; set; }

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
      sb.Append("class IoK8sKubernetesPkgApiV1PersistentVolumeSpec {\n");
      sb.Append("  AccessModes: ").Append(AccessModes).Append("\n");
      sb.Append("  AwsElasticBlockStore: ").Append(AwsElasticBlockStore).Append("\n");
      sb.Append("  AzureDisk: ").Append(AzureDisk).Append("\n");
      sb.Append("  AzureFile: ").Append(AzureFile).Append("\n");
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      sb.Append("  Cephfs: ").Append(Cephfs).Append("\n");
      sb.Append("  Cinder: ").Append(Cinder).Append("\n");
      sb.Append("  ClaimRef: ").Append(ClaimRef).Append("\n");
      sb.Append("  Fc: ").Append(Fc).Append("\n");
      sb.Append("  FlexVolume: ").Append(FlexVolume).Append("\n");
      sb.Append("  Flocker: ").Append(Flocker).Append("\n");
      sb.Append("  GcePersistentDisk: ").Append(GcePersistentDisk).Append("\n");
      sb.Append("  Glusterfs: ").Append(Glusterfs).Append("\n");
      sb.Append("  HostPath: ").Append(HostPath).Append("\n");
      sb.Append("  Iscsi: ").Append(Iscsi).Append("\n");
      sb.Append("  Local: ").Append(Local).Append("\n");
      sb.Append("  Nfs: ").Append(Nfs).Append("\n");
      sb.Append("  PersistentVolumeReclaimPolicy: ").Append(PersistentVolumeReclaimPolicy).Append("\n");
      sb.Append("  PhotonPersistentDisk: ").Append(PhotonPersistentDisk).Append("\n");
      sb.Append("  PortworxVolume: ").Append(PortworxVolume).Append("\n");
      sb.Append("  Quobyte: ").Append(Quobyte).Append("\n");
      sb.Append("  Rbd: ").Append(Rbd).Append("\n");
      sb.Append("  ScaleIO: ").Append(ScaleIO).Append("\n");
      sb.Append("  StorageClassName: ").Append(StorageClassName).Append("\n");
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
