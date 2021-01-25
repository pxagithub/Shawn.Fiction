using Volo.Abp.Settings;

namespace Shawn.Fiction.Settings
{
    public class FictionSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FictionSettings.MySetting1));
        }
    }
}
