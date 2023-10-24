namespace KindeManagementApiClient.Abstractions;

/// <summary>
/// Interface for classes that manages auth tokens.
/// </summary>
public interface IAuthTokenStore
{
    /// <summary>
    /// Gets the access token.
    /// </summary>
    /// <param name="cancellationToken">An instance of <see cref="CancellationToken"/>.</param>
    /// <returns>The access token.</returns>
    Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets refreshed token.
    /// </summary>
    /// <param name="cancellationToken">An instance of <see cref="CancellationToken"/>.</param>
    /// <returns>The refreshed access token.</returns>
    Task<string> GetRefreshedAccessTokenAsync(CancellationToken cancellationToken = default);
}