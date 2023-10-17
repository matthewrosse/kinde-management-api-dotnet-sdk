using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record UpdateRoleRequest
{
    [JsonPropertyName("name")] public required string Name { get; init; }

    [JsonPropertyName("description")] public string? Description { get; init; }

    [JsonPropertyName("key")] public required string Key { get; init; }

    [JsonPropertyName("is_default_role")] public bool? IsDefaultRole { get; init; }
}