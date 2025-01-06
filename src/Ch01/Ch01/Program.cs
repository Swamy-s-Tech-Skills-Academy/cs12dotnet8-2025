using Ch01.Extensions;
using CoreServices.Runner.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost? host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

// Get IRunnableManager from the service provider
IRunnableManager? runnableManager = host.Services.GetRequiredService<IRunnableManager>();

runnableManager.RunAllRunnables("Ch01.Runnables");

WriteLine("\n\nPress any key to exit..."); 
ReadKey(true); 
