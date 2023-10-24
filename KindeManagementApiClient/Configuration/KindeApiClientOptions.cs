using System.ComponentModel.DataAnnotations;

namespace KindeManagementApiClient.Configuration;

/// <summary>
/// Options for kinde management api client.
/// </summary>
public sealed class KindeApiClientOptions
{
    /// <summary>
    /// The section name for KindeApiClientOptions class.
    /// </summary>
    public const string SectionName = nameof(KindeApiClientOptions);

    /// <summary>
    /// The application's domain.
    /// </summary>
    [Required(ErrorMessage = "Domain is required."), Url(ErrorMessage = "Domain must be a valid URL.")]
    public string Domain { get; init; } = default!;

    /// <summary>
    /// The application's client identifier.
    /// </summary>
    [Required(ErrorMessage = "Client id is required.")]
    public string ClientId { get; init; } = default!;

    /// <summary>
    /// The application's client secret.
    /// </summary>
    [Required(ErrorMessage = "Client secret is required.")]
    public string ClientSecret { get; init; } = default!;

    /// <summary>
    /// The auth token's audience.
    /// </summary>
    [Required(ErrorMessage = "Audience is required."), Url(ErrorMessage = "Audience must be a valid URL.")]
    public string Audience { get; init; } = default!;
}