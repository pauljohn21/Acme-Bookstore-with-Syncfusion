using Acme.Bookstore.Syncfusion.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Bookstore.Syncfusion
{
    [DependsOn(
        typeof(SyncfusionEntityFrameworkCoreTestModule)
        )]
    public class SyncfusionDomainTestModule : AbpModule
    {

    }
}