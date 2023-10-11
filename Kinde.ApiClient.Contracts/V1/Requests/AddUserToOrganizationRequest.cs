using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Requests;

public record AddUserToOrganizationRequest(
    [property: JsonPropertyName("users")] ICollection<AddUserToOrganizationRequestInnerUser> Users
);

public record AddUserToOrganizationRequestInnerUser(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("permissions")]
    ICollection<string>? Permissions,
    [property: JsonPropertyName("roles")] ICollection<string>? Roles
);