using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record UpdateOrganizationFeatureFlagsOverrideRequest(
    [property: JsonPropertyName("org_code")]
    string OrganizationCode,
    [property: JsonPropertyName("feature_flag_key")]
    string FeatureFlagKey,
    [property: JsonPropertyName("value")] string Value
);