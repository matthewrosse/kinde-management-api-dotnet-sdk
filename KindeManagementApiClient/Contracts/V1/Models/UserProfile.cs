using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The user's profile.
/// </summary>
/// <param name="Id">The user's identifier.</param>
/// <param name="PreferredEmail">The user's preferred email address.</param>
/// <param name="ProvidedId">The user's provided identifier.</param>
/// <param name="LastName">The user's last name.</param>
/// <param name="FirstName">The user's first name.</param>
/// <param name="Picture">The user's profile picture address.</param>
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