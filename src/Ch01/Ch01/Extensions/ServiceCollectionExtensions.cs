using Ch01.Runnables;
using CoreServices.Runner.Extensions;
using CoreServices.Runner.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Ch01.Extensions;

public static class ServiceCollectionExtensions
{

    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        _ = services.ConfigureRunnerServices();

        // IMPORTANT! Register the application entry point
        _ = services.AddKeyedTransient<IRunnable, HelloCSApp>("HelloCSApp");
        _ = services.AddKeyedTransient<IRunnable, HelloEnvironmentApp>("HelloEnvironmentApp");

        return services;
    }

}
