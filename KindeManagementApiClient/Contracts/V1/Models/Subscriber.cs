using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The subscriber model.
/// </summary>
/// <param name="Id">The subscriber's identifier.</param>
/// <param name="PreferredEmail">The subscriber's preferred email.</param>
/// <param name="FirstName">The subscriber's first name.</param>
/// <param name="LastName">The subscriber's last name.</param>
public record Subscriber(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("preferred_email")]
    string PreferredEmail,
    [property: JsonPropertyName("first_name")]
    string FirstName,
    [property: JsonPropertyName("last_name")]
    string LastName
);