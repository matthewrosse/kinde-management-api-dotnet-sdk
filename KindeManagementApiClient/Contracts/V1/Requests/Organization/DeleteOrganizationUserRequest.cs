namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record DeleteOrganizationUserRequest(
    string OrganizationCode,
    string UserId
);