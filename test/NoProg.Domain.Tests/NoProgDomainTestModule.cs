using NoProg.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NoProg;

[DependsOn(
    typeof(NoProgEntityFrameworkCoreTestModule)
    )]
public class NoProgDomainTestModule : AbpModule
{

}
