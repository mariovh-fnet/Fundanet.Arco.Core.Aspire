using Fundanet.Arco.Core.Aspire.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Fundanet.Arco.Core.Aspire.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AspireEntityFrameworkCoreModule),
    typeof(AspireApplicationContractsModule)
    )]
public class AspireDbMigratorModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        configuration["Redis:Configuration"] = configuration["ConnectionStrings:Redis"];
    }
}
