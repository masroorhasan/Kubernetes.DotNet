using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Kubernetes.DotNet.Model {

  /// <summary>
  /// ServiceSpec describes the attributes that a user creates on a service.
  /// </summary>
  [DataContract]
  public class IoK8sKubernetesPkgApiV1ServiceSpec {
    /// <summary>
    /// clusterIP is the IP address of the service and is usually assigned randomly by the master. If an address is specified manually and is not in use by others, it will be allocated to the service; otherwise, creation of the service will fail. This field can not be changed through updates. Valid values are \"None\", empty string (\"\"), or a valid IP address. \"None\" can be specified for headless services when proxying is not required. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
    /// </summary>
    /// <value>clusterIP is the IP address of the service and is usually assigned randomly by the master. If an address is specified manually and is not in use by others, it will be allocated to the service; otherwise, creation of the service will fail. This field can not be changed through updates. Valid values are \"None\", empty string (\"\"), or a valid IP address. \"None\" can be specified for headless services when proxying is not required. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</value>
    [DataMember(Name="clusterIP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clusterIP")]
    public string ClusterIP { get; set; }

    /// <summary>
    /// externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.  These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.
    /// </summary>
    /// <value>externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.  These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.</value>
    [DataMember(Name="externalIPs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalIPs")]
    public List<string> ExternalIPs { get; set; }

    /// <summary>
    /// externalName is the external reference that kubedns or equivalent will return as a CNAME record for this service. No proxying will be involved. Must be a valid DNS name and requires Type to be ExternalName.
    /// </summary>
    /// <value>externalName is the external reference that kubedns or equivalent will return as a CNAME record for this service. No proxying will be involved. Must be a valid DNS name and requires Type to be ExternalName.</value>
    [DataMember(Name="externalName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalName")]
    public string ExternalName { get; set; }

    /// <summary>
    /// externalTrafficPolicy denotes if this Service desires to route external traffic to node-local or cluster-wide endpoints. \"Local\" preserves the client source IP and avoids a second hop for LoadBalancer and Nodeport type services, but risks potentially imbalanced traffic spreading. \"Cluster\" obscures the client source IP and may cause a second hop to another node, but should have good overall load-spreading.
    /// </summary>
    /// <value>externalTrafficPolicy denotes if this Service desires to route external traffic to node-local or cluster-wide endpoints. \"Local\" preserves the client source IP and avoids a second hop for LoadBalancer and Nodeport type services, but risks potentially imbalanced traffic spreading. \"Cluster\" obscures the client source IP and may cause a second hop to another node, but should have good overall load-spreading.</value>
    [DataMember(Name="externalTrafficPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalTrafficPolicy")]
    public string ExternalTrafficPolicy { get; set; }

    /// <summary>
    /// healthCheckNodePort specifies the healthcheck nodePort for the service. If not specified, HealthCheckNodePort is created by the service api backend with the allocated nodePort. Will use user-specified nodePort value if specified by the client. Only effects when Type is set to LoadBalancer and ExternalTrafficPolicy is set to Local.
    /// </summary>
    /// <value>healthCheckNodePort specifies the healthcheck nodePort for the service. If not specified, HealthCheckNodePort is created by the service api backend with the allocated nodePort. Will use user-specified nodePort value if specified by the client. Only effects when Type is set to LoadBalancer and ExternalTrafficPolicy is set to Local.</value>
    [DataMember(Name="healthCheckNodePort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "healthCheckNodePort")]
    public int? HealthCheckNodePort { get; set; }

    /// <summary>
    /// Only applies to Service Type: LoadBalancer LoadBalancer will get created with the IP specified in this field. This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature.
    /// </summary>
    /// <value>Only applies to Service Type: LoadBalancer LoadBalancer will get created with the IP specified in this field. This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature.</value>
    [DataMember(Name="loadBalancerIP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadBalancerIP")]
    public string LoadBalancerIP { get; set; }

    /// <summary>
    /// If specified and supported by the platform, this will restrict traffic through the cloud-provider load-balancer will be restricted to the specified client IPs. This field will be ignored if the cloud-provider does not support the feature.\" More info: https://kubernetes.io/docs/tasks/access-application-cluster/configure-cloud-provider-firewall/
    /// </summary>
    /// <value>If specified and supported by the platform, this will restrict traffic through the cloud-provider load-balancer will be restricted to the specified client IPs. This field will be ignored if the cloud-provider does not support the feature.\" More info: https://kubernetes.io/docs/tasks/access-application-cluster/configure-cloud-provider-firewall/</value>
    [DataMember(Name="loadBalancerSourceRanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadBalancerSourceRanges")]
    public List<string> LoadBalancerSourceRanges { get; set; }

    /// <summary>
    /// The list of ports that are exposed by this service. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
    /// </summary>
    /// <value>The list of ports that are exposed by this service. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</value>
    [DataMember(Name="ports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ports")]
    public List<IoK8sKubernetesPkgApiV1ServicePort> Ports { get; set; }

    /// <summary>
    /// Route service traffic to pods with label keys and values matching this selector. If empty or not present, the service is assumed to have an external process managing its endpoints, which Kubernetes will not modify. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/
    /// </summary>
    /// <value>Route service traffic to pods with label keys and values matching this selector. If empty or not present, the service is assumed to have an external process managing its endpoints, which Kubernetes will not modify. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public Dictionary<string, string> Selector { get; set; }

    /// <summary>
    /// Supports \"ClientIP\" and \"None\". Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
    /// </summary>
    /// <value>Supports \"ClientIP\" and \"None\". Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</value>
    [DataMember(Name="sessionAffinity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessionAffinity")]
    public string SessionAffinity { get; set; }

    /// <summary>
    /// type determines how the Service is exposed. Defaults to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. \"ExternalName\" maps to the specified externalName. \"ClusterIP\" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object. If clusterIP is \"None\", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a stable IP. \"NodePort\" builds on ClusterIP and allocates a port on every node which routes to the clusterIP. \"LoadBalancer\" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the clusterIP. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services- --service-types
    /// </summary>
    /// <value>type determines how the Service is exposed. Defaults to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. \"ExternalName\" maps to the specified externalName. \"ClusterIP\" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object. If clusterIP is \"None\", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a stable IP. \"NodePort\" builds on ClusterIP and allocates a port on every node which routes to the clusterIP. \"LoadBalancer\" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the clusterIP. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services- --service-types</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IoK8sKubernetesPkgApiV1ServiceSpec {\n");
      sb.Append("  ClusterIP: ").Append(ClusterIP).Append("\n");
      sb.Append("  ExternalIPs: ").Append(ExternalIPs).Append("\n");
      sb.Append("  ExternalName: ").Append(ExternalName).Append("\n");
      sb.Append("  ExternalTrafficPolicy: ").Append(ExternalTrafficPolicy).Append("\n");
      sb.Append("  HealthCheckNodePort: ").Append(HealthCheckNodePort).Append("\n");
      sb.Append("  LoadBalancerIP: ").Append(LoadBalancerIP).Append("\n");
      sb.Append("  LoadBalancerSourceRanges: ").Append(LoadBalancerSourceRanges).Append("\n");
      sb.Append("  Ports: ").Append(Ports).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  SessionAffinity: ").Append(SessionAffinity).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
