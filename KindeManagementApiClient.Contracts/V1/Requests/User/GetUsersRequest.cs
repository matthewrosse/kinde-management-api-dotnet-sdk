using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.QueryParams;

namespace KindeManagementApiClient.Contracts.V1.Requests.User;

public record GetUsersRequest
{
    [JsonPropertyName("user_id")] public string? UserId { get; init; }

    [JsonPropertyName("email")] public string? Email { get; init; }

    [JsonPropertyName("sort")] public UserSortingMethod? SortingMethod { get; init; }

    [JsonPropertyName("page_size")] public int? PageSize { get; init; }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
};