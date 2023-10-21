namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record DeleteOrganizationUserPermissionRequest(
    string OrganizationCode,
    string UserId,
    string PermissionId
);