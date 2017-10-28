using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// Represents the client K8s config available in $HOME/.kube/config.
    /// </summary>
    public class KubeConfig
    {
        /// <summary>
        /// The API version.
        /// </summary>
        [YamlMember(Alias = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The list of clusters.
        /// </summary>
        [YamlMember(Alias = "clusters")]
        public List<Cluster> Clusters { get; set; }

        /// <summary>
        /// The list of contexts.
        /// </summary>
        [YamlMember(Alias = "contexts")]
        public List<Context> Contexts { get; set; }

        /// <summary>
        /// The current context.
        /// </summary>
        [YamlMember(Alias = "current-context")]
        public string CurrentContext { get; set; }

        /// <summary>
        /// The resource "Kind".
        /// </summary>
        [YamlMember(Alias = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Preferences.
        /// </summary>
        [YamlMember(Alias = "preferences")]
        public Dictionary<string, string> Preferences { get; set; }

        /// <summary>
        /// The list of users.
        /// </summary>
        [YamlMember(Alias = "users")]
        public List<User> Users { get; set; }
    }

    /// <summary>
    /// Represents the cluster definition in kube config.
    /// </summary>
    public class Cluster
    {
        /// <summary>
        /// The name.
        /// </summary>
        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Data associated with cluster as key value pairs.
        /// </summary>
        [YamlMember(Alias = "cluster")]
        public Dictionary<string, string> ClusterData { get; set; }
    }

    /// <summary>
    /// Represents the definition in kube config.
    /// </summary>
    public class Context
    {
        /// <summary>
        /// The name.
        /// </summary>
        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Data associated with context as key value pairs.
        /// </summary>
        [YamlMember(Alias = "context")]
        public Dictionary<string, string> ContextData { get; set; }
    }

    /// <summary>
    /// Represents the definition in kube config.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The name.
        /// </summary>
        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Data associated with context as key value pairs.
        /// </summary>
        [YamlMember(Alias = "user")]
        public Dictionary<string, string> UserData { get; set; }
    }
}