using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.Permission;

public record GetPermissionsRequest
{
    [AliasAs("sort")] public PermissionSortingMethod? SortingMethod { get; init; }

    [AliasAs("page_size")] public int? PageSize { get; init; }

    [AliasAs("next_token")] public string? NextToken { get; init; }
};