using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record AddRoleToOrganizationUserRequest(
    string OrganizationCode,
    string UserId,
    [property: JsonPropertyName("role_id")]
    string RoleId
);