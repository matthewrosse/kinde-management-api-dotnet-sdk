using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The organization model.
/// </summary>
/// <param name="Code">The organization's code.</param>
/// <param name="Name">The organization's name.</param>
/// <param name="IsDefault">Specifies if the organization is a default organization.</param>
/// <param name="ExternalId">The organization's external identifier.</param>
public record Organization(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("is_default")]
    bool IsDefault,
    [property: JsonPropertyName("external_id")]
    string ExternalId
);