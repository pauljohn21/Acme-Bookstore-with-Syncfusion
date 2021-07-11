using Volo.Abp.Settings;

namespace Acme.Bookstore.Syncfusion.Settings
{
    public class SyncfusionSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SyncfusionSettings.MySetting1));
        }
    }
}
