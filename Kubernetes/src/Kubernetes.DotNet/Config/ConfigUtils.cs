using System;
using System.IO;
using YamlDotNet.Serialization;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// Defines the utility class for managing kube config.
    /// </summary>
    public static class ConfigUtils
    {
        /// <summary>
        /// The KubeConfig path.
        /// </summary>
        private static string KUBE_CLIENT_CONFIG_PATH = ".kube\\config";

        /// <summary>
        /// The home path environment variable in Windows platform.
        /// </summary>
        private static string WINDOWS_HOMEPATH = "USERPROFILE";

        /// <summary>
        /// The home path environment variable in Unix platform.
        /// </summary>
        private static string UNIX_HOMEPATH = "HOME";

        /// <summary>
        /// Parses kubernetes config from specified path to <see cref="KubeConfig"/> object.
        /// </summary>
        /// <returns>The <see cref="KubeConfig"/>.</returns>
        public static KubeConfig ParseKubeConfig()
        {
            FileInfo kubeConfigFileInfo = new FileInfo(
                ConfigUtils.GetHomeDirectory() + Path.DirectorySeparatorChar + ConfigUtils.KUBE_CLIENT_CONFIG_PATH 
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
            if (Environment.OSVersion.ToString().Contains("Windows"))
                return Environment.GetEnvironmentVariable(ConfigUtils.WINDOWS_HOMEPATH);
            return Environment.GetEnvironmentVariable(UNIX_HOMEPATH);
        }
    }
}