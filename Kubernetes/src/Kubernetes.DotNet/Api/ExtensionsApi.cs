/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Kubernetes.DotNet.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExtensionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get information of a group
        /// </remarks>
        /// <exception cref="Kubernetes.DotNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>V1APIGroup</returns>
        V1APIGroup GetAPIGroup ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get information of a group
        /// </remarks>
        /// <exception cref="Kubernetes.DotNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of V1APIGroup</returns>
        ApiResponse<V1APIGroup> GetAPIGroupWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get information of a group
        /// </remarks>
        /// <exception cref="Kubernetes.DotNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of V1APIGroup</returns>
        System.Threading.Tasks.Task<V1APIGroup> GetAPIGroupAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get information of a group
        /// </remarks>
        /// <exception cref="Kubernetes.DotNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (V1APIGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1APIGroup>> GetAPIGroupAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExtensionsApi : IExtensionsApi
    {
        private Kubernetes.DotNet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExtensionsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Kubernetes.DotNet.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExtensionsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Kubernetes.DotNet.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Kubernetes.DotNet.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  get information of a group
        /// </summary>
        /// <exception cref="Kubernetes.DotNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>V1APIGroup</returns>
        public V1APIGroup GetAPIGroup ()
        {
             ApiResponse<V1APIGroup> localVarResponse = GetAPIGroupWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  get information of a group
        /// </summary>
        /// <exception cref="Kubernetes.DotNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of V1APIGroup</returns>
        public ApiResponse< V1APIGroup > GetAPIGroupWithHttpInfo ()
        {

            var localVarPath = "/apis/extensions/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/yaml", 
                "application/vnd.kubernetes.protobuf"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/yaml",
                "application/vnd.kubernetes.protobuf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (BearerToken) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("authorization")))
            {
                localVarHeaderParams["authorization"] = Configuration.GetApiKeyWithPrefix("authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAPIGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<V1APIGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1APIGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1APIGroup)));
        }

        /// <summary>
        ///  get information of a group
        /// </summary>
        /// <exception cref="Kubernetes.DotNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of V1APIGroup</returns>
        public async System.Threading.Tasks.Task<V1APIGroup> GetAPIGroupAsync ()
        {
             ApiResponse<V1APIGroup> localVarResponse = await GetAPIGroupAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  get information of a group
        /// </summary>
        /// <exception cref="Kubernetes.DotNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (V1APIGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1APIGroup>> GetAPIGroupAsyncWithHttpInfo ()
        {

            var localVarPath = "/apis/extensions/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/yaml", 
                "application/vnd.kubernetes.protobuf"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/yaml",
                "application/vnd.kubernetes.protobuf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (BearerToken) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("authorization")))
            {
                localVarHeaderParams["authorization"] = Configuration.GetApiKeyWithPrefix("authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAPIGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<V1APIGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1APIGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1APIGroup)));
        }

    }
}
