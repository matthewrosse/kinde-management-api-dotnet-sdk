namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record DeleteOrganizationFeatureFlagsOverrideRequest(
    string OrganizationCode,
    string FeatureFlagKey
);