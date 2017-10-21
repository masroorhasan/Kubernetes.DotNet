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
    public interface IAuthorization_v1beta1Api
    {
        /// <summary>
        ///  create a LocalSubjectAccessReview
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAuthorizationV1beta1LocalSubjectAccessReview</returns>
        IoK8sKubernetesPkgApisAuthorizationV1beta1LocalSubjectAccessReview CreateAuthorizationV1beta1NamespacedLocalSubjectAccessReview (string _namespace, IoK8sKubernetesPkgApisAuthorizationV1beta1LocalSubjectAccessReview body, string pretty);
        /// <summary>
        ///  create a SelfSubjectAccessReview
        /// </summary>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAuthorizationV1beta1SelfSubjectAccessReview</returns>
        IoK8sKubernetesPkgApisAuthorizationV1beta1SelfSubjectAccessReview CreateAuthorizationV1beta1SelfSubjectAccessReview (IoK8sKubernetesPkgApisAuthorizationV1beta1SelfSubjectAccessReview body, string pretty);
        /// <summary>
        ///  create a SubjectAccessReview
        /// </summary>
        /// <param name="body"></param>
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param>
        /// <returns>IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReview</returns>
        IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReview CreateAuthorizationV1beta1SubjectAccessReview (IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReview body, string pretty);
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>
        IoK8sApimachineryPkgApisMetaV1APIResourceList GetAuthorizationV1beta1APIResources ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Authorization_v1beta1Api : IAuthorization_v1beta1Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization_v1beta1Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Authorization_v1beta1Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Authorization_v1beta1Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Authorization_v1beta1Api(String basePath)
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
        ///  create a LocalSubjectAccessReview
        /// </summary>
        /// <param name="_namespace">object name and auth scope, such as for teams and projects</param> 
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAuthorizationV1beta1LocalSubjectAccessReview</returns>            
        public IoK8sKubernetesPkgApisAuthorizationV1beta1LocalSubjectAccessReview CreateAuthorizationV1beta1NamespacedLocalSubjectAccessReview (string _namespace, IoK8sKubernetesPkgApisAuthorizationV1beta1LocalSubjectAccessReview body, string pretty)
        {
            
            // verify the required parameter '_namespace' is set
            if (_namespace == null) throw new ApiException(400, "Missing required parameter '_namespace' when calling CreateAuthorizationV1beta1NamespacedLocalSubjectAccessReview");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAuthorizationV1beta1NamespacedLocalSubjectAccessReview");
            
    
            var path = "/apis/authorization.k8s.io/v1beta1/namespaces/{namespace}/localsubjectaccessreviews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "namespace" + "}", ApiClient.ParameterToString(_namespace));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthorizationV1beta1NamespacedLocalSubjectAccessReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthorizationV1beta1NamespacedLocalSubjectAccessReview: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAuthorizationV1beta1LocalSubjectAccessReview) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAuthorizationV1beta1LocalSubjectAccessReview), response.Headers);
        }
    
        /// <summary>
        ///  create a SelfSubjectAccessReview
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAuthorizationV1beta1SelfSubjectAccessReview</returns>            
        public IoK8sKubernetesPkgApisAuthorizationV1beta1SelfSubjectAccessReview CreateAuthorizationV1beta1SelfSubjectAccessReview (IoK8sKubernetesPkgApisAuthorizationV1beta1SelfSubjectAccessReview body, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAuthorizationV1beta1SelfSubjectAccessReview");
            
    
            var path = "/apis/authorization.k8s.io/v1beta1/selfsubjectaccessreviews";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthorizationV1beta1SelfSubjectAccessReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthorizationV1beta1SelfSubjectAccessReview: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAuthorizationV1beta1SelfSubjectAccessReview) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAuthorizationV1beta1SelfSubjectAccessReview), response.Headers);
        }
    
        /// <summary>
        ///  create a SubjectAccessReview
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="pretty">If &#39;true&#39;, then the output is pretty printed.</param> 
        /// <returns>IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReview</returns>            
        public IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReview CreateAuthorizationV1beta1SubjectAccessReview (IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReview body, string pretty)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateAuthorizationV1beta1SubjectAccessReview");
            
    
            var path = "/apis/authorization.k8s.io/v1beta1/subjectaccessreviews";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthorizationV1beta1SubjectAccessReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthorizationV1beta1SubjectAccessReview: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReview) ApiClient.Deserialize(response.Content, typeof(IoK8sKubernetesPkgApisAuthorizationV1beta1SubjectAccessReview), response.Headers);
        }
    
        /// <summary>
        ///  get available resources
        /// </summary>
        /// <returns>IoK8sApimachineryPkgApisMetaV1APIResourceList</returns>            
        public IoK8sApimachineryPkgApisMetaV1APIResourceList GetAuthorizationV1beta1APIResources ()
        {
            
    
            var path = "/apis/authorization.k8s.io/v1beta1/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthorizationV1beta1APIResources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuthorizationV1beta1APIResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IoK8sApimachineryPkgApisMetaV1APIResourceList) ApiClient.Deserialize(response.Content, typeof(IoK8sApimachineryPkgApisMetaV1APIResourceList), response.Headers);
        }
    
    }
}
