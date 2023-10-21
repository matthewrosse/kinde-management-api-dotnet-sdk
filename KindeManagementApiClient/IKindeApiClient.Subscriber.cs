using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Requests.Subscriber;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Subscribers.Get)]
    Task<ApiResponse<GetSubscriberResponse>> GetSubscriber(string subscriberId);

    [Get(KindeApiRoutes.V1.Subscribers.GetMany)]
    Task<ApiResponse<GetSubscribersResponse>> GetSubscribers();

    [Get(KindeApiRoutes.V1.Subscribers.GetMany)]
    Task<ApiResponse<GetSubscribersResponse>> GetSubscribers([Query] GetSubscribersRequest request);

    [Post(KindeApiRoutes.V1.Subscribers.Create)]
    Task<ApiResponse<CreateSubscriberSuccessResponse>> CreateSubscriber([Body] CreateSubscriberRequest request);
}