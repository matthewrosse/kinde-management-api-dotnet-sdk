using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record UpdateRolePermissionsResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("permissions_added")]
    IReadOnlyCollection<string>? PermissionsAdded,
    [property: JsonPropertyName("permissions_removed")]
    IReadOnlyCollection<string>? PermissionsRemoved
);