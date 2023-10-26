using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetPermissionsResponse
{
    [JsonIgnore] private readonly List<Permission>? _permissions;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }

    [JsonPropertyName("permissions")]
    public List<Permission> Permissions
    {
        get => _permissions ?? new();
        init => _permissions = value;
    }
}