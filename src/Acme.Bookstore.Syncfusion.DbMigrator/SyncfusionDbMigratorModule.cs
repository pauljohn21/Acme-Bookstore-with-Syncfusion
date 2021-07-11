using Acme.Bookstore.Syncfusion.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.Bookstore.Syncfusion.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SyncfusionEntityFrameworkCoreModule),
        typeof(SyncfusionApplicationContractsModule)
        )]
    public class SyncfusionDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
