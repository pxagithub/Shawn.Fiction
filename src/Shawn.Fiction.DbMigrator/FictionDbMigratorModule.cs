using Shawn.Fiction.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Shawn.Fiction.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FictionEntityFrameworkCoreDbMigrationsModule),
        typeof(FictionApplicationContractsModule)
        )]
    public class FictionDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
