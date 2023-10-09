using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record CreateApplicationResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("application")]
    CreateApplicationResponseInnerApplication Application
);

public record CreateApplicationResponseInnerApplication(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("client_id")]
    string ClientId,
    [property: JsonPropertyName("client_secret")]
    string ClientSecret
);