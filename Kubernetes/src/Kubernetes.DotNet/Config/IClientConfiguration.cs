namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClientConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="authType"></param>
        /// <returns></returns>
        IKubernetesClient CreateClient(AuthType authType = AuthType.None);
    }
}
