using System.Net.Mime;
using Kinde.ApiClient.Configurations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Polly;
using Refit;

namespace Kinde.ApiClient.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddKindeApiClient(this IServiceCollection services)
        => services
            .ConfigureOptions<KindeApiClientOptionsSetup>()
            .AddTransient<AuthorizationHeaderDelegatingHandler>()
            .AddTransient<IAuthTokenStore, AuthTokenStore>()
            .AddHttpContextAccessor()
            .AddMemoryCache()
            .AddKindeHttpClient()
            .AddKindeTypedHttpClient();

    private static IServiceCollection AddKindeTypedHttpClient(this IServiceCollection services)
        => services
            .AddRefitClient<IKindeApiClient>()
            .ConfigureHttpClient((provider, client) =>
            {
                var kindeApiClientOptions = provider.GetRequiredService<IOptions<KindeApiClientOptions>>().Value;

                client.BaseAddress = new Uri(kindeApiClientOptions.Domain);
            })
            .AddHttpMessageHandler<AuthorizationHeaderDelegatingHandler>()
            .AddTransientHttpErrorPolicy(builder =>
                builder.WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(2))
            )
            .Services;

    private static IServiceCollection AddKindeHttpClient(this IServiceCollection services)
        => services.AddHttpClient(KindeApiClientConstants.KindeHttpClientName)
            .ConfigureHttpClient((provider, client) =>
            {
                var kindeApiClientOptions = provider.GetRequiredService<IOptions<KindeApiClientOptions>>().Value;

                client.BaseAddress = new Uri(new Uri(kindeApiClientOptions.Domain), "/api");
                client.DefaultRequestHeaders.Add(HeaderNames.Accept, MediaTypeNames.Application.Json);
            })
            .Services;
}