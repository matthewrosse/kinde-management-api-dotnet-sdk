using System.ComponentModel.DataAnnotations;

namespace KindeManagementApiClient.Configuration;

public sealed class KindeApiClientOptions
{
    internal const string SectionName = nameof(KindeApiClientOptions);

    [Required(ErrorMessage = "Domain is required."), Url(ErrorMessage = "Domain must be a valid URL.")]
    public string Domain { get; init; } = default!;

    [Required(ErrorMessage = "Client id is required.")]
    public string ClientId { get; init; } = default!;

    [Required(ErrorMessage = "Client secret is required.")]
    public string ClientSecret { get; init; } = default!;

    [Required(ErrorMessage = "Audience is required."), Url(ErrorMessage = "Audience must be a valid URL.")]
    public string Audience { get; init; } = default!;
}