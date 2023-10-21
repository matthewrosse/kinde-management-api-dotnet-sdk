using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Requests.Permission;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Permissions.GetMany)]
    Task<ApiResponse<GetPermissionsResponse>> GetPermissions();

    [Get(KindeApiRoutes.V1.Permissions.GetMany)]
    Task<ApiResponse<GetPermissionsResponse>> GetPermissions(GetPermissionsRequest request);

    [Post(KindeApiRoutes.V1.Permissions.Create)]
    Task<ApiResponse<SuccessResponse>> CreatePermission([Body] CreatePermissionRequest request);

    [Patch(KindeApiRoutes.V1.Permissions.Update)]
    Task<ApiResponse<SuccessResponse>> UpdatePermission([Body] UpdatePermissionRequest request);

    [Delete(KindeApiRoutes.V1.Permissions.Delete)]
    Task<ApiResponse<SuccessResponse>> DeletePermission(string permissionId);
}