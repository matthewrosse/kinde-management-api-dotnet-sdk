using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record AddRoleToOrganizationUserRequest(
    [property: JsonPropertyName("role_id")]
    string RoleId
);