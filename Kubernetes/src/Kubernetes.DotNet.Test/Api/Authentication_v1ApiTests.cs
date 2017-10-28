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
    ///  Class for testing Authentication_v1Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Authentication_v1ApiTests
    {
        private Authentication_v1Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Authentication_v1Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Authentication_v1Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Authentication_v1Api
            //Assert.IsInstanceOfType(typeof(Authentication_v1Api), instance, "instance is a Authentication_v1Api");
        }

        
        /// <summary>
        /// Test CreateTokenReview
        /// </summary>
        [Test]
        public void CreateTokenReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //V1TokenReview body = null;
            //string pretty = null;
            //var response = instance.CreateTokenReview(body, pretty);
            //Assert.IsInstanceOf<V1TokenReview> (response, "response is V1TokenReview");
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
