using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetOrganizationUserPermissionsResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("permissions")]
    IReadOnlyCollection<OrganizationUserPermission> Permissions
);