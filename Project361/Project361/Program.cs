using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Project361.Data;
using Project361.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CardsContext>(dbContextOptionsBuilder =>
    dbContextOptionsBuilder.UseSqlite(builder.Configuration["ConnectionStrings:DefaultConnection"]));
builder.Services.AddDbContext<SolitaireContext>(dbContextOptionsBuilder =>
    dbContextOptionsBuilder.UseSqlite(builder.Configuration["ConnectionStrings:DefaultConnection"]));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy",
        builder =>
        {
            builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowAnyOrigin();
        });
});

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);


var app = builder.Build();


/*
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
*/

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors("CORSPolicy");
app.UseMvc();

// app.UseAuthentication();
// app.UseIdentityServer();
app.UseAuthorization();

/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");
app.MapRazorPages();

app.MapFallbackToFile("index.html");
*/

app.Run();
