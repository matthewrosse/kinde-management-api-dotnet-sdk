using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record AddPermissionToOrganizationUserRequest(
    [property: JsonPropertyName("permission_id")]
    string PermissionId
);