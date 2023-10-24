using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

/// <summary>
/// A request body object for adding users to an organization.
/// </summary>
/// <param name="NewOrganizationUserModels">An instance of <see cref="NewOrganizationUserModel"/>.</param>
public record AddOrganizationUsersRequest(
    [property: JsonPropertyName("users")] ICollection<NewOrganizationUserModel> NewOrganizationUserModels
);

/// <summary>
/// A user to add to an organization.
/// </summary>
public record NewOrganizationUserModel
{
    public NewOrganizationUserModel()
    {
    }

    public NewOrganizationUserModel(string userId)
        : this()
    {
        Id = userId;
    }

    [JsonPropertyName("id")] public required string Id { get; init; }

    [JsonPropertyName("permissions")] public ICollection<string> Permissions { get; init; } = new List<string>();

    [JsonPropertyName("roles")] public ICollection<string> Roles { get; init; } = new List<string>();
}