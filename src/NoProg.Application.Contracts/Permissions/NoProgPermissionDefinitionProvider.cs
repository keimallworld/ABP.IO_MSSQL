using NoProg.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NoProg.Permissions;

public class NoProgPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NoProgPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NoProgPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NoProgResource>(name);
    }
}
