using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shawn.Fiction.Data;
using Volo.Abp.DependencyInjection;

namespace Shawn.Fiction.EntityFrameworkCore
{
    public class EntityFrameworkCoreFictionDbSchemaMigrator
        : IFictionDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFictionDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FictionMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FictionMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}