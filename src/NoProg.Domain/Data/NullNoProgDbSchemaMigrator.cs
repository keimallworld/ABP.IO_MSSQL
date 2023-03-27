using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NoProg.Data;

/* This is used if database provider does't define
 * INoProgDbSchemaMigrator implementation.
 */
public class NullNoProgDbSchemaMigrator : INoProgDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
