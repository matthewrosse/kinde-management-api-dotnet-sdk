using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record SuccessResponse(
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("code")] string Code
);