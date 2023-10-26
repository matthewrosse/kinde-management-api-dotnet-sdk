using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetOrganizationUserPermissionsResponse
{
    [JsonIgnore] private readonly List<OrganizationUserPermission>? _permissions;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("permissions")]
    public List<OrganizationUserPermission> Permissions
    {
        get => _permissions ?? new();
        init => _permissions = value;
    }
}