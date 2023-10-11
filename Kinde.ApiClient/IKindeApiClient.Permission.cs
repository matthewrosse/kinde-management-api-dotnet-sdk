using Kinde.ApiClient.Contracts.V1.Models;
using Kinde.ApiClient.Contracts.V1.Requests;
using Kinde.ApiClient.Contracts.V1.Responses;
using Kinde.ApiClient.QueryParams;
using Refit;

namespace Kinde.ApiClient;

public partial interface IKindeApiClient
{
    [Get("/api/v1/permissions")]
    Task<GetPermissionsResponse> GetPermissions(
        [AliasAs("sort")] PermissionSortingMethod? sortingMethod = null,
        [AliasAs("page_size")] int? pageSize = null,
        [AliasAs("next_token")] string? nextToken = null
    );

    [Post("/api/v1/permissions")]
    Task<SuccessResponse> CreatePermission(
        [Body] CreatePermissionRequest request
    );

    [Patch("/api/v1/permissions/{permission_id}")]
    Task<SuccessResponse> UpdatePermission(
        [AliasAs("permission_id")] string permissionId,
        [Body] UpdatePermissionRequest request
    );

    [Delete("/api/v1/permissions/{permission_id}")]
    Task<SuccessResponse> DeletePermission(
        [AliasAs("permission_id")] string permissionId
    );
}