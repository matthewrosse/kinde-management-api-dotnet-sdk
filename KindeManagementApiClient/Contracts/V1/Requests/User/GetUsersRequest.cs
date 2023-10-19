using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.User;

public record GetUsersRequest
{
    [AliasAs("user_id")] public string? UserId { get; init; }

    [AliasAs("email")] public string? Email { get; init; }

    [AliasAs("sort")] public UserSortingMethod? SortingMethod { get; init; }

    [AliasAs("page_size")] public int? PageSize { get; init; }

    [AliasAs("next_token")] public string? NextToken { get; init; }
};