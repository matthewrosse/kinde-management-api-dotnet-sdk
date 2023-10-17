using KindeManagementApiClient.Contracts.V1.Models;
using KindeManagementApiClient.Contracts.V1.Requests;
using KindeManagementApiClient.Contracts.V1.Responses;
using KindeManagementApiClient.QueryParams;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get("/api/v1/organization")]
    Task<Organization> GetOrganization([AliasAs("code")] string code);

    [Get("/api/v1/organizations")]
    Task<GetOrganizationsResponse> GetOrganizations(
        [AliasAs("sort")] OrganizationSortingMethod? sortingMethod = null,
        [AliasAs("page_size")] int? pageSize = null,
        [AliasAs("next_token")] string? nextToken = null
    );

    [Post("/api/v1/organization")]
    Task<CreateOrganizationResponse> CreateOrganization([Body] CreateOrganizationRequest request);

    [Patch("/api/v1/organization/{org_code}")]
    Task<SuccessResponse> UpdateOrganization(
        [AliasAs("org_code")] string organizationCode,
        [Body] CreateOrganizationRequest request
    );

    [Delete("/api/v1/organization/{org_code}")]
    Task DeleteOrganization([AliasAs("org_code")] string organizationCode);

    [Get("/api/v1/organizations/{org_code}/users")]
    Task<GetOrganizationUsersResponse> GetUsersInOrganization(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("sort")] UserSortingMethod? sortingMethod = null,
        [AliasAs("page_size")] int? pageSize = null,
        [AliasAs("next_token")] string? nextToken = null,
        [Query(CollectionFormat.Csv)] ICollection<string>? permissions = null,
        [Query(CollectionFormat.Csv)] ICollection<string>? roles = null
    );

    [Post("/api/v1/organizations/{org_code}/users")]
    Task<AddOrganizationUsersResponse> AddUsersToOrganization(
        [AliasAs("org_code")] string organizationCode,
        [Body] AddUsersToOrganizationRequest request
    );

    [Patch("/api/v1/organizations/{org_code}/users")]
    Task<UpdateOrganizationUsersResponse> UpdateUsersInOrganization(
        [AliasAs("org_code")] string organizationCode,
        [Body] UpdateUsersInOrganizationRequest request
    );

    [Get("/api/v1/organizations/{org_code}/users/{user_id}/roles")]
    Task<GetOrganizationUserRolesResponse> GetUserRolesInOrganization(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("user_id")] string userId
    );

    [Post("/api/v1/organizations/{org_code}/users/{user_id}/roles")]
    Task<SuccessResponse> AddRoleToUserInOrganization(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("user_id")] string userId,
        [Body] AddRoleToOrganizationUserRequest request
    );

    [Delete("/api/v1/organizations/{org_code}/users/{user_id}/roles/{role_id}")]
    Task<SuccessResponse> DeleteRoleFromUserInOrganization(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("user_id")] string userId,
        [AliasAs("role_id")] string roleId
    );

    [Get("/api/v1/organizations/{org_code}/users/{user_id}/permissions")]
    Task<GetOrganizationUserPermissionsResponse> GetUserPermissionsInOrganization(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("user_id")] string userId
    );

    [Post("/api/v1/organizations/{org_code}/users/{user_id}/permissions")]
    Task<SuccessResponse> AddPermissionsToUserInOrganization(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("user_id")] string userId,
        [Body] AddPermissionToOrganizationUserRequest request
    );

    [Delete("/api/v1/organizations/{org_code}/users/{user_id}/permissions/{permission_id}")]
    Task<SuccessResponse> DeletePermissionFromUserInOrganization(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("user_id")] string userId,
        [AliasAs("permission_id")] string permissionId
    );

    [Delete("/api/v1/organizations/{org_code}/users/{user_id}")]
    Task<SuccessResponse> DeleteUserFromOrganization(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("user_id")] string userId
    );

    [Get("/api/v1/organizations/{org_code}/feature_flags")]
    Task<GetOrganizationFeatureFlagsResponse> GetOrganizationFeatureFlags(
        [AliasAs("org_code")] string organizationCode
    );

    [Delete("/api/v1/organizations/{org_code}/feature_flags")]
    Task<SuccessResponse> DeleteOrganizationFeatureFlagsOverrides(
        [AliasAs("org_code")] string organizationCode
    );

    [Delete("/api/v1/organizations/{org_code}/feature_flags/{feature_flag_key}")]
    Task<SuccessResponse> DeleteOrganizationFeatureFlagsOverride(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("feature_flag_key")] string featureFlagKey
    );

    [Patch("/api/v1/organizations/{org_code}/feature_flags/{feature_flag_key}")]
    Task<SuccessResponse> UpdateOrganizationFeatureFlagsOverride(
        [AliasAs("org_code")] string organizationCode,
        [AliasAs("feature_flag_key")] string featureFlagKey,
        [AliasAs("value")] string value
    );
}