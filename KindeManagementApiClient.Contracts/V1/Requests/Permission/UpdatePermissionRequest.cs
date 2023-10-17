using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Permission;

public record UpdatePermissionRequest
{
    [JsonIgnore] public required string PermissionId { get; init; }

    [JsonPropertyName("name")] public string? Name { get; init; }

    [JsonPropertyName("description")] public string? Description { get; init; }

    [JsonPropertyName("key")] public string? Key { get; init; }
}