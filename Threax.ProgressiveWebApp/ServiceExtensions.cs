using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Threax.ProgressiveWebApp;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddThreaxProgressiveWebApp(this IServiceCollection services, Action<DisplayConfig> configure)
        {
            var options = new DisplayConfig();

            configure.Invoke(options);

            services.TryAddSingleton<DisplayConfig>(options);
            services.TryAddScoped<IWebManifestProvider, WebManifestProvider>();

            return services;
        }
    }
}
