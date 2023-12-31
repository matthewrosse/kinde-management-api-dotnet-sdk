using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

/// <summary>
/// The query filter for getting a collection of organization users that adds additional query parameters.
/// </summary>
public record GetOrganizationUsersQueryFilter
{
    [AliasAs("sort")] public UserSortingMethod? SortingMethod { get; init; }

    [AliasAs("page_size")] public int? PageSize { get; init; }

    [AliasAs("next_token")] public string? NextToken { get; init; }

    [AliasAs("permissions")]
    [Query(CollectionFormat.Csv)]
    public ICollection<string>? Permissions { get; init; }

    [AliasAs("roles")]
    [Query(CollectionFormat.Csv)]
    public ICollection<string>? Roles { get; init; }
};