using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record AddPermissionToOrganizationUserRequest(
    [property: JsonIgnore] string OrganizationCode,
    [property: JsonIgnore] string UserId,
    [property: JsonPropertyName("permission_id")]
    string PermissionId
);