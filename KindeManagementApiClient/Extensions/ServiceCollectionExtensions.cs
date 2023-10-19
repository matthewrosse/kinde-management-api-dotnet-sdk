using System.Net.Mime;
using KindeManagementApiClient.Abstractions;
using KindeManagementApiClient.Configuration;
using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Polly;
using Refit;

namespace KindeManagementApiClient.Extensions;

public static class ServiceCollectionExtensions
{
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
            .AddKindeApiClientOptions()
            .AddRefitClient<IKindeApiClient>()
            .ConfigureHttpClient((provider, client) =>
            {
                var kindeApiClientOptions = provider.GetRequiredService<IOptions<KindeApiClientOptions>>().Value;

                client.BaseAddress = new Uri(kindeApiClientOptions.Domain);
            })
            .AddHttpMessageHandler<AuthorizationHeaderDelegatingHandler>()
            .AddTransientHttpErrorPolicy(builder =>
                builder.WaitAndRetryAsync(3, i => i * TimeSpan.FromMilliseconds(500))
            )
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