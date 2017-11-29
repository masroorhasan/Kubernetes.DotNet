using System;
using System.IO;
using System.Linq;
using Kubernetes.DotNet.Config;
using NUnit.Framework;

namespace Kubernetes.DotNet.Test
{
    /// <summary>
    /// Tests parsing logic to parse YAML kube config.
    /// </summary>
    [TestFixture]
    [Category("KubeConfigParsing")]
    public class KubeConfigParsingTests
    {
        /// <summary>
        /// The directory for all test resources.
        /// </summary>
        private static string TEST_RESOURCES_DIR = "Resources";

        /// <summary>
        /// The test kube config file.
        /// </summary>
        private static string TEST_KUBE_CONFIG = "valid-kube-config.yml";

        /// <summary>
        /// The test current context.
        /// </summary>
        private static string TEST_CURRENT_CONTEXT = "k8s-test-clustermgmt";

        /// <summary>
        /// The test config server endpoint.
        /// </summary>
        private static string TEST_CONFIG_SERVER_ENDPOINT = "https://k8s-dotnet-test.region.cloudapp.azure.com";

        /// <summary>
        /// The test config user.
        /// </summary>
        private static string TEST_CONFIG_USER = "k8s-test-clustermgmt-admin";

        /// <summary>
        /// Tests parsing of kube config on an invalid path.
        /// </summary>
        [Test]
        public void ParseKubeConfigInvalidPath()
        {
            Assert.Throws<Exception>(() => KubeConfigUtils.ParseKubeConfig("invalid\\path"));
        }

        /// <summary>
        /// Tests parsing of a valid kube config.
        /// </summary>
        [Test]
        public void ParseKubeConfigValidConfigFile()
        {
            string dirInfo = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            KubeConfig kubeConfig = KubeConfigUtils.ParseKubeConfig(
                Path.Combine(Path.Combine(dirInfo, KubeConfigParsingTests.TEST_RESOURCES_DIR), KubeConfigParsingTests.TEST_KUBE_CONFIG));

            // Validate
            Assert.IsNotNull(kubeConfig);
            CollectionAssert.IsNotEmpty(kubeConfig.Clusters);
            CollectionAssert.IsNotEmpty(kubeConfig.Contexts);
            CollectionAssert.IsNotEmpty(kubeConfig.Users);
            Assert.AreEqual("v1", kubeConfig.ApiVersion);
            Assert.AreEqual("Config", kubeConfig.Kind);
            Assert.AreEqual(KubeConfigParsingTests.TEST_CURRENT_CONTEXT, kubeConfig.CurrentContext);
            Assert.AreEqual(KubeConfigParsingTests.TEST_CONFIG_SERVER_ENDPOINT, kubeConfig.Clusters.FirstOrDefault().ClusterData.Server);
            Assert.AreEqual(KubeConfigParsingTests.TEST_CONFIG_USER, kubeConfig.Users.FirstOrDefault().Name);
        }
    }
}
