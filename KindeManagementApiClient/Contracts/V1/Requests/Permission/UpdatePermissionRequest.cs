using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Permission;

public record UpdatePermissionRequest
{
    public required string PermissionId { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("key")]
    public required string Key { get; init; }
}