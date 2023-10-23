using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Requests.Role;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    /// <summary>
    /// Gets a collection of roles with the default page size of 10.
    /// </summary>
    /// <param name="request">An instance of <see cref="GetRolesQueryFilter"/> that specifies additional query params.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetRolesResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Roles.GetMany)]
    Task<ApiResponse<GetRolesResponse>> GetRoles([Query] GetRolesQueryFilter? request = default);

    /// <summary>
    /// Gets the role's permissions.
    /// </summary>
    /// <param name="roleId">Role's identifier.</param>
    /// <param name="queryFilter">An instance of <see cref="GetRolePermissionsResponse"/> that specifies additional query params.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetRolePermissionsResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Roles.GetPermissions)]
    Task<ApiResponse<GetRolePermissionsResponse>> GetRolePermissions(
        string roleId,
        [Query] GetRolePermissionsQueryFilter? queryFilter = default
    );

    /// <summary>
    /// Updates the role's permissions.
    /// </summary>
    /// <param name="roleId">Role's identifier.</param>
    /// <param name="request">An instance of <see cref="UpdateRolePermissionsRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="UpdateRolePermissionsResponse"/>.</returns>
    [Patch(KindeApiRoutes.V1.Roles.UpdatePermissions)]
    Task<ApiResponse<UpdateRolePermissionsResponse>> UpdateRolePermissions(
        string roleId,
        [Body] UpdateRolePermissionsRequest request
    );

    /// <summary>
    /// Deletes the role's permission.
    /// </summary>
    /// <param name="roleId">Role's identifier.</param>
    /// <param name="permissionId">Permission's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Roles.DeletePermission)]
    Task<ApiResponse<SuccessResponse>> DeleteRolePermission(string roleId, string permissionId);

    /// <summary>
    /// Creates a new role.
    /// </summary>
    /// <param name="request">An instance of <see cref="CreateRoleRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Roles.Create)]
    Task<ApiResponse<SuccessResponse>> CreateRole([Body] CreateRoleRequest request);

    /// <summary>
    /// Updates a role with specified identifier.
    /// </summary>
    /// <param name="roleId">Role's identifier.</param>
    /// <param name="request">An instance of <see cref="UpdateRoleRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Roles.Update)]
    Task<ApiResponse<SuccessResponse>> UpdateRole(string roleId, [Body] UpdateRoleRequest request);

    /// <summary>
    /// Deletes a role with specified identifier.
    /// </summary>
    /// <param name="roleId">Role's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Roles.Delete)]
    Task<ApiResponse<SuccessResponse>> DeleteRole(string roleId);
}