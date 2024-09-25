using BlazorResortManager1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BlazorResortManager1.Services
{
    public class AllowedDomainsMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IServiceScopeFactory _scopeFactory;

        public AllowedDomainsMiddleware(RequestDelegate next, IServiceScopeFactory scopeFactory)
        {
            _next = next;
            _scopeFactory = scopeFactory;
        }

        public async Task Invoke(HttpContext context)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                var referer = context.Request.Headers["Referer"].ToString();
                var origin = context.Request.Headers["Origin"].ToString();

                // Fetch allowed domains from the database
                var allowedDomains = await dbContext.widgetWhitelistedUrls
                    .Select(e => e.siteUrl.Trim().ToLowerInvariant())
                    .ToListAsync();

                // Normalize referer and origin to avoid trailing slashes and ensure consistency
                var normalizedReferer = referer.Trim().ToLowerInvariant();
                var normalizedOrigin = origin.Trim().ToLowerInvariant();

                bool isAllowed = false;
                //Console.WriteLine(normalizedOrigin + " ---- " + normalizedReferer);
                if (!string.IsNullOrEmpty(normalizedOrigin) || !string.IsNullOrEmpty(normalizedOrigin))
                {
                    isAllowed = allowedDomains.Any(domain =>
                    normalizedReferer.StartsWith($"https://{domain}") ||
                    normalizedOrigin.StartsWith($"https://{domain}"));
                }
                else
                {
                    isAllowed = true;
                }
                

                // If not allowed, return a 403 Forbidden response
                if (!isAllowed)
                {
                    context.Response.StatusCode = 403; // Forbidden
                    await context.Response.WriteAsync("This website is not allowed to embed this widget.");
                    return;
                }

                // Set the CSP header to restrict embedding only to allowed domains if allowed
                //var frameAncestors = string.Join(" ", allowedDomains.Select(d => $"https://{d}"));
                //context.Response.Headers["Content-Security-Policy"] = $"frame-ancestors 'self' {frameAncestors}";
            }

            await _next(context);
        }
    }
}
