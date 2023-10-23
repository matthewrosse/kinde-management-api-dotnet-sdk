using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record AddOrganizationUserRoleRequest(
    [property: JsonPropertyName("role_id")]
    string RoleId
);