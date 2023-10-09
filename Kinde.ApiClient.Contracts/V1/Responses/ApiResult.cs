using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record ApiResult(
    [property: JsonPropertyName("result")] string Result
);