using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Requests;

public record UpdateRolePermissionsRequest(
    [property: JsonPropertyName("permissions")]
    ICollection<UpdateRolePermissionsRequestInnerPermission> Permissions
);

public record UpdateRolePermissionsRequestInnerPermission(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("operation")]
    PermissionOperation? Operation
);

public enum PermissionOperation
{
    [EnumMember(Value = "delete")] Delete
}