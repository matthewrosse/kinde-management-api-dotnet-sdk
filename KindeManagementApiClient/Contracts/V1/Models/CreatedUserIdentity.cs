using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// User's identify object that is returned after successfully creating a user.
/// </summary>
/// <param name="Type">User identity's type.</param>
/// <param name="Result">The result of the operation of type <see cref="CreatedUserIdentityInnerResult"/>.</param>
public record CreatedUserIdentity(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("result")] CreatedUserIdentityInnerResult Result
);

public record CreatedUserIdentityInnerResult(
    [property: JsonPropertyName("created")]
    bool Created
);