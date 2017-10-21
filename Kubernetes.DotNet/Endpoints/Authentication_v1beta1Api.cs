using System;
using System.Collections.Generic;
using RestSharp;
using Kubernetes.DotNet.Client;
using Kubernetes.DotNet.Model;

namespace Kubernetes.DotNet.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthentication_v1beta1Api
    {
        /// <summary>
        ///  create a TokenReview
        /// </summary>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReview</returns>
        IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReview CreateAuthenticationV1beta1TokenReview (IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReview body, string pretty);
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>
        IoK8sApimachineryPkgApisMetaV1APIResourceList GetAuthenticationV1beta1APIResources ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Authentication_v1beta1Api : IAuthentication_v1beta1Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication_v1beta1Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Authentication_v1beta1Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication_v1beta1Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Authentication_v1beta1Api(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  create a TokenReview
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReview</returns>            
        public IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReview CreateAuthenticationV1beta1TokenReview (IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReview body, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAuthenticationV1beta1TokenReview");
            
    
            var path = "/apis/authentication.k8s.io/v1beta1/tokenreviews";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pretty != null) queryParams.Add("pretty", ApiClient.ParameterToString(pretty)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthenticationV1beta1TokenReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthenticationV1beta1TokenReview: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReview) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAuthenticationV1beta1TokenReview), response.Headers);
        }
    
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>            
        public IoK8sApimachineryPkgApisMetaV1APIResourceList GetAuthenticationV1beta1APIResources ()
        {
            
    
            var path = "/apis/authentication.k8s.io/v1beta1/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticationV1beta1APIResources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthenticationV1beta1APIResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1APIResourceList) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1APIResourceList), response.Headers);
        }
    
    }
}
