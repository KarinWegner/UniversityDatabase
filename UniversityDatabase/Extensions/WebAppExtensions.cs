using Microsoft.CodeAnalysis.CSharp.Syntax;
using UniversityDatabase.Persistance.Data;
using UniversityDatabase.Persistance;

namespace UniversityDatabase.Extensions
{
    public static class WebAppExtensions
    {
        public static async Task SeedDataAsync(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<UniversityDatabaseContext>();

                //await context.Database.EnsureDeletedAsync();
                //await context.Database.MigrateAsync();

                try
                {
                    await SeedData.InitAsync(context);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
