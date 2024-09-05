using BlazorResortManager1.Components;
using BlazorResortManager1.Components.Account;
using BlazorResortManager1.Components.ResortManagement;
using BlazorResortManager1.Data;
using BlazorResortManager1.Data.Models.yrnoWeatherForecast;
using BlazorResortManager1.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using BlazorResortManager1.Resources;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Globalization;
using Microsoft.Extensions.Localization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Radzen services
builder.Services.AddScoped<DialogService>();
builder.Services.AddRadzenComponents();

#region Custom Implementation
//Utility service
builder.Services.AddScoped<ResortChangeManager>();

//Yr.No client service
//builder.Services.AddScoped<IForecastClient, ForecastClient>();
//builder.Services.AddSingleton<IHttpClientFactory, IHttpClientFactory>();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IForecastClient, ForecastClient>();
//builder.Services.TryAddSingleton<IHttpMessageHandlerFactory>( e => e.GetRequiredService<IHttpMessageHandlerFactory>());
builder.Services.AddHttpClient("YrnoClient", client =>
{
    client.BaseAddress = new Uri("https://api.met.no/weatherapi/locationforecast/2.0/compact");
    client.DefaultRequestHeaders.Add("User-Agent", builder.Configuration.GetSection("ForecastUserAgent").Value);
});


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

//builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddTransient<IEmailSender<ApplicationUser>, EmailService>();

#endregion

#region identity

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();




builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

#endregion

builder.Services.AddLocalization();
//builder.Services.AddScoped<IStringLocalizer<AppLanguage>, StringLocalizer<AppLanguage>>();
var app = builder.Build();

//check which website can embed this thing
app.UseMiddleware<AllowedDomainsMiddleware>();


#region misc code
//using (var scope = app.Services.CreateScope())
//{
//    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

//    string[] roleNames = { "Admin" };
//    foreach (var roleName in roleNames)
//    {
//        if (!await roleManager.RoleExistsAsync(roleName))
//        {
//            await roleManager.CreateAsync(new IdentityRole(roleName));
//        }
//    }

//    // Optional: Assign a role to a user
//    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
//    var user = await userManager.FindByEmailAsync("kamil@kamil.com");
//    if (user != null)
//    {
//        await userManager.AddToRoleAsync(user, "Admin");
//    }
//}


//app.MapPost("/end", (IValidatableObject Validator, [FromBody] Resort resort ) =>
//{
//    var result = Validator.Validate(new ValidationContext(resort));

//});
#endregion


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRequestLocalization(new RequestLocalizationOptions()
     .AddSupportedCultures(new[] { "pl-PL", "en-US" })
     .AddSupportedUICultures(new[] { "pl-PL", "en-US" }));

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.MapResortManagementEndpoints();

app.Run();
