using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record UpdateOrganizationFeatureFlagsOverrideRequest(
    [property: JsonPropertyName("value")] string Value
);