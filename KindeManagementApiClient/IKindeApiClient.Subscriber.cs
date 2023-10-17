using KindeManagementApiClient.Contracts.V1.Requests.Subscriber;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Subscribers.Get)]
    Task<GetSubscriberResponse> GetSubscriber(string subscriberId);

    [Get(KindeApiRoutes.V1.Subscribers.GetMany)]
    Task<GetSubscribersResponse> GetSubscribers(GetSubscribersRequest? request = null);

    [Post(KindeApiRoutes.V1.Subscribers.Create)]
    Task<CreateSubscriberSuccessResponse> CreateSubscriber([Body] CreateSubscriberRequest request);
}