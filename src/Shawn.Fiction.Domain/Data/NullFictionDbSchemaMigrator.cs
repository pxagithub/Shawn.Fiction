using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Shawn.Fiction.Data
{
    /* This is used if database provider does't define
     * IFictionDbSchemaMigrator implementation.
     */
    public class NullFictionDbSchemaMigrator : IFictionDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}