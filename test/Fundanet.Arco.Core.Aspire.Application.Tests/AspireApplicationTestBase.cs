using Volo.Abp.Modularity;

namespace Fundanet.Arco.Core.Aspire;

public abstract class AspireApplicationTestBase<TStartupModule> : AspireTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
