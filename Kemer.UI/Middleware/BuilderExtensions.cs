using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kemer.UI.Middleware
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseSitemapMiddleware(this IApplicationBuilder app,
       string rootUrl = "kemeriskiyafetleri.com/sitemap.xml")
        {
            return app.UseMiddleware<SitemapMiddleware>(new[] { rootUrl });
        }
    }
}
