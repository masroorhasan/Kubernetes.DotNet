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
    ///  Class for testing Custom_objectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Custom_objectsApiTests
    {
        private Custom_objectsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Custom_objectsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Custom_objectsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Custom_objectsApi
            //Assert.IsInstanceOfType(typeof(Custom_objectsApi), instance, "instance is a Custom_objectsApi");
        }

        
        /// <summary>
        /// Test CreateClusterCustomObject
        /// </summary>
        [Test]
        public void CreateClusterCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string plural = null;
            //Object body = null;
            //string pretty = null;
            //var response = instance.CreateClusterCustomObject(group, version, plural, body, pretty);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test CreateNamespacedCustomObject
        /// </summary>
        [Test]
        public void CreateNamespacedCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string _namespace = null;
            //string plural = null;
            //Object body = null;
            //string pretty = null;
            //var response = instance.CreateNamespacedCustomObject(group, version, _namespace, plural, body, pretty);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteClusterCustomObject
        /// </summary>
        [Test]
        public void DeleteClusterCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string plural = null;
            //string name = null;
            //V1DeleteOptions body = null;
            //int? gracePeriodSeconds = null;
            //bool? orphanDependents = null;
            //string propagationPolicy = null;
            //var response = instance.DeleteClusterCustomObject(group, version, plural, name, body, gracePeriodSeconds, orphanDependents, propagationPolicy);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteNamespacedCustomObject
        /// </summary>
        [Test]
        public void DeleteNamespacedCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string _namespace = null;
            //string plural = null;
            //string name = null;
            //V1DeleteOptions body = null;
            //int? gracePeriodSeconds = null;
            //bool? orphanDependents = null;
            //string propagationPolicy = null;
            //var response = instance.DeleteNamespacedCustomObject(group, version, _namespace, plural, name, body, gracePeriodSeconds, orphanDependents, propagationPolicy);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetClusterCustomObject
        /// </summary>
        [Test]
        public void GetClusterCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string plural = null;
            //string name = null;
            //var response = instance.GetClusterCustomObject(group, version, plural, name);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetNamespacedCustomObject
        /// </summary>
        [Test]
        public void GetNamespacedCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string _namespace = null;
            //string plural = null;
            //string name = null;
            //var response = instance.GetNamespacedCustomObject(group, version, _namespace, plural, name);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ListClusterCustomObject
        /// </summary>
        [Test]
        public void ListClusterCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string plural = null;
            //string pretty = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //bool? watch = null;
            //var response = instance.ListClusterCustomObject(group, version, plural, pretty, labelSelector, resourceVersion, watch);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ListNamespacedCustomObject
        /// </summary>
        [Test]
        public void ListNamespacedCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string _namespace = null;
            //string plural = null;
            //string pretty = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //bool? watch = null;
            //var response = instance.ListNamespacedCustomObject(group, version, _namespace, plural, pretty, labelSelector, resourceVersion, watch);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ReplaceClusterCustomObject
        /// </summary>
        [Test]
        public void ReplaceClusterCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string plural = null;
            //string name = null;
            //Object body = null;
            //var response = instance.ReplaceClusterCustomObject(group, version, plural, name, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ReplaceNamespacedCustomObject
        /// </summary>
        [Test]
        public void ReplaceNamespacedCustomObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string group = null;
            //string version = null;
            //string _namespace = null;
            //string plural = null;
            //string name = null;
            //Object body = null;
            //var response = instance.ReplaceNamespacedCustomObject(group, version, _namespace, plural, name, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
