using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetEnvironmentFeatureFlagsResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("feature_flags")]
    IReadOnlyCollection<GetEnvironmentFeatureFlagsResponseInnerFeatureFlag>? FeatureFlags,
    [property: JsonPropertyName("next_token")]
    string? NextToken
);

public record GetEnvironmentFeatureFlagsResponseInnerFeatureFlag(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("value")] string Value
);