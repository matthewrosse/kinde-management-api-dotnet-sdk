using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record UpdateOrganizationRequest
{
    [JsonPropertyName("name")] public string? Name { get; init; }

    [JsonPropertyName("external_id")] public string? ExternalId { get; init; }

    [JsonPropertyName("background_color")] public string? BackgroundColor { get; init; }

    [JsonPropertyName("button_color")] public string? ButtonColor { get; init; }

    [JsonPropertyName("button_text_color")]
    public string? ButtonTextColor { get; init; }

    [JsonPropertyName("text_color")] public string? TextColor { get; init; }
}