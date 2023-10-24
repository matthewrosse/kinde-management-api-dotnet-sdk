using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The subscriber model.
/// </summary>
/// <param name="Id">The subscriber's identifier.</param>
/// <param name="Email">The subscriber's email address.</param>
/// <param name="FirstName">The subscriber's first name.</param>
/// <param name="LastName">The subscriber's last name.</param>
/// <param name="FullName">The subscriber's full name.</param>
public record SubscribersSubscriber(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("full_name")]
    string FullName,
    [property: JsonPropertyName("last_name")]
    string LastName,
    [property: JsonPropertyName("first_name")]
    string FirstName
);