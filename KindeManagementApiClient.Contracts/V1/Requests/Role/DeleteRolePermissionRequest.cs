namespace KindeManagementApiClient.Contracts.V1.Requests.Role;

public record DeleteRolePermissionRequest(
    string RoleId,
    string PermissionId
);