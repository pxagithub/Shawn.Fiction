using Volo.Abp.Application.Services;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Shawn.Fiction
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule)
        )]
    public class FictionApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            
        }
    }
}
