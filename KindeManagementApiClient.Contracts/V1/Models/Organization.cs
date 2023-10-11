using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

public record Organization(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("is_default")]
    bool IsDefault,
    [property: JsonPropertyName("external_id")]
    string ExternalId
);