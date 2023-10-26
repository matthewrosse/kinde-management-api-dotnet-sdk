using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetOrganizationUserRolesResponse
{
    [JsonIgnore] private readonly List<OrganizationUserRole>? _roles;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("roles")]
    public List<OrganizationUserRole> Roles
    {
        get => _roles ?? new();
        init => _roles = value;
    }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
}