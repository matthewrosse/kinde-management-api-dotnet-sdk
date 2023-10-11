using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Models;

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
    string? CreatedOn
);