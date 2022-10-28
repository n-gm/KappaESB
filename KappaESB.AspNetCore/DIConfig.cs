using Microsoft.AspNetCore.Builder;

namespace KappaESB.AspNetCore
{
    public static class DIConfig
    {
        public static IApplicationBuilder MapESBRoutes(this IApplicationBuilder app, RouteMapper mapper)
        {
            app.UseEndpoints(endpoints => { 
            
            });
            return app;
        }
    }
}
