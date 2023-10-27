using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Requests.Subscriber;
using KindeManagementApiClient.Contracts.V1.Responses;
using KindeManagementApiClient.Contracts.V1.Responses.Subscribers;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    /// <summary>
    /// Gets the subscriber with specified id.
    /// </summary>
    /// <param name="subscriberId">Subscriber's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetSubscriberResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Subscribers.Get)]
    Task<ApiResponse<GetSubscriberResponse>> GetSubscriber(string subscriberId);

    /// <summary>
    /// Gets a collection of subscribers with a default page size of 10.
    /// </summary>
    /// <param name="request">An instance of <see cref="GetSubscribersQueryFilter"/> that represents additional query params.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetSubscriberResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Subscribers.GetMany)]
    Task<ApiResponse<GetSubscribersResponse>> GetSubscribers([Query] GetSubscribersQueryFilter? request = default);

    /// <summary>
    /// Creates a new subscriber.
    /// </summary>
    /// <param name="request">An instance of <see cref="CreateSubscriberRequest"/> that specifies the new subscriber's details.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="CreateSubscriberSuccessResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Subscribers.Create)]
    Task<ApiResponse<CreateSubscriberSuccessResponse>> CreateSubscriber([Body] CreateSubscriberRequest request);
}