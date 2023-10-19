namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record DeletePermissionFromOrganizationUserRequest(
    string OrganizationCode,
    string UserId,
    string PermissionId
);