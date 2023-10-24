using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The organization user's role model.
/// </summary>
/// <param name="Id">The role's identifier.</param>
/// <param name="Key">The role's key.</param>
/// <param name="Name">The role's name.</param>
public record OrganizationUserRole(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name
);