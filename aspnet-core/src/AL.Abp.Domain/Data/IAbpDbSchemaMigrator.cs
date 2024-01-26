using System.Threading.Tasks;

namespace AL.Abp.Data;

public interface IAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
