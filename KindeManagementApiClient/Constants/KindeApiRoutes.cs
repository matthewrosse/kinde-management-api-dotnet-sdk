namespace KindeManagementApiClient.Constants;

internal static class KindeApiRoutes
{
    internal const string GetOAuth2AccessToken = "/oauth2/token";

    internal static class V1
    {
        internal static class Users
        {
            internal const string Get = "/api/v1/user";
            internal const string GetMany = "/api/v1/users";
            internal const string RefreshClaims = "/api/v1/users/{userId}/refresh_claims";
            internal const string Create = "/api/v1/user";
            internal const string Update = "/api/v1/user";
            internal const string Delete = "/api/v1/user";
        }

        internal static class Subscribers
        {
            internal const string Get = "/api/v1/subscribers/{subscriberId}";
            internal const string GetMany = "/api/v1/subscribers";
            internal const string Create = "/api/v1/subscribers";
        }

        internal static class Roles
        {
            internal const string GetMany = "/api/v1/roles";
            internal const string GetPermissions = "/api/v1/roles/{request.RoleId}/permissions";
            internal const string UpdatePermissions = "/api/v1/roles/{request.RoleId}/permissions";

            internal const string DeletePermission =
                "/api/v1/roles/{request.RoleId]/permission/{request.PermissionId}";

            internal const string Create = "/api/v1/roles";
            internal const string Update = "/api/v1/role/{request.RoleId}";
            internal const string Delete = "/api/v1/roles/{roleId}";
        }

        internal static class Permissions
        {
            internal const string GetMany = "/api/v1/permissions";
            internal const string Create = "/api/v1/permissions";
            internal const string Update = "/api/v1/permissions/{request.PermissionId}";
            internal const string Delete = "/api/v1/permissions/{permissionId}";
        }

        internal static class Organizations
        {
            internal const string Get = "/api/v1/organization";
            internal const string GetMany = "/api/v1/organizations";
            internal const string Create = "/api/v1/organization";
            internal const string Update = "/api/v1/organization/{request.OrganizationCode}";
            internal const string Delete = "/api/v1/organization/{organizationCode}";
            internal const string GetUsers = "/api/v1/organizations/{request.OrganizationCode}/users";
            internal const string AddUsers = "/api/v1/organizations/{request.OrganizationCode}/users";
            internal const string UpdateUsers = "/api/v1/organizations/{request.OrganizationCode}/users";

            internal const string GetUserRoles =
                "/api/v1/organizations/{request.OrganizationCode}/users/{request.UserId}/roles";

            internal const string AddUserRole =
                "/api/v1/organizations/{request.OrganizationCode}/users/{request.UserId}/roles";

            internal const string DeleteUserRole =
                "/api/v1/organizations/{request.OrganizationCode}/users/{request.UserId}/roles/{request.RoleId}";

            internal const string GetUserPermissions =
                "/api/v1/organizations/{request.OrganizationCode}/users/{request.UserId}/permissions";

            internal const string AddUserPermission =
                "/api/v1/organizations/{request.OrganizationCode}/users/{request.UserId}/permissions";

            internal const string DeleteUserPermission =
                "/api/v1/organizations/{request.OrganizationCode}/users/{request.UserId}/permissions/{request.PermissionId}";

            internal const string DeleteUser =
                "/api/v1/organizations/{request.OrganizationCode}/users/{request.UserId}";

            internal const string GetFeatureFlags = "/api/v1/organizations/{organizationCode}/feature_flags";

            internal const string DeleteFeatureFlagsOverrides =
                "/api/v1/organizations/{organizationCode}/feature_flags";

            internal const string DeleteFeatureFlagsOverride =
                "/api/v1/organizations/{request.OrganizationCode}/feature_flags/{request.FeatureFlagKey}";

            internal const string UpdateFeatureFlagsOverride =
                "/api/v1/organizations/{request.OrganizationCode}/feature_flags/{request.FeatureFlagKey}";
        }
    }
}