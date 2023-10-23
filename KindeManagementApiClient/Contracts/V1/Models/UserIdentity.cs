using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

public record UserIdentity(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("identity")]
    string Identity
);