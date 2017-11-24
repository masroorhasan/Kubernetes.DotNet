using System;
using System.IO;
using System.Linq;
using Kubernetes.DotNet.Config;
using NUnit.Framework;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    [Category("KubeConfigParsing")]
    public class KubeConfigParsingTests
    {
        /// <summary>
        /// 
        /// </summary>
        private static string TEST_KUBE_CONFIG = "Resources\\valid-kube-config.yml";

        /// <summary>
        /// 
        /// </summary>
        private static string TEST_CURRENT_CONTEXT = "k8s-test-clustermgmt";

        /// <summary>
        /// 
        /// </summary>
        private static string TEST_CONFIG_SERVER_ENDPOINT = "https://k8s-dotnet-test.region.cloudapp.azure.com";

        /// <summary>
        /// 
        /// </summary>
        private static string TEST_CONFIG_USER = "k8s-test-clustermgmt-admin";

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void ParseKubeConfigInvalidPath()
        {
            Assert.Throws<Exception>(() => KubeConfigUtils.ParseKubeConfig("invalid\\path"));
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void ParseKubeConfigValidConfigFile()
        {
            string dirInfo = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            KubeConfig kubeConfig = KubeConfigUtils.ParseKubeConfig(Path.Combine(dirInfo, KubeConfigParsingTests.TEST_KUBE_CONFIG));

            // Validate
            Assert.IsNotNull(kubeConfig);
            CollectionAssert.IsNotEmpty(kubeConfig.Clusters);
            CollectionAssert.IsNotEmpty(kubeConfig.Contexts);
            CollectionAssert.IsNotEmpty(kubeConfig.Users);
            Assert.AreEqual("v1", kubeConfig.ApiVersion);
            Assert.AreEqual("Config", kubeConfig.Kind);
            Assert.AreEqual(KubeConfigParsingTests.TEST_CURRENT_CONTEXT, kubeConfig.CurrentContext);
            Assert.AreEqual(KubeConfigParsingTests.TEST_CONFIG_SERVER_ENDPOINT, kubeConfig.Clusters?.FirstOrDefault().ClusterData.Server);
            Assert.AreEqual(KubeConfigParsingTests.TEST_CONFIG_USER, kubeConfig.Users?.FirstOrDefault().Name);
        }
    }
}
