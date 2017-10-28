/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Kubernetes.DotNet.Client.SwaggerDateConverter;

namespace Kubernetes.DotNet.Model
{
    /// <summary>
    /// PersistentVolumeSpec is the specification of a persistent volume.
    /// </summary>
    [DataContract]
    public partial class V1PersistentVolumeSpec :  IEquatable<V1PersistentVolumeSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PersistentVolumeSpec" /> class.
        /// </summary>
        /// <param name="AccessModes">AccessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes.</param>
        /// <param name="AwsElasticBlockStore">AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore.</param>
        /// <param name="AzureDisk">AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod..</param>
        /// <param name="AzureFile">AzureFile represents an Azure File Service mount on the host and bind mount to the pod..</param>
        /// <param name="Capacity">A description of the persistent volume&#39;s resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity.</param>
        /// <param name="Cephfs">CephFS represents a Ceph FS mount on the host that shares a pod&#39;s lifetime.</param>
        /// <param name="Cinder">Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md.</param>
        /// <param name="ClaimRef">ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding.</param>
        /// <param name="Fc">FC represents a Fibre Channel resource that is attached to a kubelet&#39;s host machine and then exposed to the pod..</param>
        /// <param name="FlexVolume">FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. This is an alpha feature and may change in future..</param>
        /// <param name="Flocker">Flocker represents a Flocker volume attached to a kubelet&#39;s host machine and exposed to the pod for its usage. This depends on the Flocker control service being running.</param>
        /// <param name="GcePersistentDisk">GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk.</param>
        /// <param name="Glusterfs">Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md.</param>
        /// <param name="HostPath">HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath.</param>
        /// <param name="Iscsi">ISCSI represents an ISCSI Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. Provisioned by an admin..</param>
        /// <param name="Local">Local represents directly-attached storage with node affinity.</param>
        /// <param name="Nfs">NFS represents an NFS mount on the host. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs.</param>
        /// <param name="PersistentVolumeReclaimPolicy">What happens to a persistent volume when released from its claim. Valid options are Retain (default) and Recycle. Recycling must be supported by the volume plugin underlying this persistent volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming.</param>
        /// <param name="PhotonPersistentDisk">PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine.</param>
        /// <param name="PortworxVolume">PortworxVolume represents a portworx volume attached and mounted on kubelets host machine.</param>
        /// <param name="Quobyte">Quobyte represents a Quobyte mount on the host that shares a pod&#39;s lifetime.</param>
        /// <param name="Rbd">RBD represents a Rados Block Device mount on the host that shares a pod&#39;s lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md.</param>
        /// <param name="ScaleIO">ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes..</param>
        /// <param name="StorageClassName">Name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass..</param>
        /// <param name="Storageos">StorageOS represents a StorageOS volume that is attached to the kubelet&#39;s host machine and mounted into the pod More info: https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md.</param>
        /// <param name="VsphereVolume">VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine.</param>
        public V1PersistentVolumeSpec(List<string> AccessModes = default(List<string>), V1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore = default(V1AWSElasticBlockStoreVolumeSource), V1AzureDiskVolumeSource AzureDisk = default(V1AzureDiskVolumeSource), V1AzureFileVolumeSource AzureFile = default(V1AzureFileVolumeSource), Dictionary<string, string> Capacity = default(Dictionary<string, string>), V1CephFSVolumeSource Cephfs = default(V1CephFSVolumeSource), V1CinderVolumeSource Cinder = default(V1CinderVolumeSource), V1ObjectReference ClaimRef = default(V1ObjectReference), V1FCVolumeSource Fc = default(V1FCVolumeSource), V1FlexVolumeSource FlexVolume = default(V1FlexVolumeSource), V1FlockerVolumeSource Flocker = default(V1FlockerVolumeSource), V1GCEPersistentDiskVolumeSource GcePersistentDisk = default(V1GCEPersistentDiskVolumeSource), V1GlusterfsVolumeSource Glusterfs = default(V1GlusterfsVolumeSource), V1HostPathVolumeSource HostPath = default(V1HostPathVolumeSource), V1ISCSIVolumeSource Iscsi = default(V1ISCSIVolumeSource), V1LocalVolumeSource Local = default(V1LocalVolumeSource), V1NFSVolumeSource Nfs = default(V1NFSVolumeSource), string PersistentVolumeReclaimPolicy = default(string), V1PhotonPersistentDiskVolumeSource PhotonPersistentDisk = default(V1PhotonPersistentDiskVolumeSource), V1PortworxVolumeSource PortworxVolume = default(V1PortworxVolumeSource), V1QuobyteVolumeSource Quobyte = default(V1QuobyteVolumeSource), V1RBDVolumeSource Rbd = default(V1RBDVolumeSource), V1ScaleIOVolumeSource ScaleIO = default(V1ScaleIOVolumeSource), string StorageClassName = default(string), V1StorageOSPersistentVolumeSource Storageos = default(V1StorageOSPersistentVolumeSource), V1VsphereVirtualDiskVolumeSource VsphereVolume = default(V1VsphereVirtualDiskVolumeSource))
        {
            this.AccessModes = AccessModes;
            this.AwsElasticBlockStore = AwsElasticBlockStore;
            this.AzureDisk = AzureDisk;
            this.AzureFile = AzureFile;
            this.Capacity = Capacity;
            this.Cephfs = Cephfs;
            this.Cinder = Cinder;
            this.ClaimRef = ClaimRef;
            this.Fc = Fc;
            this.FlexVolume = FlexVolume;
            this.Flocker = Flocker;
            this.GcePersistentDisk = GcePersistentDisk;
            this.Glusterfs = Glusterfs;
            this.HostPath = HostPath;
            this.Iscsi = Iscsi;
            this.Local = Local;
            this.Nfs = Nfs;
            this.PersistentVolumeReclaimPolicy = PersistentVolumeReclaimPolicy;
            this.PhotonPersistentDisk = PhotonPersistentDisk;
            this.PortworxVolume = PortworxVolume;
            this.Quobyte = Quobyte;
            this.Rbd = Rbd;
            this.ScaleIO = ScaleIO;
            this.StorageClassName = StorageClassName;
            this.Storageos = Storageos;
            this.VsphereVolume = VsphereVolume;
        }
        
