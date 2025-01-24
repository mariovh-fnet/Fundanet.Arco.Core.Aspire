using Fundanet.Arco.Core.Aspire.Samples;
using Xunit;

namespace Fundanet.Arco.Core.Aspire.EntityFrameworkCore.Domains;

[Collection(AspireTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AspireEntityFrameworkCoreTestModule>
{

}
