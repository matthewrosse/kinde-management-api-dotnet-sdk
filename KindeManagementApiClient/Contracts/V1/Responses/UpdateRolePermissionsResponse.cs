using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record UpdateRolePermissionsResponse
{
    [JsonIgnore] private readonly List<string>? _permissionsAdded;

    [JsonIgnore] private readonly List<string>? _permissionsRemoved;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("permissions_added")]
    public List<string> PermissionsAdded
    {
        get => _permissionsAdded ?? new();
        init => _permissionsAdded = value;
    }

    [JsonPropertyName("permissions_removed")]
    public List<string> PermissionsRemoved
    {
        get => _permissionsRemoved ?? new();
        init => _permissionsRemoved = value;
    }
}