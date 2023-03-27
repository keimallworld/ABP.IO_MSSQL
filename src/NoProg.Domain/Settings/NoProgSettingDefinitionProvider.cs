using Volo.Abp.Settings;

namespace NoProg.Settings;

public class NoProgSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NoProgSettings.MySetting1));
    }
}
