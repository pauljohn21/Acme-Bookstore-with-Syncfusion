using System;
using System.Collections.Generic;
using System.Text;
using Acme.Bookstore.Syncfusion.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Bookstore.Syncfusion
{
    /* Inherit your application services from this class.
     */
    public abstract class SyncfusionAppService : ApplicationService
    {
        protected SyncfusionAppService()
        {
            LocalizationResource = typeof(SyncfusionResource);
        }
    }
}
