using System.Text.Json.Serialization;
using Kinde.ApiClient.Contracts.V1.Models;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record CreateUserResponse(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("created")]
    bool Created,
    [property: JsonPropertyName("identities")]
    IReadOnlyCollection<UserIdentity> Identities
);