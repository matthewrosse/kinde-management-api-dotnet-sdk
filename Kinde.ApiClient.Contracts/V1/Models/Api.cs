using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Models;

public record Api(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("audience")]
    string Audience,
    [property: JsonPropertyName("applications")]
    IReadOnlyCollection<ApiApplicationInner> Applications
);

public record ApiApplicationInner(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("is_active")]
    bool IsActive
);