using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Models;

public record OrganizationUserRole(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name
);