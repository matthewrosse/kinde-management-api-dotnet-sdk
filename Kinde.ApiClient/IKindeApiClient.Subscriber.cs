using Kinde.ApiClient.Contracts.V1.Requests;
using Kinde.ApiClient.Contracts.V1.Responses;
using Kinde.ApiClient.QueryParams;
using Refit;

namespace Kinde.ApiClient;

public partial interface IKindeApiClient
{
    [Get("/api/v1/subscribers")]
    Task<GetSubscribersResponse> GetSubscribers(
        [AliasAs("sort")] SubscriberSortingMethod? sortingMethod = null,
        [AliasAs("page_size")] int? pageSize = null,
        [AliasAs("next_token")] string? nextToken = null
    );

    [Get("/api/v1/subscribers/{subscriber_id}")]
    Task<GetSubscriberResponse> GetSubscriber([AliasAs("subscriber_id")] string subscriberId);

    [Post("/api/v1/subscribers")]
    Task<CreateSubscriberSuccessResponse> CreateSubscriber([Body] CreateSubscriberRequest request);
}