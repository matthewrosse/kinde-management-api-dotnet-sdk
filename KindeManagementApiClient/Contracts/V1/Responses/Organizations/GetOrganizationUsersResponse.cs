using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses.Organizations;

public record GetOrganizationUsersResponse
{
    [JsonIgnore] private readonly List<OrganizationUser>? _organizationUsers;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("organization_users")]
    public List<OrganizationUser> OrganizationUsers
    {
        get => _organizationUsers ?? new();
        init => _organizationUsers = value;
    }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
}