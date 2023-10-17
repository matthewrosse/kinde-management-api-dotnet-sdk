using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record UpdatePermissionRequest
{
    [JsonPropertyName("name")] public string? Name { get; init; }

    [JsonPropertyName("description")] public string? Description { get; init; }

    [JsonPropertyName("key")] public string? Key { get; init; }
}