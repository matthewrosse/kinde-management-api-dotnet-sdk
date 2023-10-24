using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

/// <summary>
/// The query filter for getting a collection of role permissions that adds additional query parameters.
/// </summary>
public record GetRolePermissionsQueryFilter
{
    /// <summary>
    /// The sorting method's.
    /// </summary>
    [AliasAs("sort")]
    public PermissionSortingMethod? SortingMethod { get; init; }

    /// <summary>
    /// The page size. Defaults to 10.
    /// </summary>
    [AliasAs("page_size")]
    public int? PageSize { get; init; }

    /// <summary>
    /// The next token. Used to fetching another page of role's permissions.
    /// </summary>
    [AliasAs("next_token")]
    public string? NextToken { get; set; }
};