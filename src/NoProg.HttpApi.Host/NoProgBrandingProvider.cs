using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NoProg;

[Dependency(ReplaceServices = true)]
public class NoProgBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NoProg";
}
