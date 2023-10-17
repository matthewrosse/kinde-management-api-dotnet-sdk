using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Converters;
using KindeManagementApiClient.Contracts.V1.QueryParams;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record GetOrganizationUsersRequest
{
    [JsonIgnore] public required string OrganizationId { get; init; }

    [JsonPropertyName("sort")] public UserSortingMethod? SortingMethod { get; init; }

    [JsonPropertyName("page_size")] public int? PageSize { get; init; }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }

    [JsonConverter(typeof(CommaSeparatedCollectionJsonConverter))]
    [JsonPropertyName("permissions")]
    public ICollection<string>? Permissions { get; init; }

    [JsonConverter(typeof(CommaSeparatedCollectionJsonConverter))]
    [JsonPropertyName("roles")]
    public ICollection<string>? Roles { get; init; }
};