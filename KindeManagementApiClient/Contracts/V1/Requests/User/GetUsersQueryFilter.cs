using KindeManagementApiClient.Contracts.V1.QueryParams;
using Refit;

namespace KindeManagementApiClient.Contracts.V1.Requests.User;

/// <summary>
/// The query filter for getting a collection of users that adds additional query parameters.
/// </summary>
public record GetUsersQueryFilter
{
    /// <summary>
    /// The user's identifier.
    /// </summary>
    [AliasAs("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// The user's email address.
    /// </summary>
    [AliasAs("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The sorting method.
    /// </summary>
    [AliasAs("sort")]
    public UserSortingMethod? SortingMethod { get; init; }

    /// <summary>
    /// The page size, defaults to 10.
    /// </summary>
    [AliasAs("page_size")]
    public int? PageSize { get; init; }

    /// <summary>
    /// The next token. Used for fetching another page of users.
    /// </summary>
    [AliasAs("next_token")]
    public string? NextToken { get; init; }
};