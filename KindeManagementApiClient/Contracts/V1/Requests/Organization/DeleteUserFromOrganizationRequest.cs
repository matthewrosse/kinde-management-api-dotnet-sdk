namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record DeleteUserFromOrganizationRequest(
    string OrganizationCode,
    string UserId
);