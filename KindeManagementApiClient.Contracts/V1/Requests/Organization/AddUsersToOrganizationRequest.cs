using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record AddUsersToOrganizationRequest(
    [property: JsonIgnore] string OrganizationCode,
    [property: JsonPropertyName("users")] ICollection<NewOrganizationUserModel> NewOrganizationUserModels
);

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

    [JsonPropertyName("permissions")] public ICollection<string>? Permissions { get; init; }

    [JsonPropertyName("roles")] public ICollection<string>? Roles { get; init; }
}