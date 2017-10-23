using System;
using System.IO;
using YamlDotNet.Serialization;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// A utility class to for K8s config.
    /// </summary>
    public static class ConfigUtils
    {
        private static string KUBE_PATH = ".kube";
        private static string KUBE_CONFIG = "config";
        private static string WINDOWS_HOMEPATH = "USERPROFILE";
        private static string UNIX_HOMEPATH = "HOME";

        /// <summary>
        /// Parses a /.kube/config from path to <see cref="KubeConfig"/>.
        /// </summary>
        /// <returns><see cref="KubeConfig"/>.</returns>
        public static KubeConfig ParseKubeConfig()
        {
            FileInfo kubeConfigFileInfo = new FileInfo(
                ConfigUtils.GetHomeDirectory() + Path.DirectorySeparatorChar + 
                ConfigUtils.KUBE_PATH + Path.DirectorySeparatorChar + 
                ConfigUtils.KUBE_CONFIG
            );
            KubeConfig config = default(KubeConfig);
            using (StreamReader reader = File.OpenText(kubeConfigFileInfo.FullName))
            {
                config = new Deserializer().Deserialize<KubeConfig>(reader);
            }
            return config;
        }

        /// <summary>
        /// Gets the home directory from environment variable.
        /// </summary>
        /// <returns>The home directory path.</returns>
        private static string GetHomeDirectory()
        {
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
                return Environment.GetEnvironmentVariable(ConfigUtils.WINDOWS_HOMEPATH);
            return Environment.GetEnvironmentVariable(UNIX_HOMEPATH);
        }
    }
}