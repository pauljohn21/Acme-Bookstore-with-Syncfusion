using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.Bookstore.Syncfusion.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SyncfusionDbContextFactory : IDesignTimeDbContextFactory<SyncfusionDbContext>
    {
        public SyncfusionDbContext CreateDbContext(string[] args)
        {
            SyncfusionEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SyncfusionDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SyncfusionDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.Bookstore.Syncfusion.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
