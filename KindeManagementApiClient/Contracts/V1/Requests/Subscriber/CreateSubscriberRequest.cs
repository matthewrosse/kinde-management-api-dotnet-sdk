using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Subscriber;

/// <summary>
/// A request body object for creating a new subscriber.
/// </summary>
public record CreateSubscriberRequest
{
    /// <summary>
    /// The subscriber's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }

    /// <summary>
    /// The subscriber's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }

    /// <summary>
    /// The subscriber's email address.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }
}