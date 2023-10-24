using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

/// <summary>
/// A request for adding a role to a user in an organization.
/// </summary>
/// <param name="RoleId">The role's identifier.</param>
public record AddOrganizationUserRoleRequest(
    [property: JsonPropertyName("role_id")]
    string RoleId
);