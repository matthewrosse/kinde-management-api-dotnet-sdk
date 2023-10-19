using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

public record Subscriber(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("preferred_email")]
    string PreferredEmail,
    [property: JsonPropertyName("first_name")]
    string FirstName,
    [property: JsonPropertyName("last_name")]
    string LastName
);