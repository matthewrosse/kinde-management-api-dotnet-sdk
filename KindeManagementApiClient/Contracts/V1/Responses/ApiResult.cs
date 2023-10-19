using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record ApiResult(
    [property: JsonPropertyName("result")] string Result
);