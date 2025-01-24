using Fundanet.Arco.Core.Aspire.Samples;
using Xunit;

namespace Fundanet.Arco.Core.Aspire.EntityFrameworkCore.Applications;

[Collection(AspireTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AspireEntityFrameworkCoreTestModule>
{

}
