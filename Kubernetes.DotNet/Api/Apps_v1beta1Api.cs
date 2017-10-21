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
    public interface IApps_v1beta1Api
    {
        /// <summary>
        ///  create a ControllerRevision
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision</returns>
        IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision CreateAppsV1beta1NamespacedControllerRevision (string _namespace, IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision body, string pretty);
        /// <summary>
        ///  create a Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Deployment CreateAppsV1beta1NamespacedDeployment (string _namespace, IoK8sKubernetesPkgApisAppsV1beta1Deployment body, string pretty);
        /// <summary>
        ///  create rollback of a DeploymentRollback
        /// </summary>
        /// <param name="name">name of the DeploymentRollback</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1DeploymentRollback</returns>
        IoK8sKubernetesPkgApisAppsV1beta1DeploymentRollback CreateAppsV1beta1NamespacedDeploymentRollbackRollback (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1DeploymentRollback body, string pretty);
        /// <summary>
        ///  create a StatefulSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSet CreateAppsV1beta1NamespacedStatefulSet (string _namespace, IoK8sKubernetesPkgApisAppsV1beta1StatefulSet body, string pretty);
        /// <summary>
        ///  delete collection of ControllerRevision
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
        IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1CollectionNamespacedControllerRevision (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
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
        IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1CollectionNamespacedDeployment (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete collection of StatefulSet
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
        IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1CollectionNamespacedStatefulSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete a ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1NamespacedControllerRevision (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
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
        IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  delete a StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1NamespacedStatefulSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>
        IoK8sApimachineryPkgApisMetaV1APIResourceList GetAppsV1beta1APIResources ();
        /// <summary>
        ///  list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList</returns>
        IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList ListAppsV1beta1ControllerRevisionForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
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
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1DeploymentList</returns>
        IoK8sKubernetesPkgApisAppsV1beta1DeploymentList ListAppsV1beta1DeploymentForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList</returns>
        IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList ListAppsV1beta1NamespacedControllerRevision (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
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
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1DeploymentList</returns>
        IoK8sKubernetesPkgApisAppsV1beta1DeploymentList ListAppsV1beta1NamespacedDeployment (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList ListAppsV1beta1NamespacedStatefulSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList ListAppsV1beta1StatefulSetForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  partially update the specified ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision</returns>
        IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision PatchAppsV1beta1NamespacedControllerRevision (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Deployment PatchAppsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Deployment PatchAppsV1beta1NamespacedDeploymentStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Scale PatchAppsV1beta1NamespacedScaleScale (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSet PatchAppsV1beta1NamespacedStatefulSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update status of the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSet PatchAppsV1beta1NamespacedStatefulSetStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  read the specified ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision</returns>
        IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision ReadAppsV1beta1NamespacedControllerRevision (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Deployment ReadAppsV1beta1NamespacedDeployment (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Deployment ReadAppsV1beta1NamespacedDeploymentStatus (string name, string _namespace, string pretty);
        /// <summary>
        ///  read scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Scale ReadAppsV1beta1NamespacedScaleScale (string name, string _namespace, string pretty);
        /// <summary>
        ///  read the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSet ReadAppsV1beta1NamespacedStatefulSet (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read status of the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSet ReadAppsV1beta1NamespacedStatefulSetStatus (string name, string _namespace, string pretty);
        /// <summary>
        ///  replace the specified ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision</returns>
        IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision ReplaceAppsV1beta1NamespacedControllerRevision (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision body, string pretty);
        /// <summary>
        ///  replace the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Deployment ReplaceAppsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1Deployment body, string pretty);
        /// <summary>
        ///  replace status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Deployment ReplaceAppsV1beta1NamespacedDeploymentStatus (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1Deployment body, string pretty);
        /// <summary>
        ///  replace scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Scale</returns>
        IoK8sKubernetesPkgApisAppsV1beta1Scale ReplaceAppsV1beta1NamespacedScaleScale (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1Scale body, string pretty);
        /// <summary>
        ///  replace the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSet ReplaceAppsV1beta1NamespacedStatefulSet (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1StatefulSet body, string pretty);
        /// <summary>
        ///  replace status of the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>
        IoK8sKubernetesPkgApisAppsV1beta1StatefulSet ReplaceAppsV1beta1NamespacedStatefulSetStatus (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1StatefulSet body, string pretty);
        /// <summary>
        ///  watch individual changes to a list of ControllerRevision
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1ControllerRevisionListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
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
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1DeploymentListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedControllerRevision (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of ControllerRevision
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
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedControllerRevisionList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
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
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedDeployment (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
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
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedDeploymentList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedStatefulSet (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of StatefulSet
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
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedStatefulSetList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of StatefulSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1StatefulSetListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Apps_v1beta1Api : IApps_v1beta1Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apps_v1beta1Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Apps_v1beta1Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Apps_v1beta1Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Apps_v1beta1Api(String basePath)
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
        ///  create a ControllerRevision
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision CreateAppsV1beta1NamespacedControllerRevision (string _namespace, IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAppsV1beta1NamespacedControllerRevision");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/controllerrevisions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAppsV1beta1NamespacedControllerRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAppsV1beta1NamespacedControllerRevision: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision), response.Headers);
        }
    
        /// <summary>
        ///  create a Deployment
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Deployment CreateAppsV1beta1NamespacedDeployment (string _namespace, IoK8sKubernetesPkgApisAppsV1beta1Deployment body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAppsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAppsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAppsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  create rollback of a DeploymentRollback
        /// </summary>
        /// <param name="name">name of the DeploymentRollback</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1DeploymentRollback</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1DeploymentRollback CreateAppsV1beta1NamespacedDeploymentRollbackRollback (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1DeploymentRollback body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CreateAppsV1beta1NamespacedDeploymentRollbackRollback");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateAppsV1beta1NamespacedDeploymentRollbackRollback");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAppsV1beta1NamespacedDeploymentRollbackRollback");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}/rollback";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAppsV1beta1NamespacedDeploymentRollbackRollback: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAppsV1beta1NamespacedDeploymentRollbackRollback: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1DeploymentRollback) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1DeploymentRollback), response.Headers);
        }
    
        /// <summary>
        ///  create a StatefulSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSet CreateAppsV1beta1NamespacedStatefulSet (string _namespace, IoK8sKubernetesPkgApisAppsV1beta1StatefulSet body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAppsV1beta1NamespacedStatefulSet");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAppsV1beta1NamespacedStatefulSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAppsV1beta1NamespacedStatefulSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSet), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of ControllerRevision
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
        public IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1CollectionNamespacedControllerRevision (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteAppsV1beta1CollectionNamespacedControllerRevision");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/controllerrevisions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1CollectionNamespacedControllerRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1CollectionNamespacedControllerRevision: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1CollectionNamespacedDeployment (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteAppsV1beta1CollectionNamespacedDeployment");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1CollectionNamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1CollectionNamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of StatefulSet
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
        public IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1CollectionNamespacedStatefulSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteAppsV1beta1CollectionNamespacedStatefulSet");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1CollectionNamespacedStatefulSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1CollectionNamespacedStatefulSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1NamespacedControllerRevision (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteAppsV1beta1NamespacedControllerRevision");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/controllerrevisions/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1NamespacedControllerRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1NamespacedControllerRevision: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteAppsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteAppsV1beta1NamespacedStatefulSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteAppsV1beta1NamespacedStatefulSet");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1NamespacedStatefulSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAppsV1beta1NamespacedStatefulSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>            
        public IoK8sApimachineryPkgApisMetaV1APIResourceList GetAppsV1beta1APIResources ()
        {
            
    
            var path = "/apis/apps/v1beta1/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAppsV1beta1APIResources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAppsV1beta1APIResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1APIResourceList) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1APIResourceList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList ListAppsV1beta1ControllerRevisionForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/apps/v1beta1/controllerrevisions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1ControllerRevisionForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1ControllerRevisionForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList), response.Headers);
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
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1DeploymentList</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1DeploymentList ListAppsV1beta1DeploymentForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/apps/v1beta1/deployments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1DeploymentForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1DeploymentForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1DeploymentList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1DeploymentList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList ListAppsV1beta1NamespacedControllerRevision (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListAppsV1beta1NamespacedControllerRevision");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/controllerrevisions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1NamespacedControllerRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1NamespacedControllerRevision: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1ControllerRevisionList), response.Headers);
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
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1DeploymentList</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1DeploymentList ListAppsV1beta1NamespacedDeployment (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListAppsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1DeploymentList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1DeploymentList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList ListAppsV1beta1NamespacedStatefulSet (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListAppsV1beta1NamespacedStatefulSet");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1NamespacedStatefulSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1NamespacedStatefulSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList ListAppsV1beta1StatefulSetForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/apps/v1beta1/statefulsets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1StatefulSetForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAppsV1beta1StatefulSetForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSetList), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision PatchAppsV1beta1NamespacedControllerRevision (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchAppsV1beta1NamespacedControllerRevision");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/controllerrevisions/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedControllerRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedControllerRevision: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Deployment PatchAppsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchAppsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  partially update status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Deployment PatchAppsV1beta1NamespacedDeploymentStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchAppsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchAppsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchAppsV1beta1NamespacedDeploymentStatus");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  partially update scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Scale PatchAppsV1beta1NamespacedScaleScale (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchAppsV1beta1NamespacedScaleScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchAppsV1beta1NamespacedScaleScale");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchAppsV1beta1NamespacedScaleScale");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedScaleScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedScaleScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSet PatchAppsV1beta1NamespacedStatefulSet (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchAppsV1beta1NamespacedStatefulSet");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedStatefulSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedStatefulSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSet), response.Headers);
        }
    
        /// <summary>
        ///  partially update status of the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSet PatchAppsV1beta1NamespacedStatefulSetStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchAppsV1beta1NamespacedStatefulSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchAppsV1beta1NamespacedStatefulSetStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchAppsV1beta1NamespacedStatefulSetStatus");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedStatefulSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchAppsV1beta1NamespacedStatefulSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSet), response.Headers);
        }
    
        /// <summary>
        ///  read the specified ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision ReadAppsV1beta1NamespacedControllerRevision (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadAppsV1beta1NamespacedControllerRevision");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/controllerrevisions/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedControllerRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedControllerRevision: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision), response.Headers);
        }
    
        /// <summary>
        ///  read the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Deployment ReadAppsV1beta1NamespacedDeployment (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadAppsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  read status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Deployment ReadAppsV1beta1NamespacedDeploymentStatus (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadAppsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadAppsV1beta1NamespacedDeploymentStatus");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  read scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Scale ReadAppsV1beta1NamespacedScaleScale (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadAppsV1beta1NamespacedScaleScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadAppsV1beta1NamespacedScaleScale");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedScaleScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedScaleScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  read the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSet ReadAppsV1beta1NamespacedStatefulSet (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadAppsV1beta1NamespacedStatefulSet");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedStatefulSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedStatefulSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSet), response.Headers);
        }
    
        /// <summary>
        ///  read status of the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSet ReadAppsV1beta1NamespacedStatefulSetStatus (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadAppsV1beta1NamespacedStatefulSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadAppsV1beta1NamespacedStatefulSetStatus");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedStatefulSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAppsV1beta1NamespacedStatefulSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSet), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision ReplaceAppsV1beta1NamespacedControllerRevision (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceAppsV1beta1NamespacedControllerRevision");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/controllerrevisions/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedControllerRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedControllerRevision: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1ControllerRevision), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Deployment ReplaceAppsV1beta1NamespacedDeployment (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1Deployment body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceAppsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  replace status of the specified Deployment
        /// </summary>
        /// <param name="name">name of the Deployment</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Deployment</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Deployment ReplaceAppsV1beta1NamespacedDeploymentStatus (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1Deployment body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceAppsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceAppsV1beta1NamespacedDeploymentStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceAppsV1beta1NamespacedDeploymentStatus");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Deployment) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Deployment), response.Headers);
        }
    
        /// <summary>
        ///  replace scale of the specified Scale
        /// </summary>
        /// <param name="name">name of the Scale</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1Scale</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1Scale ReplaceAppsV1beta1NamespacedScaleScale (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1Scale body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceAppsV1beta1NamespacedScaleScale");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceAppsV1beta1NamespacedScaleScale");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceAppsV1beta1NamespacedScaleScale");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/deployments/{name}/scale";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedScaleScale: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedScaleScale: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1Scale) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1Scale), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSet ReplaceAppsV1beta1NamespacedStatefulSet (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1StatefulSet body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceAppsV1beta1NamespacedStatefulSet");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedStatefulSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedStatefulSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSet), response.Headers);
        }
    
        /// <summary>
        ///  replace status of the specified StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAppsV1beta1StatefulSet</returns>            
        public IoK8sKubernetesPkgApisAppsV1beta1StatefulSet ReplaceAppsV1beta1NamespacedStatefulSetStatus (string name, string _namespace, IoK8sKubernetesPkgApisAppsV1beta1StatefulSet body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceAppsV1beta1NamespacedStatefulSetStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceAppsV1beta1NamespacedStatefulSetStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceAppsV1beta1NamespacedStatefulSetStatus");
            
    
            var path = "/apis/apps/v1beta1/namespaces/{namespace}/statefulsets/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedStatefulSetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceAppsV1beta1NamespacedStatefulSetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAppsV1beta1StatefulSet) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAppsV1beta1StatefulSet), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of ControllerRevision
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1ControllerRevisionListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/apps/v1beta1/watch/controllerrevisions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1ControllerRevisionListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1ControllerRevisionListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1DeploymentListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/apps/v1beta1/watch/deployments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1DeploymentListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1DeploymentListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind ControllerRevision
        /// </summary>
        /// <param name="name">name of the ControllerRevision</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedControllerRevision (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchAppsV1beta1NamespacedControllerRevision");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchAppsV1beta1NamespacedControllerRevision");
            
    
            var path = "/apis/apps/v1beta1/watch/namespaces/{namespace}/controllerrevisions/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedControllerRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedControllerRevision: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of ControllerRevision
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
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedControllerRevisionList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchAppsV1beta1NamespacedControllerRevisionList");
            
    
            var path = "/apis/apps/v1beta1/watch/namespaces/{namespace}/controllerrevisions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedControllerRevisionList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedControllerRevisionList: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedDeployment (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchAppsV1beta1NamespacedDeployment");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchAppsV1beta1NamespacedDeployment");
            
    
            var path = "/apis/apps/v1beta1/watch/namespaces/{namespace}/deployments/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedDeployment: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedDeploymentList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchAppsV1beta1NamespacedDeploymentList");
            
    
            var path = "/apis/apps/v1beta1/watch/namespaces/{namespace}/deployments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedDeploymentList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedDeploymentList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind StatefulSet
        /// </summary>
        /// <param name="name">name of the StatefulSet</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedStatefulSet (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchAppsV1beta1NamespacedStatefulSet");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchAppsV1beta1NamespacedStatefulSet");
            
    
            var path = "/apis/apps/v1beta1/watch/namespaces/{namespace}/statefulsets/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedStatefulSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedStatefulSet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of StatefulSet
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
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1NamespacedStatefulSetList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchAppsV1beta1NamespacedStatefulSetList");
            
    
            var path = "/apis/apps/v1beta1/watch/namespaces/{namespace}/statefulsets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedStatefulSetList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1NamespacedStatefulSetList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of StatefulSet
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchAppsV1beta1StatefulSetListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/apps/v1beta1/watch/statefulsets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1StatefulSetListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchAppsV1beta1StatefulSetListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
    }
}
