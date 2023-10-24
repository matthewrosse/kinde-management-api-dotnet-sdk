namespace KindeManagementApiClient.Abstractions;

/// <summary>
/// Interface for classes capable of fetching tokens.
/// </summary>
internal interface ITokenFetcher
{
    /// <summary>
    /// Fetches the access token.
    /// </summary>
    /// <param name="cancellationToken">An instance of <see cref="CancellationToken"/>.</param>
    /// <returns>The access token.</returns>
    Task<string> FetchAccessTokenAsync(CancellationToken cancellationToken = default);
}