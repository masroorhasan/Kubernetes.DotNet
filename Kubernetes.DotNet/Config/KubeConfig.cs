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
        [YamlMember(Alias = "apiVersion")]
        public string ApiVersion {get; set;}

        [YamlMember(Alias = "clusters")]
        public List<Cluster> Clusters {get; set;}

        [YamlMember(Alias = "contexts")]
        public List<Context> Contexts {get; set;}

        [YamlMember(Alias = "current-context")]
        public string CurrentContext {get; set;}

        [YamlMember(Alias = "kind")]
        public string Kind {get; set;}

        [YamlMember(Alias = "preferences")]
        public Dictionary<string, string> Preferences {get; set;}

        [YamlMember(Alias = "users")]
        public List<User> Users {get; set;}
    }

    /// <summary>
    /// The cluster definition in kube config.
    /// </summary>
    public class Cluster
    {
        [YamlMember(Alias = "name")]
        public string Name {get; set;}

        [YamlMember(Alias = "cluster")]
        public Dictionary<string, string> ClusterData {get; set;}
    }

    /// <summary>
    /// The context definition in kube config.
    /// </summary>
    public class Context
    {
        [YamlMember(Alias = "name")]
        public string Name {get; set;}

        [YamlMember(Alias = "context")]
        public Dictionary<string, string> ContextData {get; set;}
    }

    /// <summary>
    /// The user definition in kube config.
    /// </summary>
    public class User
    {
        [YamlMember(Alias = "name")]
        public string Name {get; set;}

        [YamlMember(Alias = "user")]
        public Dictionary<string, string> UserData {get; set;}
    }
}