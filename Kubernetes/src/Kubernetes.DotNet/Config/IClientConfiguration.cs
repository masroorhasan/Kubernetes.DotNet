namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// Defines the Kubernetes client configuration.
    /// </summary>
    public interface IClientConfiguration
    {
        /// <summary>
        /// Creates an instance of <see cref="IKubernetesClient"/> with specified authentication type.
        /// </summary>
        /// <param name="authType">The authentication type.</param>
        /// <returns>The <see cref="IKubernetesClient"/> client.</returns>
        IKubernetesClient CreateClient(AuthType authType);
    }
}
