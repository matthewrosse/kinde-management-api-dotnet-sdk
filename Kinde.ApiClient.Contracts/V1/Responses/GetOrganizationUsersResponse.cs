using System.Text.Json.Serialization;
using Kinde.ApiClient.Contracts.V1.Models;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record GetOrganizationUsersResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("organization_users")]
    IReadOnlyCollection<OrganizationUser> OrganizationUsers,
    [property: JsonPropertyName("next_token")]
    string NextToken
);