using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

/// <summary>
/// A request body object used for creating a new organization.
/// </summary>
public record CreateOrganizationRequest
{
    private IDictionary<string, object>? _featureFlags;

    /// <summary>
    /// The organization's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The organization's feature flags.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("feature_flags")]
    public IDictionary<string, object>? FeatureFlags => _featureFlags;

    /// <summary>
    /// The organization's external identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; init; }

    /// <summary>
    /// The organization's background color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("background_color")]
    public string? BackgroundColor { get; init; }

    /// <summary>
    /// The organization's button color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("button_color")]
    public string? ButtonColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("button_text_color")]
    public string? ButtonTextColor { get; init; }

    /// <summary>
    /// The organization's link color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("link_color")]
    public string? LinkColor { get; init; }

    private void EnsureFeatureFlagsInitialized()
        => _featureFlags ??= new Dictionary<string, object>();

    /// <summary>
    /// Adds a feature flag to the <see cref="CreateOrganizationRequest"/> object.
    /// </summary>
    /// <param name="propertyName">The property's name.</param>
    /// <param name="value">The property's value.</param>
    public void AddFeatureFlag(string propertyName, string value)
    {
        EnsureFeatureFlagsInitialized();
        _featureFlags!.Add(new KeyValuePair<string, object>(propertyName, value));
    }

    /// <summary>
    /// Adds a feature flag to the <see cref="CreateOrganizationRequest"/> object.
    /// </summary>
    /// <param name="propertyName">The property's name.</param>
    /// <param name="value">The property's value.</param>
    public void AddFeatureFlag(string propertyName, bool value)
    {
        EnsureFeatureFlagsInitialized();
        _featureFlags!.Add(new KeyValuePair<string, object>(propertyName, value));
    }

    /// <summary>
    /// Adds a feature flag to the <see cref="CreateOrganizationRequest"/> object.
    /// </summary>
    /// <param name="propertyName">The property's name.</param>
    /// <param name="value">The property's value.</param>
    public void AddFeatureFlag(string propertyName, int value)
    {
        EnsureFeatureFlagsInitialized();
        _featureFlags!.Add(new KeyValuePair<string, object>(propertyName, value));
    }
}