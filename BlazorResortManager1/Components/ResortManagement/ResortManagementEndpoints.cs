using BlazorResortManager1.Data;
using BlazorResortManager1.Data.Models.status;
using BlazorResortManager1.Data.Models.Tracks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.Json;

namespace BlazorResortManager1.Components.ResortManagement
{
    internal static class ResortManagementEndpoints
    {
        public static void MapResortManagementEndpoints(this WebApplication app)
        {
            

            var ResortGroup = app.MapGroup("/Resort");

            ResortGroup.Map("/Track/Add", async (
                IDbContextFactory<ApplicationDbContext> contextFactory,
                [FromForm] Track track) =>
            {
                //using var database = contextFactory.CreateDbContext();
                //await database.tracks.AddAsync(track);
                //await database.SaveChangesAsync();
                Console.Write(JsonSerializer.Serialize(track, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
                }));

                return TypedResults.LocalRedirect($"~/{"Status"}");
            });

        }
    }
}
