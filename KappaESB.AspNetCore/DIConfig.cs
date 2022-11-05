using KappaESB.Core.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace KappaESB.AspNetCore
{
    public static class DIConfig
    {
        public static IServiceCollection AddEsbServices(this IServiceCollection services)
        {
            IEsbCore core = IEsbCore.Create();
            services.AddSingleton(core);
            return services;
        }

        public static IApplicationBuilder MapESBRoutes(this IApplicationBuilder app, Action<IEsbConfig> config)
        {
            //Create config and apply user routes
            IEsbConfig routeConfig = IEsbConfig.Create();
            config.Invoke(routeConfig);
            

            //Map config to ASP.Net Core endpoints
            app.UseEndpoints(endpoints => { 
                endpoints.Map()
            });
            return app;
        }
    }
}
