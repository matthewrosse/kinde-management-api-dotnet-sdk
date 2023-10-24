using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record CreateUserResponse(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("created")]
    bool Created,
    [property: JsonPropertyName("identities")]
    IReadOnlyCollection<CreatedUserIdentity> Identities
);