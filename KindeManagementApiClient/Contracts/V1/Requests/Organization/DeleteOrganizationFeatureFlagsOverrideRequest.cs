namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

/// <summary>
/// 
/// </summary>
/// <param name="OrganizationCode"></param>
/// <param name="FeatureFlagKey"></param>
public record DeleteOrganizationFeatureFlagsOverrideRequest(
    string OrganizationCode,
    string FeatureFlagKey
);