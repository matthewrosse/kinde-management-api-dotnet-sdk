using KindeManagementApiClient.Abstractions;
using KindeManagementApiClient.Constants;
using Microsoft.Extensions.Caching.Memory;

namespace KindeManagementApiClient.Implementations;

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

    public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
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

    public async Task<string> GetRefreshedAccessTokenAsync(CancellationToken cancellationToken)
    {
        var newAccessToken = await _tokenFetcher.FetchAccessTokenAsync(cancellationToken);

        _memoryCache.Set(KindeApiClientConstants.AccessTokenCacheKey, newAccessToken);

        return newAccessToken;
    }
}