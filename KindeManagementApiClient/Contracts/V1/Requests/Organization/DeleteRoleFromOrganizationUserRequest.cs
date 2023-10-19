namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record DeleteRoleFromOrganizationUserRequest
{
    public required string OrganizationCode { get; init; }

    public required string UserId { get; init; }

    public required string RoleId { get; init; }
};