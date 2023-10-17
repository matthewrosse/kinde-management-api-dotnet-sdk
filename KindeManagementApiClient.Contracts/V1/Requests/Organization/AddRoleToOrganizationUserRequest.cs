using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record AddRoleToOrganizationUserRequest(
    [property: JsonIgnore] string OrganizationCode,
    [property: JsonIgnore] string UserId,
    [property: JsonPropertyName("role_id")]
    string RoleId
);