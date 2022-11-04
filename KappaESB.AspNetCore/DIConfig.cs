using KappaESB.Core.Interfaces;
using Microsoft.AspNetCore.Builder;

namespace KappaESB.AspNetCore
{
    public static class DIConfig
    {
        public static IApplicationBuilder MapESBRoutes(this IApplicationBuilder app, Action<IEsbConfig> config)
        {
            //Create config and apply user routes
            IEsbConfig routeConfig = IEsbConfig.Create();
            config.Invoke(routeConfig);

            //Map config to ASP.Net Core endpoints
            app.UseEndpoints(endpoints => { 
            
            });
            return app;
        }
    }
}
