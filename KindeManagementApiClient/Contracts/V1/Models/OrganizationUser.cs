using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The organization's user model.
/// </summary>
/// <param name="Id">The user's identifier.</param>
/// <param name="Email">The user's email address.</param>
/// <param name="FullName">The user's full name.</param>
/// <param name="LastName">The user's last name.</param>
/// <param name="FirstName">The user's first name.</param>
/// <param name="Roles">The user's roles.</param>
public record OrganizationUser(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("full_name")]
    string FullName,
    [property: JsonPropertyName("last_name")]
    string LastName,
    [property: JsonPropertyName("first_name")]
    string FirstName,
    [property: JsonPropertyName("roles")] IReadOnlyCollection<string> Roles
);