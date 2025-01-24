using System;
using System.Collections.Generic;
using System.Text;
using Fundanet.Arco.Core.Aspire.Localization;
using Volo.Abp.Application.Services;

namespace Fundanet.Arco.Core.Aspire;

/* Inherit your application services from this class.
 */
public abstract class AspireAppService : ApplicationService
{
    protected AspireAppService()
    {
        LocalizationResource = typeof(AspireResource);
    }
}
