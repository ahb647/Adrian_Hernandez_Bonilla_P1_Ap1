global using Microsoft.EntityFrameworkCore;
global using Adrian_Hernandez_Bonilla_P1_Ap1.Context;
global using Adrian_Hernandez_Bonilla_P1_Ap1.Models;
global using Adrian_Hernandez_Bonilla_P1_Ap1.Services;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Options;

using Adrian_Hernandez_Bonilla_P1_Ap1.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();




builder.Services.AddDbContextFactory<Contexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConStr"));
});




builder.Services.AddScoped<Service>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
