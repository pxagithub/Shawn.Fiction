using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Shawn.Fiction
{
    [DependsOn(typeof(AbpAspNetCoreMvcModule), 
               typeof(AbpAutofacModule),
               typeof(FictionHttpApiModule))]
    public class ShawnFictionHttpApiHostingModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            //环境变量，开发变量
            if (env.IsDevelopment())
            {
                //生成异常页面
                app.UseDeveloperExceptionPage();
            }

            //路由
            app.UseRouting();
            //路由映射
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
