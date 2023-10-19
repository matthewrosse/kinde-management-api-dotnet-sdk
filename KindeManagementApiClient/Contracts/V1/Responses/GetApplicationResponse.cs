using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetApplicationResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("application")]
    GetApplicationResponseInnerApplication Application
);

public record GetApplicationResponseInnerApplication(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("client_id")]
    string ClientId,
    [property: JsonPropertyName("client_secret")]
    string ClientSecret
);