using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The organization user's permission.
/// </summary>
/// <param name="Id">The permission's identifier.</param>
/// <param name="Key">The permission's key.</param>
/// <param name="Name">The permission's name.</param>
/// <param name="Description">The permission's description.</param>
/// <param name="Roles">The roles that have such permission.</param>
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