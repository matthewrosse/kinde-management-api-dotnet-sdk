using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Models;
using KindeManagementApiClient.Contracts.V1.Requests.Organization;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Organizations.Get)]
    Task<ApiResponse<Organization>> GetOrganization(string code);

    [Get(KindeApiRoutes.V1.Organizations.GetMany)]
    Task<ApiResponse<GetOrganizationsResponse>> GetOrganizations(
        [Query] GetOrganizationsQueryFilter? queryFilter = default
    );

    [Post(KindeApiRoutes.V1.Organizations.Create)]
    Task<ApiResponse<CreateOrganizationResponse>> CreateOrganization([Body] CreateOrganizationRequest request);

    [Patch(KindeApiRoutes.V1.Organizations.Update)]
    Task<ApiResponse<SuccessResponse>> UpdateOrganization(string organizationCode,
        [Body] UpdateOrganizationRequest request);

    [Delete(KindeApiRoutes.V1.Organizations.Delete)]
    Task<IApiResponse> DeleteOrganization(string organizationCode);

    [Get(KindeApiRoutes.V1.Organizations.GetUsers)]
    Task<ApiResponse<GetOrganizationUsersResponse>> GetOrganizationUsers(
        string organizationCode,
        GetOrganizationUsersQueryFilter? queryFilter = default
    );

    [Post(KindeApiRoutes.V1.Organizations.AddUsers)]
    Task<ApiResponse<AddOrganizationUsersResponse>> AddOrganizationUsers(
        string organizationCode,
        [Body] AddOrganizationUsersRequest request
    );

    [Patch(KindeApiRoutes.V1.Organizations.UpdateUsers)]
    Task<ApiResponse<UpdateOrganizationUsersResponse>> UpdateOrganizationUsers(
        string organizationCode,
        [Body] UpdateOrganizationUsersRequest request
    );

    [Get(KindeApiRoutes.V1.Organizations.GetUserRoles)]
    Task<ApiResponse<GetOrganizationUserRolesResponse>> GetOrganizationUserRoles(
        string organizationCode,
        string userId
    );

    [Post(KindeApiRoutes.V1.Organizations.AddUserRole)]
    Task<ApiResponse<SuccessResponse>> AddOrganizationUserRole(
        string organizationCode,
        string userId,
        [Body] AddOrganizationUserRoleRequest request
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteUserRole)]
    Task<ApiResponse<SuccessResponse>>
        DeleteOrganizationUserRole(string organizationCode, string userId, string roleId);

    [Get(KindeApiRoutes.V1.Organizations.GetUserPermissions)]
    Task<ApiResponse<GetOrganizationUserPermissionsResponse>> GetOrganizationUserPermissions(
        string organizationCode,
        string userId
    );

    [Post(KindeApiRoutes.V1.Organizations.AddUserPermission)]
    Task<ApiResponse<SuccessResponse>> AddOrganizationUserPermissions(
        string organizationCode,
        string userId,
        [Body] AddOrganizationUserPermissionsRequest request
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteUserPermission)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationUserPermission(
        string organizationCode,
        string userId,
        string permissionId
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteUser)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationUser(string organizationId, string userId);

    [Get(KindeApiRoutes.V1.Organizations.GetFeatureFlags)]
    Task<ApiResponse<GetOrganizationFeatureFlagsResponse>> GetOrganizationFeatureFlags(
        string organizationCode
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteFeatureFlagsOverrides)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationFeatureFlagsOverrides(
        string organizationCode
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteFeatureFlagsOverride)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationFeatureFlagsOverride(
        string organizationCode,
        string featureFlagKey
    );

    [Patch(KindeApiRoutes.V1.Organizations.UpdateFeatureFlagsOverride)]
    Task<ApiResponse<SuccessResponse>> UpdateOrganizationFeatureFlagsOverride(
        string organizationCode,
        string featureFlagKey,
        UpdateOrganizationFeatureFlagsOverrideRequest request
    );
}