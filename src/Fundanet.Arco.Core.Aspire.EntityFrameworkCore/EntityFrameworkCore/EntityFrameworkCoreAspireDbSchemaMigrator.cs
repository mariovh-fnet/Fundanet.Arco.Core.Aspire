using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Fundanet.Arco.Core.Aspire.Data;
using Volo.Abp.DependencyInjection;

namespace Fundanet.Arco.Core.Aspire.EntityFrameworkCore;

public class EntityFrameworkCoreAspireDbSchemaMigrator
    : IAspireDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAspireDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AspireDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AspireDbContext>()
            .Database
            .MigrateAsync();
    }
}
