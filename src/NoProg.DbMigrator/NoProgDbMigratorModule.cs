using NoProg.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace NoProg.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NoProgEntityFrameworkCoreModule),
    typeof(NoProgApplicationContractsModule)
    )]
public class NoProgDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
