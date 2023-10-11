using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record CreateUserRequest(
    [property: JsonPropertyName("profile")]
    CreateUserRequestInnerProfile Profile,
    [property: JsonPropertyName("identities")]
    ICollection<CreateUserRequestInnerIdentity> Identities
);

public record CreateUserRequestInnerProfile(
    [property: JsonPropertyName("given_name")]
    string GivenName,
    [property: JsonPropertyName("family_name")]
    string FamilyName
);

public record CreateUserRequestInnerIdentity(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("details")]
    CreateUserRequestInnerIdentityDetails Details
);

public record CreateUserRequestInnerIdentityDetails(
    [property: JsonPropertyName("email")] string Email
);