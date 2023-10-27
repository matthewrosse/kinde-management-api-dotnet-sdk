using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Common;

public record SuccessResponse(
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("code")] string Code
);