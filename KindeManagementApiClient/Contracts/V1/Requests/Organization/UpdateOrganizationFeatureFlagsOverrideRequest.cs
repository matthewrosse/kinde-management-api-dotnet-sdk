using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

/// <summary>
/// A request for updating organization's feature flags override.
/// </summary>
/// <param name="Value"></param>
public record UpdateOrganizationFeatureFlagsOverrideRequest(
    [property: JsonPropertyName("value")] string Value
);