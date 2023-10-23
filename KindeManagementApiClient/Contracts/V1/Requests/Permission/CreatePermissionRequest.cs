using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Permission;

public record CreatePermissionRequest
{
    [JsonPropertyName("name")] public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("key")] public required string Key { get; init; }
}