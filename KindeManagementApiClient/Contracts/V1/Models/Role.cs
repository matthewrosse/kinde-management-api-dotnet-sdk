using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

public record Role(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description
);