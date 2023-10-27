using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Requests.Permission;
using KindeManagementApiClient.Contracts.V1.Responses;
using KindeManagementApiClient.Contracts.V1.Responses.Common;
using KindeManagementApiClient.Contracts.V1.Responses.Permissions;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    /// <summary>
    /// Get a collection of permissions with default page size of 10.
    /// </summary>
    /// <param name="queryFilter">An instance of <see cref="GetPermissionsQueryFilter"/> that specifies additional query params.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetPermissionsResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Permissions.GetMany)]
    Task<ApiResponse<GetPermissionsResponse>> GetPermissions([Query] GetPermissionsQueryFilter? queryFilter = default);

    /// <summary>
    /// Creates a new permission.
    /// </summary>
    /// <param name="request">An instance of <see cref="CreatePermissionRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Permissions.Create)]
    Task<ApiResponse<SuccessResponse>> CreatePermission([Body] CreatePermissionRequest request);

    /// <summary>
    /// Updates a role with specified identifier.
    /// </summary>
    /// <param name="permissionId">Permission's identifier.</param>
    /// <param name="request">An instance of <see cref="UpdatePermissionRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Patch(KindeApiRoutes.V1.Permissions.Update)]
    Task<ApiResponse<SuccessResponse>> UpdatePermission(string permissionId, [Body] UpdatePermissionRequest request);

    /// <summary>
    /// Deletes a permission with specified identifier.
    /// </summary>
    /// <param name="permissionId">Permission's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Permissions.Delete)]
    Task<ApiResponse<SuccessResponse>> DeletePermission(string permissionId);
}