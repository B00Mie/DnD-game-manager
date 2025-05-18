using Microsoft.EntityFrameworkCore;
using Server.Components;
using Server.Database;
using Server.Hubs;
using Server.Models;
using Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<MessageStore>();
builder.Services.AddSingleton<MessageService>();


builder.Services.AddSignalR();

builder.Services.AddDbContextFactory<MainDbContext>(opts =>
    opts.UseSqlite("Data Source=main.db;Cache=Shared"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapHub<MainHub>("/hubs/main");


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
