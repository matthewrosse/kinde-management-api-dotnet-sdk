using System.Text.Json;
using KindeManagementApiClient.Contracts.V1.Responses;
using KindeManagementApiClient.Configurations;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace KindeManagementApiClient;

public sealed class AuthTokenStore(
    IHttpClientFactory httpClientFactory,
    IMemoryCache memoryCache,
    IOptions<KindeApiClientOptions> kindeApiClientOptions
) : IAuthTokenStore
{
    private readonly HttpClient _httpClient =
        httpClientFactory.CreateClient(KindeApiClientConstants.KindeHttpClientName);

    public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
    {
        if (memoryCache.TryGetValue(KindeApiClientConstants.KindeAccessTokenCacheKey, out string? cachedAccessToken) &&
            cachedAccessToken is not null)
        {
            return cachedAccessToken;
        }

        var newAccessToken = await RetrieveAccessTokenAsync(cancellationToken);

        memoryCache.Set(KindeApiClientConstants.KindeAccessTokenCacheKey, newAccessToken);

        return newAccessToken;
    }

    public async Task<string> RefreshAccessTokenAsync(CancellationToken cancellationToken)
    {
        var newAccessToken = await RetrieveAccessTokenAsync(cancellationToken);

        memoryCache.Set(KindeApiClientConstants.KindeAccessTokenCacheKey, newAccessToken);

        return newAccessToken;
    }

    private async Task<string> RetrieveAccessTokenAsync(CancellationToken cancellationToken)
    {
        var request = new[]
        {
            new KeyValuePair<string, string>("grant_type", "client_credentials"),
            new KeyValuePair<string, string>("client_id", kindeApiClientOptions.Value.ClientId),
            new KeyValuePair<string, string>("client_secret", kindeApiClientOptions.Value.ClientSecret),
            new KeyValuePair<string, string>("audience", kindeApiClientOptions.Value.Audience),
        };

        var content = new FormUrlEncodedContent(request);

        var uri = new Uri(_httpClient.BaseAddress!, "/oauth2/token");

        var response =
            await _httpClient.PostAsync(
                uri, content,
                cancellationToken
            );

        response.EnsureSuccessStatusCode();

        var oauth2TokenResponse =
            JsonSerializer.Deserialize<OAuth2TokenResponse>(
                await response.Content.ReadAsStringAsync(cancellationToken));

        if (oauth2TokenResponse is null)
        {
            throw new Exception("oauth2TokenResponse is null!");
        }

        return oauth2TokenResponse.AccessToken;
    }
}