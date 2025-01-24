using Xunit;

namespace Fundanet.Arco.Core.Aspire.EntityFrameworkCore;

[CollectionDefinition(AspireTestConsts.CollectionDefinitionName)]
public class AspireEntityFrameworkCoreCollection : ICollectionFixture<AspireEntityFrameworkCoreFixture>
{

}
