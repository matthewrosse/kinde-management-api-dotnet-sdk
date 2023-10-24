using KindeManagementApiClient.Abstractions;
using KindeManagementApiClient.Constants;
using Microsoft.Extensions.Caching.Memory;

namespace KindeManagementApiClient.Implementations;

/// <summary>
/// The implementation of <see cref="IAuthTokenStore"/> that uses <see cref="IMemoryCache"/>
/// as the fast token lookup and refreshed the access token on 401 unauthorized.
/// </summary>
internal sealed class AuthTokenStore : IAuthTokenStore
{
    private readonly IMemoryCache _memoryCache;
    private readonly ITokenFetcher _tokenFetcher;

    public AuthTokenStore(
        IMemoryCache memoryCache,
        ITokenFetcher tokenFetcher
    )
    {
        _memoryCache = memoryCache;
        _tokenFetcher = tokenFetcher;
    }

    /// <summary>
    /// Gets the access token.
    /// </summary>
    /// <param name="cancellationToken">An instance of <see cref="CancellationToken"/>.</param>
    /// <returns>The access token for Kinde Management API.</returns>
    public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        if (_memoryCache.TryGetValue(KindeApiClientConstants.AccessTokenCacheKey, out string? cachedAccessToken)
            &&
            cachedAccessToken is not null)
        {
            return cachedAccessToken;
        }

        var newAccessToken = await _tokenFetcher.FetchAccessTokenAsync(cancellationToken);

        _memoryCache.Set(KindeApiClientConstants.AccessTokenCacheKey, newAccessToken);

        return newAccessToken;
    }

    /// <summary>
    /// Gets the refreshed access token.
    /// </summary>
    /// <param name="cancellationToken">An instance of <see cref="CancellationToken"/>.</param>
    /// <returns>A refreshed access token.</returns>
    public async Task<string> GetRefreshedAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        var newAccessToken = await _tokenFetcher.FetchAccessTokenAsync(cancellationToken);

        _memoryCache.Set(KindeApiClientConstants.AccessTokenCacheKey, newAccessToken);

        return newAccessToken;
    }
}