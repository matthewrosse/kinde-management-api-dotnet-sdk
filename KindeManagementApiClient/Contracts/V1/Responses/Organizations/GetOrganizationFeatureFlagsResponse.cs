using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Organizations;

public record GetOrganizationFeatureFlagsResponse
{
    [JsonIgnore] private readonly List<GetOrganizationFeatureFlagsResponseInnerFeatureFlag>? _featureFlags;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("feature_flags")]
    public List<GetOrganizationFeatureFlagsResponseInnerFeatureFlag> FeatureFlags
    {
        get => _featureFlags ?? new();
        init => _featureFlags = value;
    }
}

public record GetOrganizationFeatureFlagsResponseInnerFeatureFlag(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("value")] string Value
);