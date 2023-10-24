using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

/// <summary>
/// The user model.
/// </summary>
/// <param name="Id">The user's identifier.</param>
/// <param name="ProvidedId">The user's provided identifier.</param>
/// <param name="PreferredEmail">The user's preferred email address.</param>
/// <param name="LastName">The user's last name.</param>
/// <param name="FirstName">The user's first name.</param>
/// <param name="IsSuspended">Specifies whether the user account is suspended.</param>
/// <param name="Picture">The address of the user's profile picture.</param>
/// <param name="TotalSignIns">The count of sign ins.</param>
/// <param name="FailedSignIns">The count of failed sign ins.</param>
/// <param name="LastSignedIn">The date when the user last signed in.</param>
/// <param name="CreatedOn">The date when the user was created.</param>
/// <param name="OrganizationIds">The organization identifiers which the user is assigned to.</param>
/// <param name="Identities">The user's identities.</param>
public record User(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("provided_id")]
    string ProvidedId,
    [property: JsonPropertyName("preferred_email")]
    string PreferredEmail,
    [property: JsonPropertyName("last_name")]
    string LastName,
    [property: JsonPropertyName("first_name")]
    string FirstName,
    [property: JsonPropertyName("is_suspended")]
    bool IsSuspended,
    [property: JsonPropertyName("picture")]
    string Picture,
    [property: JsonPropertyName("total_sign_ins")]
    int? TotalSignIns,
    [property: JsonPropertyName("failed_sign_ins")]
    int? FailedSignIns,
    [property: JsonPropertyName("last_signed_in")]
    string? LastSignedIn,
    [property: JsonPropertyName("created_on")]
    string? CreatedOn,
    [property: JsonPropertyName("organizations")]
    IReadOnlyCollection<string>? OrganizationIds,
    [property: JsonPropertyName("identities")]
    IReadOnlyCollection<UserIdentity>? Identities
);