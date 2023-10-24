using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The role's model.
/// </summary>
/// <param name="Id">The role's identifier.</param>
/// <param name="Key">The role's key.</param>
/// <param name="Name">The role's name.</param>
/// <param name="Description">The role's description.</param>
public record Role(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description
);