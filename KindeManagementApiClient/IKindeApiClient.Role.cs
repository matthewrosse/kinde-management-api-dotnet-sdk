using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Requests.Role;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Roles.GetMany)]
    Task<ApiResponse<GetRolesResponse>> GetRoles();
    
    [Get(KindeApiRoutes.V1.Roles.GetMany)]
    Task<ApiResponse<GetRolesResponse>> GetRoles(GetRolesRequest request);

    [Get(KindeApiRoutes.V1.Roles.GetPermissions)]
    Task<ApiResponse<GetRolePermissionsResponse>> GetRolePermissions(GetRolePermissionsRequest request);

    [Patch(KindeApiRoutes.V1.Roles.UpdatePermissions)]
    Task<ApiResponse<UpdateRolePermissionsResponse>> UpdateRolePermissions([Body] UpdateRolePermissionsRequest request);

    [Delete(KindeApiRoutes.V1.Roles.DeletePermission)]
    Task<ApiResponse<SuccessResponse>> DeleteRolePermission(DeleteRolePermissionRequest request);

    [Post(KindeApiRoutes.V1.Roles.Create)]
    Task<ApiResponse<SuccessResponse>> CreateRole([Body] CreateRoleRequest request);

    [Post(KindeApiRoutes.V1.Roles.Update)]
    Task<ApiResponse<SuccessResponse>> UpdateRole([Body] UpdateRoleRequest request);

    [Delete(KindeApiRoutes.V1.Roles.Delete)]
    Task<ApiResponse<SuccessResponse>> DeleteRole(string roleId);
}