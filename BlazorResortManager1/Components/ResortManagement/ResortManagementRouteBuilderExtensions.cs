using BlazorResortManager1.Data;
using BlazorResortManager1.Data.Models.main;
using BlazorResortManager1.Data.Models.status;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.Json;

namespace BlazorResortManager1.Components.ResortManagement
{
    internal static class ResortManagementRouteBuilderExtensions
    {
        public static IEndpointConventionBuilder MapResortManagementEndpoints(this IEndpointRouteBuilder endpoints)
        {
            ArgumentNullException.ThrowIfNull(endpoints);

            var accountGroup = endpoints.MapGroup("/Resort");

            accountGroup.Map("/Status/Update", async (
                IDbContextFactory<ApplicationDbContext> contextFactory,
                [FromBody] Track track) =>
            {
                //using var database = contextFactory.CreateDbContext();
                //await database.tracks.AddAsync(track);
                //await database.SaveChangesAsync();

                Console.Write(JsonSerializer.Serialize(trackSubmission, new JsonSerializerOptions()
        // {
        //     WriteIndented = true,
        //     ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
        // }));
        //komentarz
                return TypedResults.LocalRedirect($"~/{"Status"}");
            });

            return accountGroup;
        }
    }
}
