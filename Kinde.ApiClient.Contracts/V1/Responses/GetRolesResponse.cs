using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record GetRolesResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("roles")] IReadOnlyCollection<GetRolesResponseInnerRole> Roles,
    [property: JsonPropertyName("next_token")]
    string NextToken
);

public record GetRolesResponseInnerRole(
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description
);