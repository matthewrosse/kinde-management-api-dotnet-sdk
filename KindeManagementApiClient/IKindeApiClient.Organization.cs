using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Models;
using KindeManagementApiClient.Contracts.V1.Requests.Organization;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Organizations.Get)]
    Task<Organization> GetOrganization(string code);

    [Get(KindeApiRoutes.V1.Organizations.GetMany)]
    Task<GetOrganizationsResponse> GetOrganizations(GetOrganizationsRequest? request = null);

    [Post(KindeApiRoutes.V1.Organizations.Create)]
    Task<CreateOrganizationResponse> CreateOrganization([Body] CreateOrganizationRequest request);

    [Patch(KindeApiRoutes.V1.Organizations.Update)]
    Task<SuccessResponse> UpdateOrganization([Body] UpdateOrganizationRequest request);

    [Delete(KindeApiRoutes.V1.Organizations.Delete)]
    Task DeleteOrganization(string organizationCode);

    [Get(KindeApiRoutes.V1.Organizations.GetUsers)]
    Task<GetOrganizationUsersResponse> GetOrganizationUsers(GetOrganizationUsersRequest request);

    [Post(KindeApiRoutes.V1.Organizations.AddUsers)]
    Task<AddOrganizationUsersResponse> AddUsersToOrganization(
        [Body] AddUsersToOrganizationRequest request
    );

    [Patch(KindeApiRoutes.V1.Organizations.UpdateUsers)]
    Task<UpdateOrganizationUsersResponse> UpdateOrganizationUsers(
        [Body] UpdateOrganizationUsersRequest request
    );

    [Get(KindeApiRoutes.V1.Organizations.GetUserRoles)]
    Task<GetOrganizationUserRolesResponse> GetOrganizationUserRoles(
        GetOrganizationUserRolesRequest request
    );

    [Post(KindeApiRoutes.V1.Organizations.AddRoleToUser)]
    Task<SuccessResponse> AddRoleToOrganizationUser([Body] AddRoleToOrganizationUserRequest request);

    [Delete(KindeApiRoutes.V1.Organizations.DeleteRoleFromUser)]
    Task<SuccessResponse> DeleteRoleFromOrganizationUser(DeleteRoleFromOrganizationUserRequest request);

    [Get(KindeApiRoutes.V1.Organizations.GetUserPermissions)]
    Task<GetOrganizationUserPermissionsResponse> GetOrganizationUserPermissions(
        GetOrganizationUserPermissionsRequest request
    );

    [Post(KindeApiRoutes.V1.Organizations.AddPermissionToUser)]
    Task<SuccessResponse> AddPermissionsToOrganizationUser(
        [Body] AddPermissionToOrganizationUserRequest request
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeletePermissionFromUser)]
    Task<SuccessResponse> DeletePermissionFromOrganizationUser(
        DeletePermissionFromOrganizationUserRequest request
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteUserFromOrganization)]
    Task<SuccessResponse> DeleteUserFromOrganization(DeleteUserFromOrganizationRequest request);

    [Get(KindeApiRoutes.V1.Organizations.GetFeatureFlags)]
    Task<GetOrganizationFeatureFlagsResponse> GetOrganizationFeatureFlags(
        string organizationCode
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteFeatureFlagsOverrides)]
    Task<SuccessResponse> DeleteOrganizationFeatureFlagsOverrides(
        string organizationCode
    );

    [Delete(KindeApiRoutes.V1.Organizations.DeleteFeatureFlagsOverride)]
    Task<SuccessResponse> DeleteOrganizationFeatureFlagsOverride(
        DeleteOrganizationFeatureFlagsOverrideRequest request
    );

    [Patch(KindeApiRoutes.V1.Organizations.UpdateFeatureFlagsOverride)]
    Task<SuccessResponse> UpdateOrganizationFeatureFlagsOverride(
        UpdateOrganizationFeatureFlagsOverrideRequest request
    );
}