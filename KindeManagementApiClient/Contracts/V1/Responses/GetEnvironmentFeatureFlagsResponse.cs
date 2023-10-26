using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetEnvironmentFeatureFlagsResponse
{
    [JsonIgnore] private readonly List<GetEnvironmentFeatureFlagsResponseInnerFeatureFlag>? _featureFlags;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("feature_flags")]
    public List<GetEnvironmentFeatureFlagsResponseInnerFeatureFlag> FeatureFlags
    {
        get => _featureFlags ?? new();
        init => _featureFlags = value;
    }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
}

public record GetEnvironmentFeatureFlagsResponseInnerFeatureFlag(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("value")] string Value
);