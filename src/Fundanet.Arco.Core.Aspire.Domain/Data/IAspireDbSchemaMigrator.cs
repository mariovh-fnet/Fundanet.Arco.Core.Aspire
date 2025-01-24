using System.Threading.Tasks;

namespace Fundanet.Arco.Core.Aspire.Data;

public interface IAspireDbSchemaMigrator
{
    Task MigrateAsync();
}
