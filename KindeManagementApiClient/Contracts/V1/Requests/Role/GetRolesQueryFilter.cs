using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

/// <summary>
/// The query filter for getting a collection of roles that adds additional query parameters.
/// </summary>
public record GetRolesQueryFilter
{
    /// <summary>
    /// The sorting method.
    /// </summary>
    [AliasAs("sort")]
    public RoleSortingMethod? SortingMethod { get; init; }

    /// <summary>
    /// The page size. Defaults to 10.
    /// </summary>
    [AliasAs("page_size")]
    public int? PageSize { get; init; }

    /// <summary>
    /// The next token. Used for fetching another page of roles.
    /// </summary>
    [AliasAs("next_token")]
    public string? NextToken { get; set; }
};