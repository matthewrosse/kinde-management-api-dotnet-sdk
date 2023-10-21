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
    Task<ApiResponse<GetOrganizationsResponse>> GetOrganizations();

    [Get(KindeApiRoutes.V1.Organizations.GetMany)]
    Task<ApiResponse<GetOrganizationsResponse>> GetOrganizations(GetOrganizationsRequest request);

    [Post(KindeApiRoutes.V1.Organizations.Create)]
    Task<ApiResponse<CreateOrganizationResponse>> CreateOrganization([Body] CreateOrganizationRequest request);

    [Patch(KindeApiRoutes.V1.Organizations.Update)]
    Task<ApiResponse<SuccessResponse>> UpdateOrganization([Body] UpdateOrganizationRequest request);

    [Delete(KindeApiRoutes.V1.Organizations.Delete)]
    Task<IApiResponse> DeleteOrganization(string organizationCode);

    [Get(KindeApiRoutes.V1.Organizations.GetUsers)]
    Task<ApiResponse<GetOrganizationUsersResponse>> GetOrganizationUsers(GetOrganizationUsersRequest request);

    [Post(KindeApiRoutes.V1.Organizations.AddUsers)]
    Task<ApiResponse<AddOrganizationUsersResponse>> AddOrganizationUsers(
        [Body] AddOrganizationUsersRequest request
    );

    [Patch(KindeApiRoutes.V1.Organizations.UpdateUsers)]
    Task<ApiResponse<UpdateOrganizationUsersResponse>> UpdateOrganizationUsers(
        [Body] UpdateOrganizationUsersRequest request
    );

    [Get(KindeApiRoutes.V1.Organizations.GetUserRoles)]
    Task<ApiResponse<GetOrganizationUserRolesResponse>> GetOrganizationUserRoles(
        GetOrganizationUserRolesRequest request
    );

    [Post(KindeApiRoutes.V1.Organizations.AddUserRole)]
    Task<ApiResponse<SuccessResponse>> AddOrganizationUserRole([Body] AddOrganizationUserRoleRequest request);

    [Delete(KindeApiRoutes.V1.Organizations.DeleteUserRole)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationUserRole(DeleteOrganizationUserRoleRequest request);

    [Get(KindeApiRoutes.V1.Organizations.GetUserPermissions)]
    Task<ApiResponse<GetOrganizationUserPermissionsResponse>> GetOrganizationUserPermissions(
        GetOrganizationUserPermissionsRequest request
    );

    [Post(KindeApiRoutes.V1.Organizations.AddUserPermission)]
    Task<ApiResponse<SuccessResponse>> AddOrganizationUserPermissions(
        [Body] AddOrganizationUserPermissionsRequest request
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteUserPermission)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationUserPermission(
        DeleteOrganizationUserPermissionRequest request
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteUser)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationUser(DeleteOrganizationUserRequest request);

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
        DeleteOrganizationFeatureFlagsOverrideRequest request
    );

    [Patch(KindeApiRoutes.V1.Organizations.UpdateFeatureFlagsOverride)]
    Task<ApiResponse<SuccessResponse>> UpdateOrganizationFeatureFlagsOverride(
        UpdateOrganizationFeatureFlagsOverrideRequest request
    );
}