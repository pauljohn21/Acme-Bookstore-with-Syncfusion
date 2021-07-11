using Volo.Abp.Modularity;

namespace Acme.Bookstore.Syncfusion
{
    [DependsOn(
        typeof(SyncfusionApplicationModule),
        typeof(SyncfusionDomainTestModule)
        )]
    public class SyncfusionApplicationTestModule : AbpModule
    {

    }
}