        /// <summary>
        /// AccessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
        /// </summary>
        /// <value>AccessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes</value>
        [DataMember(Name="accessModes", EmitDefaultValue=false)]
        public List<string> AccessModes { get; set; }

        /// <summary>
        /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        /// <value>AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</value>
        [DataMember(Name="awsElasticBlockStore", EmitDefaultValue=false)]
        public V1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

        /// <summary>
        /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
        /// </summary>
        /// <value>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</value>
        [DataMember(Name="azureDisk", EmitDefaultValue=false)]
        public V1AzureDiskVolumeSource AzureDisk { get; set; }

        /// <summary>
        /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
        /// </summary>
        /// <value>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</value>
        [DataMember(Name="azureFile", EmitDefaultValue=false)]
        public V1AzureFileVolumeSource AzureFile { get; set; }

        /// <summary>
        /// A description of the persistent volume&#39;s resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
        /// </summary>
        /// <value>A description of the persistent volume&#39;s resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</value>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public Dictionary<string, string> Capacity { get; set; }

        /// <summary>
        /// CephFS represents a Ceph FS mount on the host that shares a pod&#39;s lifetime
        /// </summary>
        /// <value>CephFS represents a Ceph FS mount on the host that shares a pod&#39;s lifetime</value>
        [DataMember(Name="cephfs", EmitDefaultValue=false)]
        public V1CephFSVolumeSource Cephfs { get; set; }

        /// <summary>
        /// Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        /// <value>Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</value>
        [DataMember(Name="cinder", EmitDefaultValue=false)]
        public V1CinderVolumeSource Cinder { get; set; }

        /// <summary>
        /// ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
        /// </summary>
        /// <value>ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding</value>
        [DataMember(Name="claimRef", EmitDefaultValue=false)]
        public V1ObjectReference ClaimRef { get; set; }

        /// <summary>
        /// FC represents a Fibre Channel resource that is attached to a kubelet&#39;s host machine and then exposed to the pod.
        /// </summary>
        /// <value>FC represents a Fibre Channel resource that is attached to a kubelet&#39;s host machine and then exposed to the pod.</value>
        [DataMember(Name="fc", EmitDefaultValue=false)]
        public V1FCVolumeSource Fc { get; set; }

