using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.QueryParams;

namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

public record GetRolePermissionsRequest
{
    public required string RoleId { get; init; }

    [JsonPropertyName("sort")] public PermissionSortingMethod? SortingMethod { get; init; }

    [JsonPropertyName("page_size")] public int? PageSize { get; init; }

    [JsonPropertyName("next_token")] public string? NextToken { get; set; }
};