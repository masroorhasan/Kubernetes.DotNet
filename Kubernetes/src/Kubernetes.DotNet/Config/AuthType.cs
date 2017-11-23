using System;

namespace Kubernetes.DotNet.Config
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthType
    {
        None = 0,

        BasicAuth = 1,

        TokenAuth = 2,

        SSLAuth = 3
    }
}
