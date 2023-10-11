namespace Kinde.ApiClient.Configurations;

public sealed class KindeApiClientOptions
{
    public string Domain { get; init; } = default!;

    public string ClientId { get; init; } = default!;

    public string ClientSecret { get; init; } = default!;

    public string Audience { get; init; } = default!;
}