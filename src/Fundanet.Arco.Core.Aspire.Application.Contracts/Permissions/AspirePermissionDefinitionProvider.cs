using Fundanet.Arco.Core.Aspire.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Fundanet.Arco.Core.Aspire.Permissions;

public class AspirePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AspirePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AspirePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AspireResource>(name);
    }
}
