using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.Permission;

/// <summary>
/// The query filter for getting a collection of permissions that adds additional query parameters.
/// </summary>
public record GetPermissionsQueryFilter
{
    /// <summary>
    /// The sorting method.
    /// </summary>
    [AliasAs("sort")]
    public PermissionSortingMethod? SortingMethod { get; init; }

    /// <summary>
    /// The page size. Defaults to 10.
    /// </summary>
    [AliasAs("page_size")]
    public int? PageSize { get; init; }

    /// <summary>
    /// The next token. Used for fetching another page of permissions.
    /// </summary>
    [AliasAs("next_token")]
    public string? NextToken { get; init; }
};