using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetOrganizationUserRolesResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("roles")] IReadOnlyCollection<OrganizationUserRole>? Roles,
    [property: JsonPropertyName("next_token")]
    string? NextToken
);