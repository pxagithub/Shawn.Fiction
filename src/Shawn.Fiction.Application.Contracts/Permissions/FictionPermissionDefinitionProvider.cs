using Shawn.Fiction.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Shawn.Fiction.Permissions
{
    public class FictionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FictionPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FictionPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FictionResource>(name);
        }
    }
}
