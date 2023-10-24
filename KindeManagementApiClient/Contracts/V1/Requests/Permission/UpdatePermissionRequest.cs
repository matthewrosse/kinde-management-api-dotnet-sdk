using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Permission;

/// <summary>
/// A request body object for updating a permission.
/// </summary>
public record UpdatePermissionRequest
{
    /// <summary>
    /// The permission's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The permission's description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The permission's key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}