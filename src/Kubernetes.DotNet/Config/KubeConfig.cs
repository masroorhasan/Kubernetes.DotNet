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
        public ClusterData ClusterData { get; set; }
    }

    /// <summary>
    /// The data associated with the <see cref="Cluster"/>.
    /// </summary>
    public class ClusterData
    {
        /// <summary>
        /// The server.
        /// </summary>
        [YamlMember(Alias = "server")]
        public string Server { get; set; }

        /// <summary>
        /// The CA data.
        /// </summary>
        [YamlMember(Alias = "certificate-authority-data")]
        public string CertificateAuthorityData { get; set; }

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
        public ContextData ContextData { get; set; }
    }

    /// <summary>
    /// The data associated with the <see cref="Context"/>.
    /// </summary>
    public class ContextData
    {
        /// <summary>
        /// The cluster.
        /// </summary>
        [YamlMember(Alias = "cluster")]
        public string Cluster { get; set; }

        /// <summary>
        /// The user.
        /// </summary>
        [YamlMember(Alias = "user")]
        public string User { get; set; }

        /// <summary>
        /// The namespace.
        /// </summary>
        [YamlMember(Alias = "namespace")]
        public string Namespace { get; set; } 
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
        public UserData UserData { get; set; }
    }

    /// <summary>
    /// The data associated with the <see cref="User"/>.
    /// </summary>
    public class UserData
    {
        /// <summary>
        /// The client certificate data.
        /// </summary>
        [YamlMember(Alias = "client-certificate-data")]
        public string ClientCertificateData { get; set; }

        /// <summary>
        /// The client key data.
        /// </summary>
        [YamlMember(Alias = "client-key-data")]
        public string ClientKeyData { get; set; }

        /// <summary>
        /// The token.
        /// </summary>
        [YamlMember(Alias = "token")]
        public String Token { get; set; }

        /// <summary>
        /// The user name.
        /// </summary>
        [YamlMember(Alias = "username")]
        public String UserName { get; set; }

        /// <summary>
        /// The password.
        /// </summary>
        [YamlMember(Alias = "password")]
        public String Password { get; set; }
    }
}