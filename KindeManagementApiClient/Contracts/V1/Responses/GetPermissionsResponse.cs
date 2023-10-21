using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetPermissionsResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("next_token")]
    string? NextToken,
    [property: JsonPropertyName("permissions")]
    IReadOnlyCollection<GetPermissionsResponseInnerPermission>? Permissions
);

public record GetPermissionsResponseInnerPermission(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")]
    string Description
);