        /// <summary>
        /// FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. This is an alpha feature and may change in future.
        /// </summary>
        /// <value>FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. This is an alpha feature and may change in future.</value>
        [DataMember(Name="flexVolume", EmitDefaultValue=false)]
        public V1FlexVolumeSource FlexVolume { get; set; }

        /// <summary>
        /// Flocker represents a Flocker volume attached to a kubelet&#39;s host machine and exposed to the pod for its usage. This depends on the Flocker control service being running
        /// </summary>
        /// <value>Flocker represents a Flocker volume attached to a kubelet&#39;s host machine and exposed to the pod for its usage. This depends on the Flocker control service being running</value>
        [DataMember(Name="flocker", EmitDefaultValue=false)]
        public V1FlockerVolumeSource Flocker { get; set; }

        /// <summary>
        /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        /// <value>GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</value>
        [DataMember(Name="gcePersistentDisk", EmitDefaultValue=false)]
        public V1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

        /// <summary>
        /// Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
        /// </summary>
        /// <value>Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md</value>
        [DataMember(Name="glusterfs", EmitDefaultValue=false)]
        public V1GlusterfsVolumeSource Glusterfs { get; set; }

        /// <summary>
        /// HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        /// <value>HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</value>
        [DataMember(Name="hostPath", EmitDefaultValue=false)]
        public V1HostPathVolumeSource HostPath { get; set; }

        /// <summary>
        /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. Provisioned by an admin.
        /// </summary>
        /// <value>ISCSI represents an ISCSI Disk resource that is attached to a kubelet&#39;s host machine and then exposed to the pod. Provisioned by an admin.</value>
        [DataMember(Name="iscsi", EmitDefaultValue=false)]
        public V1ISCSIVolumeSource Iscsi { get; set; }

        /// <summary>
        /// Local represents directly-attached storage with node affinity
        /// </summary>
        /// <value>Local represents directly-attached storage with node affinity</value>
        [DataMember(Name="local", EmitDefaultValue=false)]
        public V1LocalVolumeSource Local { get; set; }

        /// <summary>
        /// NFS represents an NFS mount on the host. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        /// <value>NFS represents an NFS mount on the host. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</value>
        [DataMember(Name="nfs", EmitDefaultValue=false)]
        public V1NFSVolumeSource Nfs { get; set; }

        /// <summary>
        /// What happens to a persistent volume when released from its claim. Valid options are Retain (default) and Recycle. Recycling must be supported by the volume plugin underlying this persistent volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
        /// </summary>
        /// <value>What happens to a persistent volume when released from its claim. Valid options are Retain (default) and Recycle. Recycling must be supported by the volume plugin underlying this persistent volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming</value>
        [DataMember(Name="persistentVolumeReclaimPolicy", EmitDefaultValue=false)]
        public string PersistentVolumeReclaimPolicy { get; set; }

        /// <summary>
        /// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
        /// </summary>
        /// <value>PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine</value>
        [DataMember(Name="photonPersistentDisk", EmitDefaultValue=false)]
        public V1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

        /// <summary>
        /// PortworxVolume represents a portworx volume attached and mounted on kubelets host machine
        /// </summary>
        /// <value>PortworxVolume represents a portworx volume attached and mounted on kubelets host machine</value>
        [DataMember(Name="portworxVolume", EmitDefaultValue=false)]
        public V1PortworxVolumeSource PortworxVolume { get; set; }

        /// <summary>
        /// Quobyte represents a Quobyte mount on the host that shares a pod&#39;s lifetime
        /// </summary>
        /// <value>Quobyte represents a Quobyte mount on the host that shares a pod&#39;s lifetime</value>
        [DataMember(Name="quobyte", EmitDefaultValue=false)]
        public V1QuobyteVolumeSource Quobyte { get; set; }

        /// <summary>
        /// RBD represents a Rados Block Device mount on the host that shares a pod&#39;s lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
        /// </summary>
        /// <value>RBD represents a Rados Block Device mount on the host that shares a pod&#39;s lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md</value>
        [DataMember(Name="rbd", EmitDefaultValue=false)]
        public V1RBDVolumeSource Rbd { get; set; }

        /// <summary>
        /// ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
        /// </summary>
        /// <value>ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</value>
        [DataMember(Name="scaleIO", EmitDefaultValue=false)]
        public V1ScaleIOVolumeSource ScaleIO { get; set; }

