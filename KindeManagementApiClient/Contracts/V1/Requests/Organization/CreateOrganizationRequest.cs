using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record CreateOrganizationRequest
{
    private IDictionary<string, object>? _featureFlags;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("feature_flags")]
    public IDictionary<string, object>? FeatureFlags => _featureFlags;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("background_color")]
    public string? BackgroundColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("button_color")]
    public string? ButtonColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("button_text_color")]
    public string? ButtonTextColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("link_color")]
    public string? LinkColor { get; init; }

    private void EnsureFeatureFlagsInitialized()
        => _featureFlags ??= new Dictionary<string, object>();

    public void AddFeatureFlag(string propertyName, string value)
    {
        EnsureFeatureFlagsInitialized();
        _featureFlags!.Add(new KeyValuePair<string, object>(propertyName, value));
    }

    public void AddFeatureFlag(string propertyName, bool value)
    {
        EnsureFeatureFlagsInitialized();
        _featureFlags!.Add(new KeyValuePair<string, object>(propertyName, value));
    }

    public void AddFeatureFlag(string propertyName, int value)
    {
        EnsureFeatureFlagsInitialized();
        _featureFlags!.Add(new KeyValuePair<string, object>(propertyName, value));
    }
}