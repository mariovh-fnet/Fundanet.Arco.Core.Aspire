using Volo.Abp.Modularity;

namespace Fundanet.Arco.Core.Aspire;

[DependsOn(
    typeof(AspireApplicationModule),
    typeof(AspireDomainTestModule)
)]
public class AspireApplicationTestModule : AbpModule
{

}
