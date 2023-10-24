using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

/// <summary>
/// A request body object for creating a new role.
/// </summary>
public record CreateRoleRequest
{
    /// <summary>
    /// The role's name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The role's description.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The role's key.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// Specifies if the role is added to the new users by default.
    /// </summary>
    [JsonPropertyName("is_default_role")]
    public required bool IsDefaultRole { get; init; }
}