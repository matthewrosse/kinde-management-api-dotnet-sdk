using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Models;

public record Permission(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description
);