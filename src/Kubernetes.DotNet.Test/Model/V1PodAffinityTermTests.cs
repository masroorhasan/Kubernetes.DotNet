/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Kubernetes.DotNet.Api;
using Kubernetes.DotNet.Model;
using Kubernetes.DotNet.Client;
using System.Reflection;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    ///  Class for testing V1PodAffinityTerm
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class V1PodAffinityTermTests
    {
        // TODO uncomment below to declare an instance variable for V1PodAffinityTerm
        //private V1PodAffinityTerm instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of V1PodAffinityTerm
            //instance = new V1PodAffinityTerm();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of V1PodAffinityTerm
        /// </summary>
        [Test]
        public void V1PodAffinityTermInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" V1PodAffinityTerm
            //Assert.IsInstanceOfType<V1PodAffinityTerm> (instance, "variable 'instance' is a V1PodAffinityTerm");
        }

        /// <summary>
        /// Test the property 'LabelSelector'
        /// </summary>
        [Test]
        public void LabelSelectorTest()
        {
            // TODO unit test for the property 'LabelSelector'
        }
        /// <summary>
        /// Test the property 'Namespaces'
        /// </summary>
        [Test]
        public void NamespacesTest()
        {
            // TODO unit test for the property 'Namespaces'
        }
        /// <summary>
        /// Test the property 'TopologyKey'
        /// </summary>
        [Test]
        public void TopologyKeyTest()
        {
            // TODO unit test for the property 'TopologyKey'
        }

    }

}