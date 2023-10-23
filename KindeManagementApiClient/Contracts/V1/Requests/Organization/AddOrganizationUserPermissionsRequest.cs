using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record AddOrganizationUserPermissionsRequest(
    [property: JsonPropertyName("permission_id")]
    string PermissionId
);