        /// <summary>
        /// Name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass.
        /// </summary>
        /// <value>Name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass.</value>
        [DataMember(Name="storageClassName", EmitDefaultValue=false)]
        public string StorageClassName { get; set; }

        /// <summary>
        /// StorageOS represents a StorageOS volume that is attached to the kubelet&#39;s host machine and mounted into the pod More info: https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md
        /// </summary>
        /// <value>StorageOS represents a StorageOS volume that is attached to the kubelet&#39;s host machine and mounted into the pod More info: https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md</value>
        [DataMember(Name="storageos", EmitDefaultValue=false)]
        public V1StorageOSPersistentVolumeSource Storageos { get; set; }

        /// <summary>
        /// VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
        /// </summary>
        /// <value>VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine</value>
        [DataMember(Name="vsphereVolume", EmitDefaultValue=false)]
        public V1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PersistentVolumeSpec {\n");
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1PersistentVolumeSpec);
        }

        /// <summary>
        /// Returns true if V1PersistentVolumeSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PersistentVolumeSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PersistentVolumeSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessModes == other.AccessModes ||
                    this.AccessModes != null &&
                    this.AccessModes.SequenceEqual(other.AccessModes)
                ) && 
                (
                    this.AwsElasticBlockStore == other.AwsElasticBlockStore ||
                    this.AwsElasticBlockStore != null &&
                    this.AwsElasticBlockStore.Equals(other.AwsElasticBlockStore)
                ) && 
                (
                    this.AzureDisk == other.AzureDisk ||
                    this.AzureDisk != null &&
                    this.AzureDisk.Equals(other.AzureDisk)
                ) && 
                (
                    this.AzureFile == other.AzureFile ||
                    this.AzureFile != null &&
                    this.AzureFile.Equals(other.AzureFile)
                ) && 
                (
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.SequenceEqual(other.Capacity)
                ) && 
                (
                    this.Cephfs == other.Cephfs ||
                    this.Cephfs != null &&
                    this.Cephfs.Equals(other.Cephfs)
                ) && 
                (
                    this.Cinder == other.Cinder ||
                    this.Cinder != null &&
                    this.Cinder.Equals(other.Cinder)
                ) && 
                (
                    this.ClaimRef == other.ClaimRef ||
                    this.ClaimRef != null &&
                    this.ClaimRef.Equals(other.ClaimRef)
                ) && 
                (
                    this.Fc == other.Fc ||
                    this.Fc != null &&
                    this.Fc.Equals(other.Fc)
                ) && 
                (
                    this.FlexVolume == other.FlexVolume ||
                    this.FlexVolume != null &&
                    this.FlexVolume.Equals(other.FlexVolume)
                ) && 
                (
                    this.Flocker == other.Flocker ||
                    this.Flocker != null &&
                    this.Flocker.Equals(other.Flocker)
                ) && 
                (
                    this.GcePersistentDisk == other.GcePersistentDisk ||
                    this.GcePersistentDisk != null &&
                    this.GcePersistentDisk.Equals(other.GcePersistentDisk)
                ) && 
                (
                    this.Glusterfs == other.Glusterfs ||
                    this.Glusterfs != null &&
                    this.Glusterfs.Equals(other.Glusterfs)
                ) && 
                (
                    this.HostPath == other.HostPath ||
                    this.HostPath != null &&
                    this.HostPath.Equals(other.HostPath)
                ) && 
                (
                    this.Iscsi == other.Iscsi ||
                    this.Iscsi != null &&
                    this.Iscsi.Equals(other.Iscsi)
                ) && 
                (
                    this.Local == other.Local ||
                    this.Local != null &&
                    this.Local.Equals(other.Local)
                ) && 
                (
                    this.Nfs == other.Nfs ||
                    this.Nfs != null &&
                    this.Nfs.Equals(other.Nfs)
                ) && 
                (
                    this.PersistentVolumeReclaimPolicy == other.PersistentVolumeReclaimPolicy ||
                    this.PersistentVolumeReclaimPolicy != null &&
                    this.PersistentVolumeReclaimPolicy.Equals(other.PersistentVolumeReclaimPolicy)
                ) && 
                (
                    this.PhotonPersistentDisk == other.PhotonPersistentDisk ||
                    this.PhotonPersistentDisk != null &&
                    this.PhotonPersistentDisk.Equals(other.PhotonPersistentDisk)
                ) && 
                (
                    this.PortworxVolume == other.PortworxVolume ||
                    this.PortworxVolume != null &&
                    this.PortworxVolume.Equals(other.PortworxVolume)
                ) && 
                (
                    this.Quobyte == other.Quobyte ||
                    this.Quobyte != null &&
                    this.Quobyte.Equals(other.Quobyte)
                ) && 
                (
                    this.Rbd == other.Rbd ||
                    this.Rbd != null &&
                    this.Rbd.Equals(other.Rbd)
                ) && 
                (
                    this.ScaleIO == other.ScaleIO ||
                    this.ScaleIO != null &&
                    this.ScaleIO.Equals(other.ScaleIO)
                ) && 
                (
                    this.StorageClassName == other.StorageClassName ||
                    this.StorageClassName != null &&
                    this.StorageClassName.Equals(other.StorageClassName)
                ) && 
                (
                    this.Storageos == other.Storageos ||
                    this.Storageos != null &&
                    this.Storageos.Equals(other.Storageos)
                ) && 
                (
                    this.VsphereVolume == other.VsphereVolume ||
                    this.VsphereVolume != null &&
                    this.VsphereVolume.Equals(other.VsphereVolume)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AccessModes != null)
                    hash = hash * 59 + this.AccessModes.GetHashCode();
                if (this.AwsElasticBlockStore != null)
                    hash = hash * 59 + this.AwsElasticBlockStore.GetHashCode();
                if (this.AzureDisk != null)
                    hash = hash * 59 + this.AzureDisk.GetHashCode();
                if (this.AzureFile != null)
                    hash = hash * 59 + this.AzureFile.GetHashCode();
                if (this.Capacity != null)
                    hash = hash * 59 + this.Capacity.GetHashCode();
                if (this.Cephfs != null)
                    hash = hash * 59 + this.Cephfs.GetHashCode();
                if (this.Cinder != null)
                    hash = hash * 59 + this.Cinder.GetHashCode();
                if (this.ClaimRef != null)
                    hash = hash * 59 + this.ClaimRef.GetHashCode();
                if (this.Fc != null)
                    hash = hash * 59 + this.Fc.GetHashCode();
                if (this.FlexVolume != null)
                    hash = hash * 59 + this.FlexVolume.GetHashCode();
                if (this.Flocker != null)
                    hash = hash * 59 + this.Flocker.GetHashCode();
                if (this.GcePersistentDisk != null)
                    hash = hash * 59 + this.GcePersistentDisk.GetHashCode();
                if (this.Glusterfs != null)
                    hash = hash * 59 + this.Glusterfs.GetHashCode();
                if (this.HostPath != null)
                    hash = hash * 59 + this.HostPath.GetHashCode();
                if (this.Iscsi != null)
                    hash = hash * 59 + this.Iscsi.GetHashCode();
                if (this.Local != null)
                    hash = hash * 59 + this.Local.GetHashCode();
                if (this.Nfs != null)
                    hash = hash * 59 + this.Nfs.GetHashCode();
                if (this.PersistentVolumeReclaimPolicy != null)
                    hash = hash * 59 + this.PersistentVolumeReclaimPolicy.GetHashCode();
                if (this.PhotonPersistentDisk != null)
                    hash = hash * 59 + this.PhotonPersistentDisk.GetHashCode();
                if (this.PortworxVolume != null)
                    hash = hash * 59 + this.PortworxVolume.GetHashCode();
                if (this.Quobyte != null)
                    hash = hash * 59 + this.Quobyte.GetHashCode();
                if (this.Rbd != null)
                    hash = hash * 59 + this.Rbd.GetHashCode();
                if (this.ScaleIO != null)
                    hash = hash * 59 + this.ScaleIO.GetHashCode();
                if (this.StorageClassName != null)
                    hash = hash * 59 + this.StorageClassName.GetHashCode();
                if (this.Storageos != null)
                    hash = hash * 59 + this.Storageos.GetHashCode();
                if (this.VsphereVolume != null)
                    hash = hash * 59 + this.VsphereVolume.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
