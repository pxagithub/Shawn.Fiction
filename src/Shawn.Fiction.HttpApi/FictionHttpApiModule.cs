using Localization.Resources.AbpUi;
using Shawn.Fiction.Localization;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Shawn.Fiction.Application;

namespace Shawn.Fiction
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(FictionApplicationModule)
        )]
    public class FictionHttpApiModule : AbpModule
    {
        
    }
}
