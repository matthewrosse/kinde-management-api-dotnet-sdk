using System.Text.Json.Serialization;
using Kinde.ApiClient.Contracts.V1.Models;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record GetOrganizationsResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("organizations")]
    IReadOnlyCollection<Organization> Organizations,
    [property: JsonPropertyName("next_token")]
    string NextToken
);