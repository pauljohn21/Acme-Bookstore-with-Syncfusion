using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Bookstore.Syncfusion
{
    [Dependency(ReplaceServices = true)]
    public class SyncfusionBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Syncfusion";
    }
}
