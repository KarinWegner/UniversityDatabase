using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UniversityDatabase.Extensions;
using UniversityDatabase.Persistance;
using UniversityDatabase.Persistance.Data;



internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<UniversityDatabaseContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("UniversityDatabaseContext") ?? throw new InvalidOperationException("Connection string 'UniversityDatabaseContext' not found.")));

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();



        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        else
        {
            await app.SeedDataAsync();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Students}/{action=Index}/{id?}");

        app.Run();
    }
}