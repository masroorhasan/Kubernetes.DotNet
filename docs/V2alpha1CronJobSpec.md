# Kubernetes.DotNet.Model.V2alpha1CronJobSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConcurrencyPolicy** | **string** | Specifies how to treat concurrent executions of a Job. Defaults to Allow. | [optional] 
**FailedJobsHistoryLimit** | **int?** | The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified. | [optional] 
**JobTemplate** | [**V2alpha1JobTemplateSpec**](V2alpha1JobTemplateSpec.md) | Specifies the job that will be created when executing a CronJob. | 
**Schedule** | **string** | The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron. | 
**StartingDeadlineSeconds** | **long?** | Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones. | [optional] 
**SuccessfulJobsHistoryLimit** | **int?** | The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified. | [optional] 
**Suspend** | **bool?** | This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

