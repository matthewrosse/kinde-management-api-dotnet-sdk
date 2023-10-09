using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Models;

public record UserProfile(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("preferred_email")]
    string PreferredEmail,
    [property: JsonPropertyName("provided_id")]
    string? ProvidedId,
    [property: JsonPropertyName("last_name")]
    string LastName,
    [property: JsonPropertyName("first_name")]
    string FirstName,
    [property: JsonPropertyName("picture")]
    string Picture
);