using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Models;
using KindeManagementApiClient.Contracts.V1.Requests.Organization;
using KindeManagementApiClient.Contracts.V1.Responses;
using KindeManagementApiClient.Contracts.V1.Responses.Common;
using KindeManagementApiClient.Contracts.V1.Responses.Organizations;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    /// <summary>
    /// Gets an organization with the specified organization's code.
    /// </summary>
    /// <param name="code">Organization's code.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="Organization"/>.</returns>
    [Get(KindeApiRoutes.V1.Organizations.Get)]
    Task<ApiResponse<Organization>> GetOrganization([Query] string code);

    /// <summary>
    /// Gets a collection of organizations with default page size of 10.
    /// </summary>
    /// <param name="queryFilter">An instance of <see cref="GetOrganizationsQueryFilter"/> that specifies additional query params.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetOrganizationsResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Organizations.GetMany)]
    Task<ApiResponse<GetOrganizationsResponse>> GetOrganizations(
        [Query] GetOrganizationsQueryFilter? queryFilter = default
    );

    /// <summary>
    /// Creates a new organization.
    /// </summary>
    /// <param name="request">An instance of <see cref="CreateOrganizationRequest"/> that specifies the organization's properties.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="CreateOrganizationResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Organizations.Create)]
    Task<ApiResponse<CreateOrganizationResponse>> CreateOrganization([Body] CreateOrganizationRequest request);

    /// <summary>
    /// Updates an organization with the specified organization's code.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="request">An instance of <see cref="UpdateOrganizationRequest"/> that specifies organization's properties to update.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Patch(KindeApiRoutes.V1.Organizations.Update)]
    Task<ApiResponse<SuccessResponse>> UpdateOrganization(
        string organizationCode,
        [Body] UpdateOrganizationRequest request
    );

    /// <summary>
    /// Deletes an organization with the specified organization's code.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <returns>An instance of <see cref="IApiResponse{T}"/>.</returns>
    [Delete(KindeApiRoutes.V1.Organizations.Delete)]
    Task<IApiResponse> DeleteOrganization(string organizationCode);

    /// <summary>
    /// Gets the organization's users.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="queryFilter">An instance of <see cref="GetOrganizationUsersQueryFilter"/> that specifies additional query params.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetOrganizationUsersResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Organizations.GetUsers)]
    Task<ApiResponse<GetOrganizationUsersResponse>> GetOrganizationUsers(
        string organizationCode,
        GetOrganizationUsersQueryFilter? queryFilter = default
    );

    /// <summary>
    /// Add users to an organization with specified organization's code.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="request">An instance of <see cref="AddOrganizationUsersRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="AddOrganizationUsersResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Organizations.AddUsers)]
    Task<ApiResponse<AddOrganizationUsersResponse>> AddOrganizationUsers(
        string organizationCode,
        [Body] AddOrganizationUsersRequest request
    );

    /// <summary>
    /// Updates users in the organization with the specified organization's code.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="request">An instance of <see cref="UpdateOrganizationUsersRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="UpdateOrganizationUsersResponse"/>.</returns>
    [Patch(KindeApiRoutes.V1.Organizations.UpdateUsers)]
    Task<ApiResponse<UpdateOrganizationUsersResponse>> UpdateOrganizationUsers(
        string organizationCode,
        [Body] UpdateOrganizationUsersRequest request
    );

    /// <summary>
    /// Gets the organization user's roles.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="userId">User's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetOrganizationUserRolesResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Organizations.GetUserRoles)]
    Task<ApiResponse<GetOrganizationUserRolesResponse>> GetOrganizationUserRoles(
        string organizationCode,
        string userId
    );

    /// <summary>
    /// Add a role to the organization user.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="userId">User's identifier.</param>
    /// <param name="request">An instance of <see cref="AddOrganizationUserRoleRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Organizations.AddUserRole)]
    Task<ApiResponse<SuccessResponse>> AddOrganizationUserRole(
        string organizationCode,
        string userId,
        [Body] AddOrganizationUserRoleRequest request
    );

    /// <summary>
    /// Deletes the organization user's role.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="userId">User's identifier.</param>
    /// <param name="roleId">Role's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Organizations.DeleteUserRole)]
    Task<ApiResponse<SuccessResponse>>
        DeleteOrganizationUserRole(string organizationCode, string userId, string roleId);

    /// <summary>
    /// Gets organization user's permissions.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="userId">User's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetOrganizationUserPermissionsResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Organizations.GetUserPermissions)]
    Task<ApiResponse<GetOrganizationUserPermissionsResponse>> GetOrganizationUserPermissions(
        string organizationCode,
        string userId
    );

    /// <summary>
    /// Adds permissions to the organization user.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="userId">User's identifier.</param>
    /// <param name="request">An instance of <see cref="AddOrganizationUserPermissionRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Organizations.AddUserPermission)]
    Task<ApiResponse<SuccessResponse>> AddOrganizationUserPermissions(
        string organizationCode,
        string userId,
        [Body] AddOrganizationUserPermissionRequest request
    );

    /// <summary>
    /// Deletes organization user's permission.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="userId">User's identifier.</param>
    /// <param name="permissionId">Permission's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Organizations.DeleteUserPermission)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationUserPermission(
        string organizationCode,
        string userId,
        string permissionId
    );

    /// <summary>
    /// Deletes organization user.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="userId">User's identifier.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Organizations.DeleteUser)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationUser(string organizationCode, string userId);

    /// <summary>
    /// Gets organization's feature flags.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="GetOrganizationFeatureFlagsResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Organizations.GetFeatureFlags)]
    Task<ApiResponse<GetOrganizationFeatureFlagsResponse>> GetOrganizationFeatureFlags(string organizationCode);

    /// <summary>
    /// Deletes organization's feature flags overrides.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Organizations.DeleteFeatureFlagsOverrides)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationFeatureFlagsOverrides(string organizationCode);

    /// <summary>
    /// Deletes organization's feature flags override with specified key.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="featureFlagKey">Feature flag's key.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Organizations.DeleteFeatureFlagsOverride)]
    Task<ApiResponse<SuccessResponse>> DeleteOrganizationFeatureFlagsOverride(
        string organizationCode,
        string featureFlagKey
    );

    /// <summary>
    /// Updates the organization's feature flags override with specified key.
    /// </summary>
    /// <param name="organizationCode">Organization's code.</param>
    /// <param name="featureFlagKey">Feature flag's key.</param>
    /// <param name="request">An instance of <see cref="UpdateOrganizationFeatureFlagsOverrideRequest"/>.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Patch(KindeApiRoutes.V1.Organizations.UpdateFeatureFlagsOverride)]
    Task<ApiResponse<SuccessResponse>> UpdateOrganizationFeatureFlagsOverride(
        string organizationCode,
        string featureFlagKey,
        UpdateOrganizationFeatureFlagsOverrideRequest request
    );
}