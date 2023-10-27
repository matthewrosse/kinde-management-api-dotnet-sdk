using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Common;

public record ApiResult(
    [property: JsonPropertyName("result")] string Result
);