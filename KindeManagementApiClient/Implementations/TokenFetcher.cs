using System.Text.Json;
using KindeManagementApiClient.Abstractions;
using KindeManagementApiClient.Configuration;
using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Responses;
using KindeManagementApiClient.Contracts.V1.Responses.Common;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace KindeManagementApiClient.Implementations;

/// <summary>
/// The default implementation of <see cref="ITokenFetcher"/>
/// </summary>
internal sealed class TokenFetcher : ITokenFetcher
{
    private readonly HttpClient _httpClient;
    private readonly IOptions<KindeApiClientOptions> _kindeApiClientOptions;
    private readonly ILogger<TokenFetcher> _logger;

    public TokenFetcher(
        IHttpClientFactory httpClientFactory,
        IOptions<KindeApiClientOptions> kindeApiClientOptions,
        ILogger<TokenFetcher> logger
    )
    {
        _httpClient = httpClientFactory.CreateClient(KindeApiClientConstants.HttpClientName);
        _kindeApiClientOptions = kindeApiClientOptions;
        _logger = logger;
    }

    /// <summary>
    /// Fetches an access token.
    /// </summary>
    /// <param name="cancellationToken">An instance of <see cref="CancellationToken"/>.</param>
    /// <exception cref="HttpRequestException">When the internal client was unable to obtain the access token.</exception>
    /// <returns>The access token.</returns>
    public async Task<string> FetchAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        var requestContent = CreateAccessTokenRequestContent();

        var uri = new Uri(_httpClient.BaseAddress!, KindeApiRoutes.GetOAuth2AccessToken);

        var response =
            await _httpClient.PostAsync(uri, requestContent, cancellationToken);

        var responseContent =
            await response
                .Content
                .ReadAsStringAsync(cancellationToken);

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException)
        {
            _logger.LogCritical(
                "The token store was unable to retrieve an access token! The content of the failed request: {@RequestContent}",
                responseContent
            );
            throw;
        }

        var oauth2TokenResponse = JsonSerializer.Deserialize<OAuth2TokenResponse>(responseContent);

        ArgumentNullException.ThrowIfNull(oauth2TokenResponse);

        return oauth2TokenResponse.AccessToken;
    }

    private FormUrlEncodedContent CreateAccessTokenRequestContent()
        => new(new[]
        {
            new KeyValuePair<string, string>(
                KindeApiClientConstants.UrlEncodedKeys.GrantType,
                KindeApiClientConstants.GrantType
            ),
            new KeyValuePair<string, string>(
                KindeApiClientConstants.UrlEncodedKeys.ClientId,
                _kindeApiClientOptions.Value.ClientId
            ),
            new KeyValuePair<string, string>(
                KindeApiClientConstants.UrlEncodedKeys.ClientSecret,
                _kindeApiClientOptions.Value.ClientSecret
            ),
            new KeyValuePair<string, string>(
                KindeApiClientConstants.UrlEncodedKeys.Audience,
                _kindeApiClientOptions.Value.Audience
            ),
        });
}