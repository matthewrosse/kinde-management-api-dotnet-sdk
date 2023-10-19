using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V2.Models;

public record UserProfile(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("sub")] string Sub,
    [property: JsonPropertyName("provided_id")]
    string? ProvidedId,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("given_name")]
    string GivenName,
    [property: JsonPropertyName("family_name")]
    string FamilyName,
    [property: JsonPropertyName("updated_at")]
    int UpdatedAt,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("picture")]
    string Picture
);