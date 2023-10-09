using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Models;

public record OrganizationUser(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("full_name")]
    string FullName,
    [property: JsonPropertyName("last_name")]
    string LastName,
    [property: JsonPropertyName("first_name")]
    string FirstName,
    [property: JsonPropertyName("roles")] IReadOnlyCollection<string> Roles
);