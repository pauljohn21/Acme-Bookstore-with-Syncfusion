using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Bookstore.Syncfusion.Data
{
    /* This is used if database provider does't define
     * ISyncfusionDbSchemaMigrator implementation.
     */
    public class NullSyncfusionDbSchemaMigrator : ISyncfusionDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}