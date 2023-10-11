using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Requests;

public record CreatePermissionRequest(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("key")] string Key
);