namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record GetOrganizationUserRolesRequest(
    string OrganizationCode,
    string UserId
);