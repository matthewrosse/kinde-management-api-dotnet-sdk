using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Models;

public record Application(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("type")] string Type
);