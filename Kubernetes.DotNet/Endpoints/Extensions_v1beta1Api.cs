using System;
using System.Collections.Generic;
using RestSharp;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Kubernetes.DotNet.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExtensions_v1beta1Api
    {
        /// <summary>
        ///  create a DaemonSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet CreateExtensionsV1beta1NamespacedDaemonSet (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet body, string pretty);
        /// <summary>
        ///  create a Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Deployment CreateExtensionsV1beta1NamespacedDeployment (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Deployment body, string pretty);
        /// <summary>
        ///  create rollback of a DeploymentRollback
        /// </summary>
        /// <param name="name">name of the DeploymentRollback</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentRollback</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentRollback CreateExtensionsV1beta1NamespacedDeploymentRollbackRollback (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentRollback body, string pretty);
        /// <summary>
        ///  create an Ingress
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Ingress CreateExtensionsV1beta1NamespacedIngress (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Ingress body, string pretty);
        /// <summary>
        ///  create a NetworkPolicy
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy CreateExtensionsV1beta1NamespacedNetworkPolicy (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy body, string pretty);
        /// <summary>
        ///  create a ReplicaSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet CreateExtensionsV1beta1NamespacedReplicaSet (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet body, string pretty);
        /// <summary>
        ///  create a PodSecurityPolicy
        /// </summary>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy CreateExtensionsV1beta1PodSecurityPolicy (IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy body, string pretty);
        /// <summary>
        ///  create a ThirdPartyResource
        /// </summary>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource CreateExtensionsV1beta1ThirdPartyResource (IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource body, string pretty);
        /// <summary>
        ///  delete collection of DaemonSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedDaemonSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete collection of Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedDeployment (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete collection of Ingress
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedIngress (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete collection of NetworkPolicy
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedNetworkPolicy (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete collection of ReplicaSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedReplicaSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete collection of PodSecurityPolicy
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionPodSecurityPolicy (string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete collection of ThirdPartyResource
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionThirdPartyResource (string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete a DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  delete a Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  delete an Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedIngress (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  delete a NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  delete a ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  delete a PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1PodSecurityPolicy (string name, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  delete a ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1ThirdPartyResource (string name, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>
        IoK8sApimachineryPkgApisMetaV1APIResourceList GetExtensionsV1beta1APIResources ();
        /// <summary>
        ///  list or watch objects of kind DaemonSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList ListExtensionsV1beta1DaemonSetForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind Deployment
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList ListExtensionsV1beta1DeploymentForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind Ingress
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1IngressList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1IngressList ListExtensionsV1beta1IngressForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind DaemonSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList ListExtensionsV1beta1NamespacedDaemonSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList ListExtensionsV1beta1NamespacedDeployment (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind Ingress
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1IngressList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1IngressList ListExtensionsV1beta1NamespacedIngress (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind NetworkPolicy
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList ListExtensionsV1beta1NamespacedNetworkPolicy (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind ReplicaSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList ListExtensionsV1beta1NamespacedReplicaSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind NetworkPolicy
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList ListExtensionsV1beta1NetworkPolicyForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind PodSecurityPolicy
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicyList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicyList ListExtensionsV1beta1PodSecurityPolicy (string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind ReplicaSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList ListExtensionsV1beta1ReplicaSetForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind ThirdPartyResource
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResourceList</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResourceList ListExtensionsV1beta1ThirdPartyResource (string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  partially update the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet PatchExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update status of the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet PatchExtensionsV1beta1NamespacedDaemonSetStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Deployment PatchExtensionsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Deployment PatchExtensionsV1beta1NamespacedDeploymentStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale PatchExtensionsV1beta1NamespacedDeploymentsScale (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Ingress PatchExtensionsV1beta1NamespacedIngress (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update status of the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Ingress PatchExtensionsV1beta1NamespacedIngressStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy PatchExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet PatchExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update status of the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet PatchExtensionsV1beta1NamespacedReplicaSetStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale PatchExtensionsV1beta1NamespacedReplicasetsScale (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale PatchExtensionsV1beta1NamespacedReplicationcontrollersScale (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy PatchExtensionsV1beta1PodSecurityPolicy (string name, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource PatchExtensionsV1beta1ThirdPartyResource (string name, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  read the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet ReadExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read status of the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet ReadExtensionsV1beta1NamespacedDaemonSetStatus (string name, string _namespace, string pretty);
        /// <summary>
        ///  read the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Deployment ReadExtensionsV1beta1NamespacedDeployment (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Deployment ReadExtensionsV1beta1NamespacedDeploymentStatus (string name, string _namespace, string pretty);
        /// <summary>
        ///  read scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReadExtensionsV1beta1NamespacedDeploymentsScale (string name, string _namespace, string pretty);
        /// <summary>
        ///  read the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Ingress ReadExtensionsV1beta1NamespacedIngress (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read status of the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Ingress ReadExtensionsV1beta1NamespacedIngressStatus (string name, string _namespace, string pretty);
        /// <summary>
        ///  read the specified NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy ReadExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet ReadExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read status of the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet ReadExtensionsV1beta1NamespacedReplicaSetStatus (string name, string _namespace, string pretty);
        /// <summary>
        ///  read scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReadExtensionsV1beta1NamespacedReplicasetsScale (string name, string _namespace, string pretty);
        /// <summary>
        ///  read scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReadExtensionsV1beta1NamespacedReplicationcontrollersScale (string name, string _namespace, string pretty);
        /// <summary>
        ///  read the specified PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy ReadExtensionsV1beta1PodSecurityPolicy (string name, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read the specified ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource ReadExtensionsV1beta1ThirdPartyResource (string name, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  replace the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet ReplaceExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet body, string pretty);
        /// <summary>
        ///  replace status of the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet ReplaceExtensionsV1beta1NamespacedDaemonSetStatus (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet body, string pretty);
        /// <summary>
        ///  replace the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Deployment ReplaceExtensionsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Deployment body, string pretty);
        /// <summary>
        ///  replace status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Deployment ReplaceExtensionsV1beta1NamespacedDeploymentStatus (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Deployment body, string pretty);
        /// <summary>
        ///  replace scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReplaceExtensionsV1beta1NamespacedDeploymentsScale (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Scale body, string pretty);
        /// <summary>
        ///  replace the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Ingress ReplaceExtensionsV1beta1NamespacedIngress (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Ingress body, string pretty);
        /// <summary>
        ///  replace status of the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Ingress ReplaceExtensionsV1beta1NamespacedIngressStatus (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Ingress body, string pretty);
        /// <summary>
        ///  replace the specified NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy ReplaceExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy body, string pretty);
        /// <summary>
        ///  replace the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet ReplaceExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet body, string pretty);
        /// <summary>
        ///  replace status of the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet ReplaceExtensionsV1beta1NamespacedReplicaSetStatus (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet body, string pretty);
        /// <summary>
        ///  replace scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReplaceExtensionsV1beta1NamespacedReplicasetsScale (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Scale body, string pretty);
        /// <summary>
        ///  replace scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReplaceExtensionsV1beta1NamespacedReplicationcontrollersScale (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Scale body, string pretty);
        /// <summary>
        ///  replace the specified PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy ReplaceExtensionsV1beta1PodSecurityPolicy (string name, IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy body, string pretty);
        /// <summary>
        ///  replace the specified ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource</returns>
        IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource ReplaceExtensionsV1beta1ThirdPartyResource (string name, IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource body, string pretty);
        /// <summary>
        ///  watch individual changes to a list of DaemonSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1DaemonSetListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of Deployment
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1DeploymentListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of Ingress
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1IngressListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of DaemonSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedDaemonSetList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedDeployment (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedDeploymentList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedIngress (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of Ingress
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedIngressList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of NetworkPolicy
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedNetworkPolicyList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of ReplicaSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedReplicaSetList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of NetworkPolicy
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NetworkPolicyListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1PodSecurityPolicy (string name, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of PodSecurityPolicy
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1PodSecurityPolicyList (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of ReplicaSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1ReplicaSetListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1ThirdPartyResource (string name, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of ThirdPartyResource
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1ThirdPartyResourceList (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Extensions_v1beta1Api : IExtensions_v1beta1Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Extensions_v1beta1Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Extensions_v1beta1Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Extensions_v1beta1Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Extensions_v1beta1Api(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  create a DaemonSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet CreateExtensionsV1beta1NamespacedDaemonSet (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExtensionsV1beta1NamespacedDaemonSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet), response.Headers);
        }
    
        /// <summary>
        ///  create a Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Deployment CreateExtensionsV1beta1NamespacedDeployment (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Deployment body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExtensionsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  create rollback of a DeploymentRollback
        /// </summary>
        /// <param name="name">name of the DeploymentRollback</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentRollback</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentRollback CreateExtensionsV1beta1NamespacedDeploymentRollbackRollback (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentRollback body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CreateExtensionsV1beta1NamespacedDeploymentRollbackRollback");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateExtensionsV1beta1NamespacedDeploymentRollbackRollback");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExtensionsV1beta1NamespacedDeploymentRollbackRollback");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/rollback";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedDeploymentRollbackRollback: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedDeploymentRollbackRollback: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentRollback) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentRollback), response.Headers);
        }
    
        /// <summary>
        ///  create an Ingress
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Ingress CreateExtensionsV1beta1NamespacedIngress (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Ingress body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExtensionsV1beta1NamespacedIngress");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Ingress) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Ingress), response.Headers);
        }
    
        /// <summary>
        ///  create a NetworkPolicy
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy CreateExtensionsV1beta1NamespacedNetworkPolicy (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExtensionsV1beta1NamespacedNetworkPolicy");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedNetworkPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedNetworkPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy), response.Headers);
        }
    
        /// <summary>
        ///  create a ReplicaSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet CreateExtensionsV1beta1NamespacedReplicaSet (string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExtensionsV1beta1NamespacedReplicaSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1NamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet), response.Headers);
        }
    
        /// <summary>
        ///  create a PodSecurityPolicy
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy CreateExtensionsV1beta1PodSecurityPolicy (IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy body, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExtensionsV1beta1PodSecurityPolicy");
            
    
            var path = "/apis/extensions/v1beta1/podsecuritypolicies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1PodSecurityPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1PodSecurityPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy), response.Headers);
        }
    
        /// <summary>
        ///  create a ThirdPartyResource
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource CreateExtensionsV1beta1ThirdPartyResource (IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource body, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExtensionsV1beta1ThirdPartyResource");
            
    
            var path = "/apis/extensions/v1beta1/thirdpartyresources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1ThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExtensionsV1beta1ThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of DaemonSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedDaemonSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1CollectionNamespacedDaemonSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedDeployment (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1CollectionNamespacedDeployment");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of Ingress
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedIngress (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1CollectionNamespacedIngress");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of NetworkPolicy
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedNetworkPolicy (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1CollectionNamespacedNetworkPolicy");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedNetworkPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedNetworkPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of ReplicaSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionNamespacedReplicaSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1CollectionNamespacedReplicaSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionNamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of PodSecurityPolicy
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionPodSecurityPolicy (string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/podsecuritypolicies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionPodSecurityPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionPodSecurityPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of ThirdPartyResource
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1CollectionThirdPartyResource (string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/thirdpartyresources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1CollectionThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteExtensionsV1beta1NamespacedDaemonSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (gracePeriodSeconds != null) queryParams.Add("gracePeriodSeconds", ApiClient.ParameterToString(gracePeriodSeconds)); // query parameter
 if (orphanDependents != null) queryParams.Add("orphanDependents", ApiClient.ParameterToString(orphanDependents)); // query parameter
 if (propagationPolicy != null) queryParams.Add("propagationPolicy", ApiClient.ParameterToString(propagationPolicy)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteExtensionsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (gracePeriodSeconds != null) queryParams.Add("gracePeriodSeconds", ApiClient.ParameterToString(gracePeriodSeconds)); // query parameter
 if (orphanDependents != null) queryParams.Add("orphanDependents", ApiClient.ParameterToString(orphanDependents)); // query parameter
 if (propagationPolicy != null) queryParams.Add("propagationPolicy", ApiClient.ParameterToString(propagationPolicy)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete an Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedIngress (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteExtensionsV1beta1NamespacedIngress");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (gracePeriodSeconds != null) queryParams.Add("gracePeriodSeconds", ApiClient.ParameterToString(gracePeriodSeconds)); // query parameter
 if (orphanDependents != null) queryParams.Add("orphanDependents", ApiClient.ParameterToString(orphanDependents)); // query parameter
 if (propagationPolicy != null) queryParams.Add("propagationPolicy", ApiClient.ParameterToString(propagationPolicy)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteExtensionsV1beta1NamespacedNetworkPolicy");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (gracePeriodSeconds != null) queryParams.Add("gracePeriodSeconds", ApiClient.ParameterToString(gracePeriodSeconds)); // query parameter
 if (orphanDependents != null) queryParams.Add("orphanDependents", ApiClient.ParameterToString(orphanDependents)); // query parameter
 if (propagationPolicy != null) queryParams.Add("propagationPolicy", ApiClient.ParameterToString(propagationPolicy)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedNetworkPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedNetworkPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteExtensionsV1beta1NamespacedReplicaSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (gracePeriodSeconds != null) queryParams.Add("gracePeriodSeconds", ApiClient.ParameterToString(gracePeriodSeconds)); // query parameter
 if (orphanDependents != null) queryParams.Add("orphanDependents", ApiClient.ParameterToString(orphanDependents)); // query parameter
 if (propagationPolicy != null) queryParams.Add("propagationPolicy", ApiClient.ParameterToString(propagationPolicy)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1NamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1PodSecurityPolicy (string name, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteExtensionsV1beta1PodSecurityPolicy");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteExtensionsV1beta1PodSecurityPolicy");
            
    
            var path = "/apis/extensions/v1beta1/podsecuritypolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (gracePeriodSeconds != null) queryParams.Add("gracePeriodSeconds", ApiClient.ParameterToString(gracePeriodSeconds)); // query parameter
 if (orphanDependents != null) queryParams.Add("orphanDependents", ApiClient.ParameterToString(orphanDependents)); // query parameter
 if (propagationPolicy != null) queryParams.Add("propagationPolicy", ApiClient.ParameterToString(propagationPolicy)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1PodSecurityPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1PodSecurityPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteExtensionsV1beta1ThirdPartyResource (string name, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteExtensionsV1beta1ThirdPartyResource");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteExtensionsV1beta1ThirdPartyResource");
            
    
            var path = "/apis/extensions/v1beta1/thirdpartyresources/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (gracePeriodSeconds != null) queryParams.Add("gracePeriodSeconds", ApiClient.ParameterToString(gracePeriodSeconds)); // query parameter
 if (orphanDependents != null) queryParams.Add("orphanDependents", ApiClient.ParameterToString(orphanDependents)); // query parameter
 if (propagationPolicy != null) queryParams.Add("propagationPolicy", ApiClient.ParameterToString(propagationPolicy)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1ThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExtensionsV1beta1ThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>            
        public IoK8sApimachineryPkgApisMetaV1APIResourceList GetExtensionsV1beta1APIResources ()
        {
            
    
            var path = "/apis/extensions/v1beta1/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtensionsV1beta1APIResources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtensionsV1beta1APIResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1APIResourceList) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1APIResourceList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind DaemonSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList ListExtensionsV1beta1DaemonSetForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/daemonsets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1DaemonSetForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1DaemonSetForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind Deployment
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList ListExtensionsV1beta1DeploymentForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/deployments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1DeploymentForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1DeploymentForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind Ingress
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1IngressList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1IngressList ListExtensionsV1beta1IngressForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/ingresses";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1IngressForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1IngressForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1IngressList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1IngressList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind DaemonSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList ListExtensionsV1beta1NamespacedDaemonSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListExtensionsV1beta1NamespacedDaemonSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSetList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList ListExtensionsV1beta1NamespacedDeployment (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListExtensionsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DeploymentList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind Ingress
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1IngressList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1IngressList ListExtensionsV1beta1NamespacedIngress (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListExtensionsV1beta1NamespacedIngress");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1IngressList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1IngressList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind NetworkPolicy
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList ListExtensionsV1beta1NamespacedNetworkPolicy (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListExtensionsV1beta1NamespacedNetworkPolicy");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedNetworkPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedNetworkPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind ReplicaSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList ListExtensionsV1beta1NamespacedReplicaSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListExtensionsV1beta1NamespacedReplicaSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind NetworkPolicy
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList ListExtensionsV1beta1NetworkPolicyForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/networkpolicies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NetworkPolicyForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1NetworkPolicyForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicyList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind PodSecurityPolicy
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicyList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicyList ListExtensionsV1beta1PodSecurityPolicy (string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/podsecuritypolicies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1PodSecurityPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1PodSecurityPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicyList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicyList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind ReplicaSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList ListExtensionsV1beta1ReplicaSetForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/replicasets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1ReplicaSetForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1ReplicaSetForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSetList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind ThirdPartyResource
        /// </summary>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResourceList</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResourceList ListExtensionsV1beta1ThirdPartyResource (string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/thirdpartyresources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1ThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListExtensionsV1beta1ThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResourceList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResourceList), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet PatchExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedDaemonSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet), response.Headers);
        }
    
        /// <summary>
        ///  partially update status of the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet PatchExtensionsV1beta1NamespacedDaemonSetStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedDaemonSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedDaemonSetStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedDaemonSetStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDaemonSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDaemonSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Deployment PatchExtensionsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  partially update status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Deployment PatchExtensionsV1beta1NamespacedDeploymentStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedDeploymentStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  partially update scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale PatchExtensionsV1beta1NamespacedDeploymentsScale (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedDeploymentsScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedDeploymentsScale");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedDeploymentsScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDeploymentsScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedDeploymentsScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Ingress PatchExtensionsV1beta1NamespacedIngress (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedIngress");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Ingress) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Ingress), response.Headers);
        }
    
        /// <summary>
        ///  partially update status of the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Ingress PatchExtensionsV1beta1NamespacedIngressStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedIngressStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedIngressStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedIngressStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedIngressStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedIngressStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Ingress) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Ingress), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy PatchExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedNetworkPolicy");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedNetworkPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedNetworkPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet PatchExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedReplicaSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet), response.Headers);
        }
    
        /// <summary>
        ///  partially update status of the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet PatchExtensionsV1beta1NamespacedReplicaSetStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedReplicaSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedReplicaSetStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedReplicaSetStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedReplicaSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedReplicaSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet), response.Headers);
        }
    
        /// <summary>
        ///  partially update scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale PatchExtensionsV1beta1NamespacedReplicasetsScale (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedReplicasetsScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedReplicasetsScale");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedReplicasetsScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedReplicasetsScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedReplicasetsScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  partially update scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale PatchExtensionsV1beta1NamespacedReplicationcontrollersScale (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1NamespacedReplicationcontrollersScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchExtensionsV1beta1NamespacedReplicationcontrollersScale");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1NamespacedReplicationcontrollersScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedReplicationcontrollersScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1NamespacedReplicationcontrollersScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy PatchExtensionsV1beta1PodSecurityPolicy (string name, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1PodSecurityPolicy");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1PodSecurityPolicy");
            
    
            var path = "/apis/extensions/v1beta1/podsecuritypolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1PodSecurityPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1PodSecurityPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource PatchExtensionsV1beta1ThirdPartyResource (string name, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchExtensionsV1beta1ThirdPartyResource");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchExtensionsV1beta1ThirdPartyResource");
            
    
            var path = "/apis/extensions/v1beta1/thirdpartyresources/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1ThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchExtensionsV1beta1ThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource), response.Headers);
        }
    
        /// <summary>
        ///  read the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet ReadExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedDaemonSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet), response.Headers);
        }
    
        /// <summary>
        ///  read status of the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet ReadExtensionsV1beta1NamespacedDaemonSetStatus (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedDaemonSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedDaemonSetStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDaemonSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDaemonSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet), response.Headers);
        }
    
        /// <summary>
        ///  read the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Deployment ReadExtensionsV1beta1NamespacedDeployment (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  read status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Deployment ReadExtensionsV1beta1NamespacedDeploymentStatus (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedDeploymentStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  read scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReadExtensionsV1beta1NamespacedDeploymentsScale (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedDeploymentsScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedDeploymentsScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDeploymentsScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedDeploymentsScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  read the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Ingress ReadExtensionsV1beta1NamespacedIngress (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedIngress");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Ingress) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Ingress), response.Headers);
        }
    
        /// <summary>
        ///  read status of the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Ingress ReadExtensionsV1beta1NamespacedIngressStatus (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedIngressStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedIngressStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedIngressStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedIngressStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Ingress) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Ingress), response.Headers);
        }
    
        /// <summary>
        ///  read the specified NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy ReadExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedNetworkPolicy");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedNetworkPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedNetworkPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy), response.Headers);
        }
    
        /// <summary>
        ///  read the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet ReadExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedReplicaSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet), response.Headers);
        }
    
        /// <summary>
        ///  read status of the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet ReadExtensionsV1beta1NamespacedReplicaSetStatus (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedReplicaSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedReplicaSetStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedReplicaSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedReplicaSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet), response.Headers);
        }
    
        /// <summary>
        ///  read scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReadExtensionsV1beta1NamespacedReplicasetsScale (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedReplicasetsScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedReplicasetsScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedReplicasetsScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedReplicasetsScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  read scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReadExtensionsV1beta1NamespacedReplicationcontrollersScale (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1NamespacedReplicationcontrollersScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadExtensionsV1beta1NamespacedReplicationcontrollersScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedReplicationcontrollersScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1NamespacedReplicationcontrollersScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  read the specified PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy ReadExtensionsV1beta1PodSecurityPolicy (string name, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1PodSecurityPolicy");
            
    
            var path = "/apis/extensions/v1beta1/podsecuritypolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1PodSecurityPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1PodSecurityPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy), response.Headers);
        }
    
        /// <summary>
        ///  read the specified ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource ReadExtensionsV1beta1ThirdPartyResource (string name, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadExtensionsV1beta1ThirdPartyResource");
            
    
            var path = "/apis/extensions/v1beta1/thirdpartyresources/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (exact != null) queryParams.Add("exact", ApiClient.ParameterToString(exact)); // query parameter
 if (export != null) queryParams.Add("export", ApiClient.ParameterToString(export)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1ThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadExtensionsV1beta1ThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet ReplaceExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedDaemonSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet), response.Headers);
        }
    
        /// <summary>
        ///  replace status of the specified DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet ReplaceExtensionsV1beta1NamespacedDaemonSetStatus (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedDaemonSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedDaemonSetStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedDaemonSetStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/daemonsets/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDaemonSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDaemonSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1DaemonSet), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Deployment ReplaceExtensionsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Deployment body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  replace status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Deployment ReplaceExtensionsV1beta1NamespacedDeploymentStatus (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Deployment body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedDeploymentStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  replace scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReplaceExtensionsV1beta1NamespacedDeploymentsScale (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Scale body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedDeploymentsScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedDeploymentsScale");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedDeploymentsScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDeploymentsScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedDeploymentsScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Ingress ReplaceExtensionsV1beta1NamespacedIngress (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Ingress body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedIngress");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Ingress) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Ingress), response.Headers);
        }
    
        /// <summary>
        ///  replace status of the specified Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Ingress</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Ingress ReplaceExtensionsV1beta1NamespacedIngressStatus (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Ingress body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedIngressStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedIngressStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedIngressStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/ingresses/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedIngressStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedIngressStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Ingress) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Ingress), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy ReplaceExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedNetworkPolicy");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/networkpolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedNetworkPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedNetworkPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1NetworkPolicy), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet ReplaceExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedReplicaSet");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet), response.Headers);
        }
    
        /// <summary>
        ///  replace status of the specified ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet ReplaceExtensionsV1beta1NamespacedReplicaSetStatus (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedReplicaSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedReplicaSetStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedReplicaSetStatus");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedReplicaSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedReplicaSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ReplicaSet), response.Headers);
        }
    
        /// <summary>
        ///  replace scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReplaceExtensionsV1beta1NamespacedReplicasetsScale (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Scale body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedReplicasetsScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedReplicasetsScale");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedReplicasetsScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicasets/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedReplicasetsScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedReplicasetsScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  replace scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1Scale ReplaceExtensionsV1beta1NamespacedReplicationcontrollersScale (string name, string _namespace, IoK8sKubernetesPkgApisExtensionsV1beta1Scale body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1NamespacedReplicationcontrollersScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceExtensionsV1beta1NamespacedReplicationcontrollersScale");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1NamespacedReplicationcontrollersScale");
            
    
            var path = "/apis/extensions/v1beta1/namespaces/{namespace}/replicationcontrollers/{name}/scale";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedReplicationcontrollersScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1NamespacedReplicationcontrollersScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy ReplaceExtensionsV1beta1PodSecurityPolicy (string name, IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1PodSecurityPolicy");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1PodSecurityPolicy");
            
    
            var path = "/apis/extensions/v1beta1/podsecuritypolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1PodSecurityPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1PodSecurityPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1PodSecurityPolicy), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource</returns>            
        public IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource ReplaceExtensionsV1beta1ThirdPartyResource (string name, IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceExtensionsV1beta1ThirdPartyResource");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceExtensionsV1beta1ThirdPartyResource");
            
    
            var path = "/apis/extensions/v1beta1/thirdpartyresources/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1ThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceExtensionsV1beta1ThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisExtensionsV1beta1ThirdPartyResource), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of DaemonSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1DaemonSetListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/watch/daemonsets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1DaemonSetListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1DaemonSetListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of Deployment
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1DeploymentListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/watch/deployments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1DeploymentListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1DeploymentListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of Ingress
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1IngressListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/watch/ingresses";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1IngressListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1IngressListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind DaemonSet
        /// </summary>
        /// <param name="name">name of the DaemonSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedDaemonSet (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchExtensionsV1beta1NamespacedDaemonSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedDaemonSet");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/daemonsets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedDaemonSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedDaemonSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of DaemonSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedDaemonSetList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedDaemonSetList");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/daemonsets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedDaemonSetList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedDaemonSetList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedDeployment (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchExtensionsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/deployments/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedDeploymentList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedDeploymentList");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/deployments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedDeploymentList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedDeploymentList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind Ingress
        /// </summary>
        /// <param name="name">name of the Ingress</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedIngress (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchExtensionsV1beta1NamespacedIngress");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedIngress");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/ingresses/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedIngress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedIngress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of Ingress
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedIngressList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedIngressList");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/ingresses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedIngressList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedIngressList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind NetworkPolicy
        /// </summary>
        /// <param name="name">name of the NetworkPolicy</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedNetworkPolicy (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchExtensionsV1beta1NamespacedNetworkPolicy");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedNetworkPolicy");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/networkpolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedNetworkPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedNetworkPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of NetworkPolicy
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedNetworkPolicyList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedNetworkPolicyList");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/networkpolicies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedNetworkPolicyList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedNetworkPolicyList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind ReplicaSet
        /// </summary>
        /// <param name="name">name of the ReplicaSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedReplicaSet (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchExtensionsV1beta1NamespacedReplicaSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedReplicaSet");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/replicasets/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedReplicaSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedReplicaSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of ReplicaSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NamespacedReplicaSetList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchExtensionsV1beta1NamespacedReplicaSetList");
            
    
            var path = "/apis/extensions/v1beta1/watch/namespaces/{namespace}/replicasets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedReplicaSetList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NamespacedReplicaSetList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of NetworkPolicy
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1NetworkPolicyListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/watch/networkpolicies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NetworkPolicyListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1NetworkPolicyListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind PodSecurityPolicy
        /// </summary>
        /// <param name="name">name of the PodSecurityPolicy</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1PodSecurityPolicy (string name, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchExtensionsV1beta1PodSecurityPolicy");
            
    
            var path = "/apis/extensions/v1beta1/watch/podsecuritypolicies/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1PodSecurityPolicy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1PodSecurityPolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of PodSecurityPolicy
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1PodSecurityPolicyList (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/watch/podsecuritypolicies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1PodSecurityPolicyList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1PodSecurityPolicyList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of ReplicaSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1ReplicaSetListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/watch/replicasets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1ReplicaSetListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1ReplicaSetListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind ThirdPartyResource
        /// </summary>
        /// <param name="name">name of the ThirdPartyResource</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1ThirdPartyResource (string name, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchExtensionsV1beta1ThirdPartyResource");
            
    
            var path = "/apis/extensions/v1beta1/watch/thirdpartyresources/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1ThirdPartyResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1ThirdPartyResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of ThirdPartyResource
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchExtensionsV1beta1ThirdPartyResourceList (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/extensions/v1beta1/watch/thirdpartyresources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fieldSelector != null) queryParams.Add("fieldSelector", ApiClient.ParameterToString(fieldSelector)); // query parameter
 if (includeUninitialized != null) queryParams.Add("includeUninitialized", ApiClient.ParameterToString(includeUninitialized)); // query parameter
 if (labelSelector != null) queryParams.Add("labelSelector", ApiClient.ParameterToString(labelSelector)); // query parameter
 if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
 if (resourceVersion != null) queryParams.Add("resourceVersion", ApiClient.ParameterToString(resourceVersion)); // query parameter
 if (timeoutSeconds != null) queryParams.Add("timeoutSeconds", ApiClient.ParameterToString(timeoutSeconds)); // query parameter
 if (watch != null) queryParams.Add("watch", ApiClient.ParameterToString(watch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1ThirdPartyResourceList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchExtensionsV1beta1ThirdPartyResourceList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
    }
}
