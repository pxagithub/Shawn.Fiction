using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Shawn.Fiction.EntityFrameworkCore
{
    [DependsOn(
        typeof(FictionEntityFrameworkCoreModule)
        )]
    public class FictionEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FictionMigrationsDbContext>();
        }
    }
}
