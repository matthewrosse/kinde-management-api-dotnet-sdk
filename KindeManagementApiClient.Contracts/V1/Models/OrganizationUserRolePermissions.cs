using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

public record OrganizationUserRolePermissions(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("role")] string Role,
    [property: JsonPropertyName("permissions")]
    OrganizationUserRolePermissionsInnerPermissions Permissions
);

public record OrganizationUserRolePermissionsInnerPermissions(
    [property: JsonPropertyName("key")] string Key
);