using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record GetOrganizationFeatureFlagsResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("feature_flags")]
    IReadOnlyCollection<GetOrganizationFeatureFlagsResponseInnerFeatureFlag> FeatureFlags
);

public record GetOrganizationFeatureFlagsResponseInnerFeatureFlag(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("value")] string Value
);