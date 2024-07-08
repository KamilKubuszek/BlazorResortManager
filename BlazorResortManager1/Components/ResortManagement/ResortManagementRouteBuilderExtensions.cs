using BlazorResortManager1.Data;
using BlazorResortManager1.main;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BlazorResortManager1.Components.ResortManagement
{
    internal static class ResortManagementRouteBuilderExtensions
    {
        public static IEndpointConventionBuilder MapResortManagementEndpoints(this IEndpointRouteBuilder endpoints)
        {
            ArgumentNullException.ThrowIfNull(endpoints);

            var accountGroup = endpoints.MapGroup("/Resort");

            //accountGroup.Map("/Status/Update", async (
            //    IDbContextFactory<ApplicationDbContext> contextFactory,
            //    [FromBody] StatusSheet statusSheet) =>
            //{
            //    using var database = contextFactory.CreateDbContext();
            //    await database.statusSheets.AddAsync(statusSheet);
            //    await database.SaveChangesAsync();
            //    //komentarz
            //    return TypedResults.LocalRedirect($"~/{"Status"}");
            //});

            return accountGroup;
        }
    }
}
