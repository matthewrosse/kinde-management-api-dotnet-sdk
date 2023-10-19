using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record UpdateOrganizationFeatureFlagsOverrideRequest(
    string OrganizationCode,
    string FeatureFlagKey,
    [property: JsonPropertyName("value")] string Value
);