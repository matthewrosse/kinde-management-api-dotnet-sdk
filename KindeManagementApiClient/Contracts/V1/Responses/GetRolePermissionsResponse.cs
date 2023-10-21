using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetRolePermissionsResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("next_token")]
    string? NextToken,
    [property: JsonPropertyName("permissions")]
    IReadOnlyCollection<GetRolePermissionsResponseInnerPermission> Permissions
);

public record GetRolePermissionsResponseInnerPermission(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description
);