using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

/// <summary>
/// A request body object for updating a role's permission.
/// </summary>
/// <param name="UpdateRolePermissionModels">An instance of <see cref="ICollection{T}"/> of <see cref="UpdateRolePermissionModel"/>.</param>
public record UpdateRolePermissionsRequest(
    [property: JsonPropertyName("permissions")]
    ICollection<UpdateRolePermissionModel> UpdateRolePermissionModels
);

/// <summary>
/// Model for updating role's permission.
/// </summary>
public record UpdateRolePermissionModel
{
    /// <summary>
    /// The permission's identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The operationg to execute on that permission.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("operation")]
    public UpdateRolePermissionOperation? Operation { get; init; }
}

/// <summary>
/// An enum that specifies additional operations that can be done when updating a role's permission.
/// </summary>
public enum UpdateRolePermissionOperation
{
    [EnumMember(Value = "delete")] Delete
}