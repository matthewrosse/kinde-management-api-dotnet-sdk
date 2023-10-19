using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Requests.Role;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Roles.GetMany)]
    Task<GetRolesResponse> GetRoles(GetRolesRequest? request = null);

    [Get(KindeApiRoutes.V1.Roles.GetPermissions)]
    Task<GetRolesPermissionResponse> GetRolePermissions(GetRolePermissionsRequest request);

    [Patch(KindeApiRoutes.V1.Roles.UpdatePermissions)]
    Task<UpdateRolePermissionsResponse> UpdateRolePermissions([Body] UpdateRolePermissionsRequest request);

    [Delete(KindeApiRoutes.V1.Roles.DeletePermission)]
    Task<SuccessResponse> DeleteRolePermission(DeleteRolePermissionRequest request);

    [Post(KindeApiRoutes.V1.Roles.Create)]
    Task<SuccessResponse> CreateRole([Body] CreateRoleRequest request);

    [Post(KindeApiRoutes.V1.Roles.Update)]
    Task<SuccessResponse> UpdateRole([Body] UpdateRoleRequest request);

    [Delete(KindeApiRoutes.V1.Roles.Delete)]
    Task<SuccessResponse> DeleteRole(string roleId);
}