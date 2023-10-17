using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record DeleteRoleFromOrganizationUserRequest
{
    [JsonPropertyName("org_code")] public required string OrganizationCode { get; init; }

    [JsonPropertyName("user_id")] public required string UserId { get; init; }

    [JsonPropertyName("role_id")] public required string RoleId { get; init; }
};