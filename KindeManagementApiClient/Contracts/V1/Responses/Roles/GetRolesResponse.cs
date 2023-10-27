using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses.Roles;

public record GetRolesResponse
{
    [JsonIgnore] private readonly List<Role>? _roles;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("roles")]
    public List<Role> Roles
    {
        get => _roles ?? new();
        init => _roles = value;
    }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
}