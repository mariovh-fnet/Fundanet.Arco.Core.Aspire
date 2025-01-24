using Fundanet.Arco.Core.Aspire.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Fundanet.Arco.Core.Aspire.Blazor.Client;

public abstract class AspireComponentBase : AbpComponentBase
{
    protected AspireComponentBase()
    {
        LocalizationResource = typeof(AspireResource);
    }
}
