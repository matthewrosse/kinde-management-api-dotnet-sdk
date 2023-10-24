using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

/// <summary>
/// A request body object for updating a role.
/// </summary>
public record UpdateRoleRequest
{
    /// <summary>
    /// The role's name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The role's description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The role's key.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// Specifies if the role is assigned to new users.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("is_default_role")]
    public bool? IsDefaultRole { get; init; }
}