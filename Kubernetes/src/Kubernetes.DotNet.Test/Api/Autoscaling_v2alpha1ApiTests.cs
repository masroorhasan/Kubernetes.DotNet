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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Model;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    ///  Class for testing Autoscaling_v2alpha1Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Autoscaling_v2alpha1ApiTests
    {
        private Autoscaling_v2alpha1Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Autoscaling_v2alpha1Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Autoscaling_v2alpha1Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Autoscaling_v2alpha1Api
            //Assert.IsInstanceOfType(typeof(Autoscaling_v2alpha1Api), instance, "instance is a Autoscaling_v2alpha1Api");
        }

        
        /// <summary>
        /// Test CreateNamespacedHorizontalPodAutoscaler
        /// </summary>
        [Test]
        public void CreateNamespacedHorizontalPodAutoscalerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //V2alpha1HorizontalPodAutoscaler body = null;
            //string pretty = null;
            //var response = instance.CreateNamespacedHorizontalPodAutoscaler(_namespace, body, pretty);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscaler> (response, "response is V2alpha1HorizontalPodAutoscaler");
        }
        
        /// <summary>
        /// Test DeleteCollectionNamespacedHorizontalPodAutoscaler
        /// </summary>
        [Test]
        public void DeleteCollectionNamespacedHorizontalPodAutoscalerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string pretty = null;
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.DeleteCollectionNamespacedHorizontalPodAutoscaler(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1Status> (response, "response is V1Status");
        }
        
        /// <summary>
        /// Test DeleteNamespacedHorizontalPodAutoscaler
        /// </summary>
        [Test]
        public void DeleteNamespacedHorizontalPodAutoscalerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //V1DeleteOptions body = null;
            //string pretty = null;
            //int? gracePeriodSeconds = null;
            //bool? orphanDependents = null;
            //string propagationPolicy = null;
            //var response = instance.DeleteNamespacedHorizontalPodAutoscaler(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents, propagationPolicy);
            //Assert.IsInstanceOf<V1Status> (response, "response is V1Status");
        }
        
        /// <summary>
        /// Test GetAPIResources
        /// </summary>
        [Test]
        public void GetAPIResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAPIResources();
            //Assert.IsInstanceOf<V1APIResourceList> (response, "response is V1APIResourceList");
        }
        
        /// <summary>
        /// Test ListHorizontalPodAutoscalerForAllNamespaces
        /// </summary>
        [Test]
        public void ListHorizontalPodAutoscalerForAllNamespacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string pretty = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.ListHorizontalPodAutoscalerForAllNamespaces(fieldSelector, includeUninitialized, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscalerList> (response, "response is V2alpha1HorizontalPodAutoscalerList");
        }
        
        /// <summary>
        /// Test ListNamespacedHorizontalPodAutoscaler
        /// </summary>
        [Test]
        public void ListNamespacedHorizontalPodAutoscalerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string pretty = null;
            //string fieldSelector = null;
            //bool? includeUninitialized = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.ListNamespacedHorizontalPodAutoscaler(_namespace, pretty, fieldSelector, includeUninitialized, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscalerList> (response, "response is V2alpha1HorizontalPodAutoscalerList");
        }
        
        /// <summary>
        /// Test PatchNamespacedHorizontalPodAutoscaler
        /// </summary>
        [Test]
        public void PatchNamespacedHorizontalPodAutoscalerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //Object body = null;
            //string pretty = null;
            //var response = instance.PatchNamespacedHorizontalPodAutoscaler(name, _namespace, body, pretty);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscaler> (response, "response is V2alpha1HorizontalPodAutoscaler");
        }
        
        /// <summary>
        /// Test PatchNamespacedHorizontalPodAutoscalerStatus
        /// </summary>
        [Test]
        public void PatchNamespacedHorizontalPodAutoscalerStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //Object body = null;
            //string pretty = null;
            //var response = instance.PatchNamespacedHorizontalPodAutoscalerStatus(name, _namespace, body, pretty);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscaler> (response, "response is V2alpha1HorizontalPodAutoscaler");
        }
        
        /// <summary>
        /// Test ReadNamespacedHorizontalPodAutoscaler
        /// </summary>
        [Test]
        public void ReadNamespacedHorizontalPodAutoscalerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //string pretty = null;
            //bool? exact = null;
            //bool? export = null;
            //var response = instance.ReadNamespacedHorizontalPodAutoscaler(name, _namespace, pretty, exact, export);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscaler> (response, "response is V2alpha1HorizontalPodAutoscaler");
        }
        
        /// <summary>
        /// Test ReadNamespacedHorizontalPodAutoscalerStatus
        /// </summary>
        [Test]
        public void ReadNamespacedHorizontalPodAutoscalerStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //string pretty = null;
            //var response = instance.ReadNamespacedHorizontalPodAutoscalerStatus(name, _namespace, pretty);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscaler> (response, "response is V2alpha1HorizontalPodAutoscaler");
        }
        
        /// <summary>
        /// Test ReplaceNamespacedHorizontalPodAutoscaler
        /// </summary>
        [Test]
        public void ReplaceNamespacedHorizontalPodAutoscalerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //V2alpha1HorizontalPodAutoscaler body = null;
            //string pretty = null;
            //var response = instance.ReplaceNamespacedHorizontalPodAutoscaler(name, _namespace, body, pretty);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscaler> (response, "response is V2alpha1HorizontalPodAutoscaler");
        }
        
        /// <summary>
        /// Test ReplaceNamespacedHorizontalPodAutoscalerStatus
        /// </summary>
        [Test]
        public void ReplaceNamespacedHorizontalPodAutoscalerStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string _namespace = null;
            //V2alpha1HorizontalPodAutoscaler body = null;
            //string pretty = null;
            //var response = instance.ReplaceNamespacedHorizontalPodAutoscalerStatus(name, _namespace, body, pretty);
            //Assert.IsInstanceOf<V2alpha1HorizontalPodAutoscaler> (response, "response is V2alpha1HorizontalPodAutoscaler");
        }
        
    }

}
