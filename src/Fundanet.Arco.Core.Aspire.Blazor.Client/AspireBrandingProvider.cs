using Microsoft.Extensions.Localization;
using Fundanet.Arco.Core.Aspire.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Fundanet.Arco.Core.Aspire.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class AspireBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AspireResource> _localizer;

    public AspireBrandingProvider(IStringLocalizer<AspireResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
