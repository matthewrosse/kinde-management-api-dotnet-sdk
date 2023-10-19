using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

public record GetRolesRequest
{
    [AliasAs("sort")] public RoleSortingMethod? SortingMethod { get; init; }

    [AliasAs("page_size")] public int? PageSize { get; init; }

    [AliasAs("next_token")] public string? NextToken { get; set; }
};