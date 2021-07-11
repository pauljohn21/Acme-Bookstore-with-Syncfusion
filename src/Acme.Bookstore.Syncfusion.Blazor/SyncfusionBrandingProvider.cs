using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Bookstore.Syncfusion.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class SyncfusionBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Syncfusion";
    }
}
