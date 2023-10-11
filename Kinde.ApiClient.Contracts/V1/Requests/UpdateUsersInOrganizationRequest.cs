using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Requests;

public record UpdateUsersInOrganizationRequest(
    [property: JsonPropertyName("users")] ICollection<UpdateUsersInOrganizationRequestInnerUser> Users
);

public record UpdateUsersInOrganizationRequestInnerUser(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("operation")]
    UpdateUserInOrganizationOperation? Operation,
    [property: JsonPropertyName("roles")] ICollection<string>? Roles,
    [property: JsonPropertyName("permissions")]
    ICollection<string>? Permissions
);

public enum UpdateUserInOrganizationOperation
{
    [EnumMember(Value = "delete")] Delete
}