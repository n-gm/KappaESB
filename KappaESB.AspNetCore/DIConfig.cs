using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KappaESB.AspNetCore
{
    public static class DIConfig
    {
        public static IApplicationBuilder MapESBRoutes(this IApplicationBuilder app, RouteMapper mapper)
        {
            app.Map();
            return app;
        }
    }
}
