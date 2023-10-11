using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record CreateOrganizationRequest(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("feature_flags")]
    IDictionary<string, string>? FeatureFlags,
    [property: JsonPropertyName("external_id")]
    string? ExternalId,
    [property: JsonPropertyName("background_color")]
    string? BackgroundColor,
    [property: JsonPropertyName("button_color")]
    string? ButtonColor,
    [property: JsonPropertyName("button_text_color")]
    string? ButtonTextColor,
    [property: JsonPropertyName("link_color")]
    string? LinkColor
);