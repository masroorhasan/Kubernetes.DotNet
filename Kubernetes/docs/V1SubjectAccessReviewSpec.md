# Kubernetes.DotNet.Model.V1SubjectAccessReviewSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Extra** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here. | [optional] 
**Groups** | **List&lt;string&gt;** | Groups is the groups you&#39;re testing for. | [optional] 
**NonResourceAttributes** | [**V1NonResourceAttributes**](V1NonResourceAttributes.md) | NonResourceAttributes describes information for a non-resource access request | [optional] 
**ResourceAttributes** | [**V1ResourceAttributes**](V1ResourceAttributes.md) | ResourceAuthorizationAttributes describes information for a resource access request | [optional] 
**User** | **string** | User is the user you&#39;re testing for. If you specify \&quot;User\&quot; but not \&quot;Groups\&quot;, then is it interpreted as \&quot;What if User were not a member of any groups | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

