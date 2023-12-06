using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Microsoft.AspNetCore.Builder;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UsePresenter(this IApplicationBuilder builder)
    {
        builder.UseWhen(context => context.Request.Path.StartsWithSegments("/ip.axd"), app => app.Run(async context =>
        {
            var ip = "";
            var headers = context.Request.Headers;
            if (headers.ContainsKey("X-Forwarded-For"))
            {
                var ips = new List<string>();
                foreach (var xf in headers["X-Forwarded-For"])
                {
                    if (!string.IsNullOrEmpty(xf))
                    {
                        ips.Add(xf);
                    }
                }
                ip = string.Join(";", ips);
            }
            else
            {
                ip = context.Connection.RemoteIpAddress.ToIPv4String();
            }

            context.Response.Headers.Add("Content-Type", new Microsoft.Extensions.Primitives.StringValues("application/json; charset=utf-8"));
            await context.Response.WriteAsync(JsonSerializer.Serialize(new { Id = context.TraceIdentifier, Ip = ip }));
        }));
        return builder;
    }
}
