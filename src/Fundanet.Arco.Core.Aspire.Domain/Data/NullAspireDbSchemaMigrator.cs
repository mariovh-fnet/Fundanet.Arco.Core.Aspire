using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Fundanet.Arco.Core.Aspire.Data;

/* This is used if database provider does't define
 * IAspireDbSchemaMigrator implementation.
 */
public class NullAspireDbSchemaMigrator : IAspireDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
