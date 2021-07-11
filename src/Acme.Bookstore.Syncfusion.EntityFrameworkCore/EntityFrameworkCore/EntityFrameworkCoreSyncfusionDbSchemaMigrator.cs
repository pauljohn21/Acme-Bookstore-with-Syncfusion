using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.Bookstore.Syncfusion.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.Bookstore.Syncfusion.EntityFrameworkCore
{
    public class EntityFrameworkCoreSyncfusionDbSchemaMigrator
        : ISyncfusionDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSyncfusionDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the SyncfusionDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<SyncfusionDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
