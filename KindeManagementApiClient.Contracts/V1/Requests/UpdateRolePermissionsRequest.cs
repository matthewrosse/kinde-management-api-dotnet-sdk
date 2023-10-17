using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record UpdateRolePermissionsRequest(
    [property: JsonPropertyName("permissions")]
    ICollection<UpdateRolePermissionModel> UpdateRolePermissionModels
);

public record UpdateRolePermissionModel
{
    [JsonPropertyName("id")] public required string Id { get; init; }

    [JsonPropertyName("operation")] public UpdateRolePermissionOperation? Operation { get; init; }
}

public enum UpdateRolePermissionOperation
{
    [EnumMember(Value = "delete")] Delete
}