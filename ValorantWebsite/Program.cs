using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using ValorantWebsite.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ValorantDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:ValorantWebsiteConnection"]);
});

builder.Services.AddRazorPages();
builder.Services.AddScoped<IValorantRepository, EFValorantRepository>();

var app = builder.Build();

app.UseStaticFiles();
/*
app.MapControllerRoute("rolePage", "{role}/Page{agentPage:int}", new { Controller = "Home", action = "Index" });
app.MapControllerRoute("page", "Page{agentPage:int}", new { Controller = "Home", action = "Index", agentPage = 1 });
app.MapControllerRoute("role", "{role}", new { Controller = "Home", action = "Index", agentPage = 1 });
app.MapControllerRoute("pagination", "Agents/Page{agentPage}", new { Controller = "Home", action = "Index", agentPage = 1 });
*/

/*
 Routing for Agents Page
 */
app.MapControllerRoute("rolePage", "{role}/Page{agentPage:int}", new { Controller = "Agent", action = "AgentList" });
app.MapControllerRoute("page", "Page{agentPage:int}", new { Controller = "Agent", action = "AgentList" });
app.MapControllerRoute("role", "{role}", new { Controller = "Agent", action = "AgentList" });
app.MapControllerRoute("pagination_agents", "Agents/Page{agentPage}", new { Controller = "Agent", action = "AgentList" });

/*
 Routing for Maps Page
 */
app.MapControllerRoute("mapNamePage", "{mapName}/Page{mapPage:int}", new { Controller = "Map", action = "MapList" });
app.MapControllerRoute("page", "Page{mapPage:int}", new { Controller = "Map", action = "MapList" });
app.MapControllerRoute("mapName", "{mapName}", new { Controller = "Map", action = "MapList" });
app.MapControllerRoute("pagination_maps", "Maps/Page{mapPage}", new { Controller = "Map", action = "MapList" });

app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);

app.Run();
