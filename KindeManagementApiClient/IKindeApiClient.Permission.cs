using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Requests.Permission;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Permissions.GetMany)]
    Task<GetPermissionsResponse> GetPermissions(GetPermissionsRequest? request = null);

    [Post(KindeApiRoutes.V1.Permissions.Create)]
    Task<SuccessResponse> CreatePermission([Body] CreatePermissionRequest request);

    [Patch(KindeApiRoutes.V1.Permissions.Update)]
    Task<SuccessResponse> UpdatePermission([Body] UpdatePermissionRequest request);

    [Delete(KindeApiRoutes.V1.Permissions.Delete)]
    Task<SuccessResponse> DeletePermission(string permissionId);
}