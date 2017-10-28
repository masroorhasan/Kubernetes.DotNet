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
    ///  Class for testing Authorization_v1Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Authorization_v1ApiTests
    {
        private Authorization_v1Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Authorization_v1Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Authorization_v1Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Authorization_v1Api
            //Assert.IsInstanceOfType(typeof(Authorization_v1Api), instance, "instance is a Authorization_v1Api");
        }

        
        /// <summary>
        /// Test CreateNamespacedLocalSubjectAccessReview
        /// </summary>
        [Test]
        public void CreateNamespacedLocalSubjectAccessReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //V1LocalSubjectAccessReview body = null;
            //string pretty = null;
            //var response = instance.CreateNamespacedLocalSubjectAccessReview(_namespace, body, pretty);
            //Assert.IsInstanceOf<V1LocalSubjectAccessReview> (response, "response is V1LocalSubjectAccessReview");
        }
        
        /// <summary>
        /// Test CreateSelfSubjectAccessReview
        /// </summary>
        [Test]
        public void CreateSelfSubjectAccessReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //V1SelfSubjectAccessReview body = null;
            //string pretty = null;
            //var response = instance.CreateSelfSubjectAccessReview(body, pretty);
            //Assert.IsInstanceOf<V1SelfSubjectAccessReview> (response, "response is V1SelfSubjectAccessReview");
        }
        
        /// <summary>
        /// Test CreateSubjectAccessReview
        /// </summary>
        [Test]
        public void CreateSubjectAccessReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //V1SubjectAccessReview body = null;
            //string pretty = null;
            //var response = instance.CreateSubjectAccessReview(body, pretty);
            //Assert.IsInstanceOf<V1SubjectAccessReview> (response, "response is V1SubjectAccessReview");
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
        
    }

}
