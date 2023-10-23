using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

public record CreateRoleRequest
{
    [JsonPropertyName("name")] public required string Name { get; init; }

    [JsonPropertyName("description")] public required string Description { get; init; }

    [JsonPropertyName("key")] public required string Key { get; init; }

    [JsonPropertyName("is_default_role")] public required bool IsDefaultRole { get; init; }
}