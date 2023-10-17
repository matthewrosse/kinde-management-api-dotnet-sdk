using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using KindeManagementApiClient.Configurations;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Polly;
using Refit;

namespace KindeManagementApiClient.DependencyInjection;

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
            .AddRefitClient<IKindeApiClient>(new RefitSettings(new SystemTextJsonContentSerializer(
                new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
                })))
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