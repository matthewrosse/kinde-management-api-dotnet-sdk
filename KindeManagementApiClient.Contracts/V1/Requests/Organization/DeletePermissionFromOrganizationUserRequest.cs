using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record DeletePermissionFromOrganizationUserRequest(
    [property: JsonPropertyName("org_code")]
    string OrganizationCode,
    [property: JsonPropertyName("user_id")]
    string UserId,
    [property: JsonPropertyName("permission_id")]
    string PermissionId
);