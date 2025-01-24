using Fundanet.Arco.Core.Aspire.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Fundanet.Arco.Core.Aspire.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AspireController : AbpControllerBase
{
    protected AspireController()
    {
        LocalizationResource = typeof(AspireResource);
    }
}
