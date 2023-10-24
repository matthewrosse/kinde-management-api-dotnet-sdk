using System.Net;
using System.Net.Mime;
using KindeManagementApiClient.Abstractions;
using KindeManagementApiClient.Configuration;
using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Polly;
using Polly.Extensions.Http;
using Polly.Retry;
using Refit;

namespace KindeManagementApiClient.Extensions;

public static class ServiceCollectionExtensions
{
    private static readonly AsyncRetryPolicy<HttpResponseMessage> KindeApiClientPolicy = HttpPolicyExtensions
        .HandleTransientHttpError()
        .OrResult(response => response.StatusCode == HttpStatusCode.TooManyRequests)
        .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

    /// <summary>
    /// Adds the necessary services and configuration for consuming the Kinde management API.
    /// </summary>
    /// <param name="services">An instance of <see cref="IServiceCollection"/>.</param>
    /// <returns>An instance of <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddKindeApiClient(
        this IServiceCollection services
    )
        => services
            .AddTransient<AuthorizationHeaderDelegatingHandler>()
            .AddSingleton<IAuthTokenStore, AuthTokenStore>()
            .AddSingleton<ITokenFetcher, TokenFetcher>()
            .AddMemoryCache()
            .AddKindeHttpClient();

    private static IServiceCollection AddKindeHttpClient(
        this IServiceCollection services
    )
        => services
            .AddHttpClient()
            .AddKindeApiClientOptions()
            .AddRefitClient<IKindeApiClient>()
            .ConfigureHttpClient((provider, client) =>
            {
                var kindeApiClientOptions = provider.GetRequiredService<IOptions<KindeApiClientOptions>>().Value;

                client.BaseAddress = new Uri(kindeApiClientOptions.Domain);
            })
            .AddHttpMessageHandler<AuthorizationHeaderDelegatingHandler>()
            .AddPolicyHandler(KindeApiClientPolicy)
            .Services
            .AddHttpClient(KindeApiClientConstants.HttpClientName)
            .ConfigureHttpClient((provider, client) =>
            {
                var kindeApiClientOptions = provider.GetRequiredService<IOptions<KindeApiClientOptions>>().Value;

                client.BaseAddress = new Uri(kindeApiClientOptions.Domain);
                client.DefaultRequestHeaders.Add(HeaderNames.Accept, MediaTypeNames.Application.Json);
            })
            .Services;

    private static IServiceCollection AddKindeApiClientOptions(
        this IServiceCollection services
    )
        => services
            .AddOptions<KindeApiClientOptions>()
            .BindConfiguration(KindeApiClientOptions.SectionName)
            .ValidateDataAnnotations()
            .ValidateOnStart()
            .Services;
}