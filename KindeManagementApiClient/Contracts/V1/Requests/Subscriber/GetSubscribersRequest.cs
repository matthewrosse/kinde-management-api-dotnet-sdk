using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.Subscriber;

public record GetSubscribersRequest
{
    [AliasAs("sort")] public SubscriberSortingMethod? SortingMethod { get; init; }

    [AliasAs("page_size")] public int? PageSize { get; init; }

    [AliasAs("next_token")] public string? NextToken { get; init; }
};