using Volo.Abp.Modularity;

namespace Fundanet.Arco.Core.Aspire;

/* Inherit from this class for your domain layer tests. */
public abstract class AspireDomainTestBase<TStartupModule> : AspireTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
