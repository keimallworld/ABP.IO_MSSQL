using Volo.Abp.Modularity;

namespace NoProg;

[DependsOn(
    typeof(NoProgApplicationModule),
    typeof(NoProgDomainTestModule)
    )]
public class NoProgApplicationTestModule : AbpModule
{

}
