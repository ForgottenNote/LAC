using Microsoft.Extensions.Hosting;
using LAC;

await Host.CreateDefaultBuilder(args)
    .UseSystemd()
    .ConfigureLogging(Startup.ConfigureLogging)
    .ConfigureServices(Startup.ConfigureServices)
    .RunConsoleAsync().ConfigureAwait(false);
