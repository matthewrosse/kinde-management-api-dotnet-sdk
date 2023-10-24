using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The user's identity.
/// </summary>
/// <param name="Type">The identity's type.</param>
/// <param name="Identity">The identity.</param>
public record UserIdentity(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("identity")]
    string Identity
);