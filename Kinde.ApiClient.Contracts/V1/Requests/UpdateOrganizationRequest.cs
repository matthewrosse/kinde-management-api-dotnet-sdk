using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Requests;

public record UpdateOrganizationRequest(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("external_id")]
    string ExternalId,
    [property: JsonPropertyName("background_color")]
    string BackgroundColor,
    [property: JsonPropertyName("button_color")]
    string ButtonColor,
    [property: JsonPropertyName("button_text_color")]
    string ButtonTextColor,
    [property: JsonPropertyName("text_color")]
    string TextColor
);