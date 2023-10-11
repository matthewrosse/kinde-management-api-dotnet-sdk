using Kinde.ApiClient.Contracts.V1.Requests;
using Kinde.ApiClient.Contracts.V1.Responses;
using Kinde.ApiClient.QueryParams;
using Refit;

namespace Kinde.ApiClient;

public partial interface IKindeApiClient
{
    [Get("/api/v1/roles")]
    Task<GetRolesResponse> GetRoles(
        [AliasAs("sort")] RoleSortingMethod? sortingMethod = null,
        [AliasAs("page_size")] int? pageSize = null,
        [AliasAs("next_token")] string? nextToken = null
    );

    [Get("/api/v1/roles/{role_id}/permissions")]
    Task<GetRolesPermissionResponse> GetRolePermissions(
        [AliasAs("role_id")] string roleId,
        [AliasAs("sort")] PermissionSortingMethod? sortingMethod = null,
        [AliasAs("page_size")] int? pageSize = null,
        [AliasAs("next_token")] string? nextToken = null
    );

    [Patch("/api/v1/roles/{role_id}/permissions")]
    Task<UpdateRolePermissionsResponse> UpdateRolePermissions(
        [AliasAs("role_id")] string roleId,
        [Body] UpdateRolePermissionsRequest request
    );

    [Delete("/api/v1/roles/{role_id]/permissions/{permission_id}")]
    Task<SuccessResponse> DeleteRolePermission(
        [AliasAs("role_id")] string roleId,
        [AliasAs("permission_id")] string permissionId
    );

    [Post("/api/v1/roles")]
    Task<SuccessResponse> CreateRole([Body] CreateRoleRequest request);

    [Post("/api/v1/role/{role_id}")]
    Task<SuccessResponse> UpdateRole(
        [AliasAs("role_id")] string roleId,
        [Body] UpdateRoleRequest request
    );

    [Delete("/api/v1/roles/{role_id}")]
    Task<SuccessResponse> DeleteRole(
        [AliasAs("role_id")] string roleId
    );
}