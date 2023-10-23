using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

public record CreatedUserIdentity(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("result")] CreatedUserIdentityInnerResult Result
);

public record CreatedUserIdentityInnerResult(
    [property: JsonPropertyName("created")]
    bool Created
);