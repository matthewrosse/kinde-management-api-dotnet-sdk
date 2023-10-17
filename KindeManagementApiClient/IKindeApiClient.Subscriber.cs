using KindeManagementApiClient.Contracts.V1.Requests.Subscriber;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get("/api/v1/subscribers/{subscriber_id}")]
    Task<GetSubscriberResponse> GetSubscriber([AliasAs("subscriber_id")] string subscriberId);

    [Get(KindeApiRoutes.V1.Subscribers.GetMany)]
    Task<GetSubscribersResponse> GetSubscribers(GetSubscribersRequest request);

    [Post(KindeApiRoutes.V1.Subscribers.Create)]
    Task<CreateSubscriberSuccessResponse> CreateSubscriber([Body] CreateSubscriberRequest request);
}