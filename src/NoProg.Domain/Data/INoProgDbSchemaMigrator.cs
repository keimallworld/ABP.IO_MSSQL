using System.Threading.Tasks;

namespace NoProg.Data;

public interface INoProgDbSchemaMigrator
{
    Task MigrateAsync();
}
