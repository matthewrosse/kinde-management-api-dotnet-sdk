using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

public record OrganizationUserPermission(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("roles")] IReadOnlyCollection<OrganizationUserPermissionRoleInner> Roles
);

public record OrganizationUserPermissionRoleInner(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("key")] string Key
);