using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

public record UserIdentity(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("result")] UserIdentityInnerResult Result
);

public record UserIdentityInnerResult(
    [property: JsonPropertyName("created")]
    bool Created
);