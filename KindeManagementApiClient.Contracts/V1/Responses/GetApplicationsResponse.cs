using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetApplicationsResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("applications")]
    IReadOnlyCollection<GetApplicationsResponseInnerApplication> Applications,
    [property: JsonPropertyName("next_token")]
    string NextToken
);

public record GetApplicationsResponseInnerApplication(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("type")] string Type
);