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
    public interface IBatch_v2alpha1Api
    {
        /// <summary>
        ///  create a CronJob
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob CreateBatchV2alpha1NamespacedCronJob (string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty);
        /// <summary>
        ///  create a ScheduledJob
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob CreateBatchV2alpha1NamespacedScheduledJob (string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty);
        /// <summary>
        ///  delete collection of CronJob
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
        IoK8sApimachineryPkgApisMetaV1Status DeleteBatchV2alpha1CollectionNamespacedCronJob (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete collection of ScheduledJob
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
        IoK8sApimachineryPkgApisMetaV1Status DeleteBatchV2alpha1CollectionNamespacedScheduledJob (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  delete a CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteBatchV2alpha1NamespacedCronJob (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  delete a ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param>
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param>
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>
        IoK8sApimachineryPkgApisMetaV1Status DeleteBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy);
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>
        IoK8sApimachineryPkgApisMetaV1APIResourceList GetBatchV2alpha1APIResources ();
        /// <summary>
        ///  list or watch objects of kind CronJob
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJobList</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJobList ListBatchV2alpha1CronJobForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind CronJob
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJobList</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJobList ListBatchV2alpha1NamespacedCronJob (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind ScheduledJob
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJobList</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJobList ListBatchV2alpha1NamespacedScheduledJob (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  list or watch objects of kind ScheduledJob
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJobList</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJobList ListBatchV2alpha1ScheduledJobForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  partially update the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob PatchBatchV2alpha1NamespacedCronJob (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update status of the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob PatchBatchV2alpha1NamespacedCronJobStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob PatchBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  partially update status of the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob PatchBatchV2alpha1NamespacedScheduledJobStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty);
        /// <summary>
        ///  read the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReadBatchV2alpha1NamespacedCronJob (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read status of the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReadBatchV2alpha1NamespacedCronJobStatus (string name, string _namespace, string pretty);
        /// <summary>
        ///  read the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param>
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReadBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, string pretty, bool? exact, bool? export);
        /// <summary>
        ///  read status of the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReadBatchV2alpha1NamespacedScheduledJobStatus (string name, string _namespace, string pretty);
        /// <summary>
        ///  replace the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReplaceBatchV2alpha1NamespacedCronJob (string name, string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty);
        /// <summary>
        ///  replace status of the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReplaceBatchV2alpha1NamespacedCronJobStatus (string name, string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty);
        /// <summary>
        ///  replace the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReplaceBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty);
        /// <summary>
        ///  replace status of the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>
        IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReplaceBatchV2alpha1NamespacedScheduledJobStatus (string name, string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty);
        /// <summary>
        ///  watch individual changes to a list of CronJob
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1CronJobListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1NamespacedCronJob (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of CronJob
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
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1NamespacedCronJobList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch changes to an object of kind ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of ScheduledJob
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
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1NamespacedScheduledJobList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
        /// <summary>
        ///  watch individual changes to a list of ScheduledJob
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param>
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param>
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param>
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param>
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param>
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>
        IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1ScheduledJobListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Batch_v2alpha1Api : IBatch_v2alpha1Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Batch_v2alpha1Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Batch_v2alpha1Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Batch_v2alpha1Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Batch_v2alpha1Api(String basePath)
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
        ///  create a CronJob
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob CreateBatchV2alpha1NamespacedCronJob (string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateBatchV2alpha1NamespacedCronJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBatchV2alpha1NamespacedCronJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBatchV2alpha1NamespacedCronJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  create a ScheduledJob
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob CreateBatchV2alpha1NamespacedScheduledJob (string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateBatchV2alpha1NamespacedScheduledJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBatchV2alpha1NamespacedScheduledJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBatchV2alpha1NamespacedScheduledJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of CronJob
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
        public IoK8sApimachineryPkgApisMetaV1Status DeleteBatchV2alpha1CollectionNamespacedCronJob (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteBatchV2alpha1CollectionNamespacedCronJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBatchV2alpha1CollectionNamespacedCronJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBatchV2alpha1CollectionNamespacedCronJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete collection of ScheduledJob
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
        public IoK8sApimachineryPkgApisMetaV1Status DeleteBatchV2alpha1CollectionNamespacedScheduledJob (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteBatchV2alpha1CollectionNamespacedScheduledJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBatchV2alpha1CollectionNamespacedScheduledJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBatchV2alpha1CollectionNamespacedScheduledJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteBatchV2alpha1NamespacedCronJob (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteBatchV2alpha1NamespacedCronJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBatchV2alpha1NamespacedCronJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBatchV2alpha1NamespacedCronJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  delete a ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="gracePeriodSeconds">The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.</param> 
        /// <param name="orphanDependents">Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both.</param> 
        /// <param name="propagationPolicy">Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1Status</returns>            
        public IoK8sApimachineryPkgApisMetaV1Status DeleteBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1DeleteOptions body, string pretty, int? gracePeriodSeconds, bool? orphanDependents, string propagationPolicy)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling DeleteBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteBatchV2alpha1NamespacedScheduledJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBatchV2alpha1NamespacedScheduledJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBatchV2alpha1NamespacedScheduledJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1Status) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1Status), response.Headers);
        }
    
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>            
        public IoK8sApimachineryPkgApisMetaV1APIResourceList GetBatchV2alpha1APIResources ()
        {
            
    
            var path = "/apis/batch/v2alpha1/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBatchV2alpha1APIResources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBatchV2alpha1APIResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1APIResourceList) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1APIResourceList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind CronJob
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJobList</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJobList ListBatchV2alpha1CronJobForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/batch/v2alpha1/cronjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListBatchV2alpha1CronJobForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBatchV2alpha1CronJobForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJobList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJobList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind CronJob
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJobList</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJobList ListBatchV2alpha1NamespacedCronJob (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListBatchV2alpha1NamespacedCronJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListBatchV2alpha1NamespacedCronJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBatchV2alpha1NamespacedCronJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJobList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJobList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind ScheduledJob
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJobList</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJobList ListBatchV2alpha1NamespacedScheduledJob (string _namespace, string pretty, string fieldSelector, bool? includeUninitialized, string labelSelector, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ListBatchV2alpha1NamespacedScheduledJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListBatchV2alpha1NamespacedScheduledJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBatchV2alpha1NamespacedScheduledJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJobList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJobList), response.Headers);
        }
    
        /// <summary>
        ///  list or watch objects of kind ScheduledJob
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJobList</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJobList ListBatchV2alpha1ScheduledJobForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/batch/v2alpha1/scheduledjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListBatchV2alpha1ScheduledJobForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBatchV2alpha1ScheduledJobForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJobList) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJobList), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob PatchBatchV2alpha1NamespacedCronJob (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchBatchV2alpha1NamespacedCronJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchBatchV2alpha1NamespacedCronJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchBatchV2alpha1NamespacedCronJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  partially update status of the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob PatchBatchV2alpha1NamespacedCronJobStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchBatchV2alpha1NamespacedCronJobStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchBatchV2alpha1NamespacedCronJobStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchBatchV2alpha1NamespacedCronJobStatus");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchBatchV2alpha1NamespacedCronJobStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchBatchV2alpha1NamespacedCronJobStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  partially update the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob PatchBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchBatchV2alpha1NamespacedScheduledJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchBatchV2alpha1NamespacedScheduledJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchBatchV2alpha1NamespacedScheduledJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  partially update status of the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob PatchBatchV2alpha1NamespacedScheduledJobStatus (string name, string _namespace, IoK8sApimachineryPkgApisMetaV1Patch body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PatchBatchV2alpha1NamespacedScheduledJobStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling PatchBatchV2alpha1NamespacedScheduledJobStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchBatchV2alpha1NamespacedScheduledJobStatus");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PatchBatchV2alpha1NamespacedScheduledJobStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchBatchV2alpha1NamespacedScheduledJobStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  read the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReadBatchV2alpha1NamespacedCronJob (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadBatchV2alpha1NamespacedCronJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadBatchV2alpha1NamespacedCronJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadBatchV2alpha1NamespacedCronJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  read status of the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReadBatchV2alpha1NamespacedCronJobStatus (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadBatchV2alpha1NamespacedCronJobStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadBatchV2alpha1NamespacedCronJobStatus");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadBatchV2alpha1NamespacedCronJobStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadBatchV2alpha1NamespacedCronJobStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  read the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="exact">Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39;.</param> 
        /// <param name="export">Should this value be exported.  Export strips fields that a user can not specify.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReadBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, string pretty, bool? exact, bool? export)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadBatchV2alpha1NamespacedScheduledJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadBatchV2alpha1NamespacedScheduledJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadBatchV2alpha1NamespacedScheduledJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  read status of the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReadBatchV2alpha1NamespacedScheduledJobStatus (string name, string _namespace, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReadBatchV2alpha1NamespacedScheduledJobStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReadBatchV2alpha1NamespacedScheduledJobStatus");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadBatchV2alpha1NamespacedScheduledJobStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadBatchV2alpha1NamespacedScheduledJobStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReplaceBatchV2alpha1NamespacedCronJob (string name, string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceBatchV2alpha1NamespacedCronJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceBatchV2alpha1NamespacedCronJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceBatchV2alpha1NamespacedCronJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  replace status of the specified CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReplaceBatchV2alpha1NamespacedCronJobStatus (string name, string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceBatchV2alpha1NamespacedCronJobStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceBatchV2alpha1NamespacedCronJobStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceBatchV2alpha1NamespacedCronJobStatus");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/cronjobs/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceBatchV2alpha1NamespacedCronJobStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceBatchV2alpha1NamespacedCronJobStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  replace the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReplaceBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceBatchV2alpha1NamespacedScheduledJob");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceBatchV2alpha1NamespacedScheduledJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceBatchV2alpha1NamespacedScheduledJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  replace status of the specified ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisBatchV2alpha1CronJob</returns>            
        public IoK8sKubernetesPkgApisBatchV2alpha1CronJob ReplaceBatchV2alpha1NamespacedScheduledJobStatus (string name, string _namespace, IoK8sKubernetesPkgApisBatchV2alpha1CronJob body, string pretty)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceBatchV2alpha1NamespacedScheduledJobStatus");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling ReplaceBatchV2alpha1NamespacedScheduledJobStatus");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceBatchV2alpha1NamespacedScheduledJobStatus");
            
    
            var path = "/apis/batch/v2alpha1/namespaces/{namespace}/scheduledjobs/{name}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceBatchV2alpha1NamespacedScheduledJobStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceBatchV2alpha1NamespacedScheduledJobStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisBatchV2alpha1CronJob) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisBatchV2alpha1CronJob), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of CronJob
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1CronJobListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/batch/v2alpha1/watch/cronjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1CronJobListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1CronJobListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind CronJob
        /// </summary>
        /// <param name="name">name of the CronJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1NamespacedCronJob (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchBatchV2alpha1NamespacedCronJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchBatchV2alpha1NamespacedCronJob");
            
    
            var path = "/apis/batch/v2alpha1/watch/namespaces/{namespace}/cronjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1NamespacedCronJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1NamespacedCronJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of CronJob
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
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1NamespacedCronJobList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchBatchV2alpha1NamespacedCronJobList");
            
    
            var path = "/apis/batch/v2alpha1/watch/namespaces/{namespace}/cronjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1NamespacedCronJobList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1NamespacedCronJobList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch changes to an object of kind ScheduledJob
        /// </summary>
        /// <param name="name">name of the ScheduledJob</param> 
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1NamespacedScheduledJob (string name, string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling WatchBatchV2alpha1NamespacedScheduledJob");
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchBatchV2alpha1NamespacedScheduledJob");
            
    
            var path = "/apis/batch/v2alpha1/watch/namespaces/{namespace}/scheduledjobs/{name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1NamespacedScheduledJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1NamespacedScheduledJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of ScheduledJob
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
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1NamespacedScheduledJobList (string _namespace, string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling WatchBatchV2alpha1NamespacedScheduledJobList");
            
    
            var path = "/apis/batch/v2alpha1/watch/namespaces/{namespace}/scheduledjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1NamespacedScheduledJobList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1NamespacedScheduledJobList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
        /// <summary>
        ///  watch individual changes to a list of ScheduledJob
        /// </summary>
        /// <param name="fieldSelector">A selector to restrict the list of returned objects by their fields. Defaults to everything.</param> 
        /// <param name="includeUninitialized">If true, partially initialized resources are included in the response.</param> 
        /// <param name="labelSelector">A selector to restrict the list of returned objects by their labels. Defaults to everything.</param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <param name="resourceVersion">When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.</param> 
        /// <param name="timeoutSeconds">Timeout for the list/watch call.</param> 
        /// <param name="watch">Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.</param> 
        /// <returns>IoK8sApimachineryPkgApisMetaV1WatchEvent</returns>            
        public IoK8sApimachineryPkgApisMetaV1WatchEvent WatchBatchV2alpha1ScheduledJobListForAllNamespaces (string fieldSelector, bool? includeUninitialized, string labelSelector, string pretty, string resourceVersion, int? timeoutSeconds, bool? watch)
        {
            
    
            var path = "/apis/batch/v2alpha1/watch/scheduledjobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1ScheduledJobListForAllNamespaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WatchBatchV2alpha1ScheduledJobListForAllNamespaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1WatchEvent) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1WatchEvent), response.Headers);
        }
    
    }
}
