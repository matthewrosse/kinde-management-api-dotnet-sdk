using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Requests;

public record CreateRoleRequest(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("is_default_role")]
    bool IsDefaultRole
);