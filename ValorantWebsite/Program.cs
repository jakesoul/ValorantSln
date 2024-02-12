using Microsoft.EntityFrameworkCore;
using ValorantWebsite.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ValorantDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:ValorantWebsiteConnection"]);
});

builder.Services.AddScoped<IValorantRepository, EFValorantRepository>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute("rolePage", "{role}/Page{agentPage:int}", new { Controller = "Home", action = "Index" });
app.MapControllerRoute("page", "Page{agentPage:int}", new { Controller = "Home", action = "Index", agentPage = 1 });
app.MapControllerRoute("role", "{role}", new { Controller = "Home", action = "Index", agentPage = 1 });
app.MapControllerRoute("pagination", "Agents/Page{agentPage}", new { Controller = "Home", action = "Index", agentPage = 1 });
app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);

app.Run();
