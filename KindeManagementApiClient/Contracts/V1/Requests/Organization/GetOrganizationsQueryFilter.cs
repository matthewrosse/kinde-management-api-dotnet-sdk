using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

/// <summary>
/// The query filter for getting a collection of organizations that adds additional query parameters.
/// </summary>
public record GetOrganizationsQueryFilter
{
    [AliasAs("sort")] public OrganizationSortingMethod? SortingMethod { get; init; }

    [AliasAs("page_size")] public int? PageSize { get; init; }

    [AliasAs("next_token")] public string? NextToken { get; init; }
};