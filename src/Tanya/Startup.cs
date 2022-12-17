using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using LAC.Driver.Linux;
using LAC.Game.Apex;
using LAC.Logging;

namespace LAC
{
    public static class Startup
    {
        #region Statics

        public static void ConfigureLogging(ILoggingBuilder builder)
        {
            builder.ClearProviders();
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, LoggerProvider>());
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Linux>();
            Bootstrap.ConfigureServices(services);
        }

        #endregion
    }
}
