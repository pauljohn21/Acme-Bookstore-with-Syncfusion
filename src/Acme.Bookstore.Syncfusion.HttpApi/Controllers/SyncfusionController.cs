using Acme.Bookstore.Syncfusion.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Bookstore.Syncfusion.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SyncfusionController : AbpController
    {
        protected SyncfusionController()
        {
            LocalizationResource = typeof(SyncfusionResource);
        }
    }
}