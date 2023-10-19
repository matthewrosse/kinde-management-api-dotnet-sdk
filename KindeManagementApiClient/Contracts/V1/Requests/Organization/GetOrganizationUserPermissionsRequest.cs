namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record GetOrganizationUserPermissionsRequest(
    string OrganizationCode,
    string UserId
);