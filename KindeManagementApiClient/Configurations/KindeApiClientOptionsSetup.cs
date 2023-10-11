using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace KindeManagementApiClient.Configurations;

public sealed class KindeApiClientOptionsSetup(IConfiguration configuration) : IConfigureOptions<KindeApiClientOptions>
{
    private const string SectionName = nameof(KindeApiClientOptions);

    public void Configure(KindeApiClientOptions options)
        => configuration
            .GetRequiredSection(SectionName)
            .Bind(options);
}