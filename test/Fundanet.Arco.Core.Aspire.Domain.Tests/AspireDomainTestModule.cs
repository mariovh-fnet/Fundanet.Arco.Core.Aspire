using Volo.Abp.Modularity;

namespace Fundanet.Arco.Core.Aspire;

[DependsOn(
    typeof(AspireDomainModule),
    typeof(AspireTestBaseModule)
)]
public class AspireDomainTestModule : AbpModule
{

}
