using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record CreateSubscriberRequest
{
    [JsonPropertyName("first_name")] public required string FirstName { get; init; }

    [JsonPropertyName("last_name")] public required string LastName { get; init; }

    [JsonPropertyName("email")] public required string Email { get; init; }
}