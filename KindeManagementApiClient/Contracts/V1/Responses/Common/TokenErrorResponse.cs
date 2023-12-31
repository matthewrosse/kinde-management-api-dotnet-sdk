using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Common;

public record TokenErrorResponse(
    [property: JsonPropertyName("error")] string Error,
    [property: JsonPropertyName("error_description")]
    string ErrorDescription
);