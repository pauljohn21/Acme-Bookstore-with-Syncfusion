using Acme.Bookstore.Syncfusion.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Acme.Bookstore.Syncfusion.Blazor
{
    public abstract class SyncfusionComponentBase : AbpComponentBase
    {
        protected SyncfusionComponentBase()
        {
            LocalizationResource = typeof(SyncfusionResource);
        }
    }
}
